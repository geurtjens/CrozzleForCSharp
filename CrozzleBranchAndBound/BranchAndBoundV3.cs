using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleShapeMerger;

namespace CrozzleBranchAndBound;

public class BranchAndBoundV3
{

    public static ShapeModel Execute(
        int gameId,
        in List<string> words,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        int winningScore,
        bool useGuidedScores)
    {
        var (_, searchShapes, wordIndex, rootTreeNodes, scoresMin, widthMax, heightMax) =
            GetStartingData.Execute(gameId, words, rootWidth, useGuidedScores);

        Console.WriteLine($"{{\"game\": {gameId}, \"wordCount\": {words.Count}, \"searchShapes\": {searchShapes.Count}, " +
            $"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"rootWidth\": {rootWidth}, " +
            $"\"maxDepth\": {maxDepth}, \"cycles\": [");

        var bestShapes = ExecuteCycles(
            gameId,
            words,
            lookaheadDepth,
            beamWidth,
            maxDepth,
            winningScore,
            searchShapes,
            wordIndex,
            widthMax,
            heightMax,
            scoresMin,
            rootTreeNodes);

        var bestShape = bestShapes[0];

        if (bestShapes[0].Score == winningScore)
        {
            return bestShapes[0];
        }

        for (var i = 0; i < bestShapes.Count; i++)
        {
            var shapes = SiblingMergeCalculator.GetAllMatchingShapes(
                wordIndex,
                bestShapes[i],
                searchShapes,
                words,
                scoresMin,
                widthMax,
                heightMax);

            foreach (var shape in shapes)
            {
                if (shape.Score > bestShape.Score)
                {
                    bestShape = shape;
                }
            }
        }

        if (bestShape.Score >= winningScore)
        {
            Console.WriteLine($"HUMAN SCORE {gameId} Calculated at end");
        }

        return bestShape;
    }

    public static List<ShapeModel> ExecuteCycles(
        int gameId,
        in List<string> words,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int winningScore,
        in List<ShapeModel> searchShapes,
        in WordIndexModelV2 wordIndex,
        int widthMax,
        int heightMax,
        in List<int> scoresMin,
        in List<TreeNodeModel> rootTreeNodes)
    {
        var startTime = DateTimeCalculator.Now();

        var bestShape = rootTreeNodes[0].ParentShape;
        var bestScores = new List<ushort>();
        var shapesCreatedCount = 0;
        var shapesCreated = 0;

        var treeNodes = rootTreeNodes;
        var previousNodes = treeNodes;

        for (var cycleId = 0; cycleId < maxDepth; cycleId++)
        {
            treeNodes = ExecuteTreeNodes(treeNodes, searchShapes, words, widthMax, heightMax,
                wordIndex, scoresMin);

            shapesCreatedCount = treeNodes.Count;
            foreach (var treeNode in treeNodes)
            {
                shapesCreatedCount += treeNode.ChildShapes.Count;
            }

            (treeNodes, shapesCreated) = ExecuteLookaheadAndBeam(
                lookaheadDepth, beamWidth, treeNodes, searchShapes, words, widthMax, heightMax,
                wordIndex, scoresMin);

            shapesCreatedCount += shapesCreated;

            if (treeNodes.Count > 0)
            {
                previousNodes = treeNodes;
            }
            else
            {
                List<ShapeModel> childShapes = new List<ShapeModel>();
                foreach (var treeNode in previousNodes)
                {
                    childShapes.AddRange(treeNode.ChildShapes);
                }

                childShapes = ShapeList.RemoveDuplicates(childShapes).OrderByDescending(e => e.Score).ToList();

                var bestShapes = new List<ShapeModel>();

                for (var childShapeId = 0; childShapeId < childShapes.Count && bestShapes.Count < beamWidth; childShapeId++)
                {
                    bestShapes.Add(childShapes[childShapeId]);
                    
                }

                bestShapes = bestShapes.OrderByDescending(e => e.Score).ToList();
                bestScores.Clear();
                foreach(var shape in bestShapes)
                {
                    bestScores.Add(shape.Score);
                }


                if (bestShape.Score < bestShapes[0].Score)
                {
                    bestShape = bestShapes[0];
                }
                
                Console.WriteLine($" bestGame: {bestShape.ToTextArray(words)}");
                

                var siblingMerges = TreeNodeList.IdentifySiblingMerges(treeNodes, 1, 2);

                // but this is the winning game, why cant it recognise it
                Console.WriteLine($"{{\"cycle\": {cycleId + 1}, \"shapesCreated\": {shapesCreatedCount}, " +
                    $"\"bestScores\": [{string.Join(",", bestScores)}],\n");

                if (bestShape.Score >= winningScore)
                {
                    Console.WriteLine($" bestGame: {bestShape.ToTextArray(words)}");
                    Console.WriteLine($"HUMAN SCORE {gameId}");
                    Console.WriteLine(DateTimeCalculator.Duration(start: startTime));
                    return bestShapes;
                }
                else
                {
                    Console.WriteLine($" bestGame: {bestShape.ToTextArray(words)}");
                    Console.WriteLine($" expected: {winningScore}");
                    Console.WriteLine($"FAILED {gameId}");
                    Console.WriteLine(DateTimeCalculator.Duration(start: startTime));
                    return bestShapes;
                }
            }
            if (cycleId == 0)
            {
                Console.Write($"{{\"cycle\": 0, \"shapesCreated\": 1, " +
                $"\"bestScores\": [{bestShape.Score}], ");
            }
            Console.WriteLine($" \"bestGame\": {bestShape.ToTextArray(words)}");

            if (treeNodes.Count > 0)
            {
                var bestShapes = treeNodes.Select(treeNode => treeNode.ParentShape).ToList();
                bestShapes = ShapeList.RemoveDuplicates(bestShapes);

                bestShapes = bestShapes.OrderByDescending(e => e.Score).ToList();
                bestScores.Clear();
                foreach (var shape in bestShapes)
                {
                    bestScores.Add(shape.Score);
                }

                if (bestShape.Score < bestShapes[0].Score)
                {
                    bestShape = bestShapes[0];
                }

                var siblingMerges = new List<(int, int, List<int>)>();

                Console.Write($"{{\"cycle\": {cycleId + 1}, \"shapesCreated\": {shapesCreatedCount}, " +
                    $"\"bestScores\": [{string.Join(",", bestScores)}],");
                
            }
        }

        return new List<ShapeModel>();
    }


    public static List<TreeNodeModel> ExecuteTreeNodes(
    in List<TreeNodeModel> treeNodes,
    in List<ShapeModel> searchShapes,
    in List<string> words,
    int widthMax,
    int heightMax,
    in WordIndexModelV2 wordIndex,
    in List<int> scoresMin)
    {
        var result = new List<TreeNodeModel>();

        foreach (var treeNode in treeNodes)
        {
            var values = ExecuteTreeNode(
                treeNode, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);

            result.AddRange(values);
        }
        result = TreeNodeList.SortByBestDescendant(result);


        return result;
    }



    public static List<TreeNodeModel> ExecuteTreeNode(
        in TreeNodeModel treeNode,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        int widthMax,
        int heightMax,
        in WordIndexModelV2 wordIndex,
        in List<int> scoresMin)
    {
        var result = new List<TreeNodeModel>();
        // the swift version has 31 entries but we have 35.  Its because we have different child shapes found
        var leafShapesAddedToBecomeSiblings = ShapeList.GetLastMergeHistoryShapeId(treeNode.ChildShapes);
        var wordDifferenceBetweenParentAndSibling = ShapeList.GetWordDifferences(treeNode.ChildShapes, treeNode.ParentShape);

        var processedQueue = new HashSet<string>();

        for (var siblingId = 0; siblingId < leafShapesAddedToBecomeSiblings.Count; siblingId++)
        {
            var resultForShape = new List<ShapeModel>();

            var sourceShapeId = leafShapesAddedToBecomeSiblings[siblingId];
            var sourceShape = treeNode.ChildShapes[siblingId];
            var siblingWords = wordDifferenceBetweenParentAndSibling[siblingId];

            for (var matchingSiblingId = 0; matchingSiblingId < leafShapesAddedToBecomeSiblings.Count; matchingSiblingId++)
            {
                var searchShapeId = leafShapesAddedToBecomeSiblings[matchingSiblingId];
                var wordsInMatchingSibling = wordDifferenceBetweenParentAndSibling[matchingSiblingId];

                var searchForDuplicates = $"{searchShapeId},{sourceShapeId}";

                var subsetA = siblingWords.IsSubsetOf(wordsInMatchingSibling);
                var subsetB = wordsInMatchingSibling.IsSubsetOf(siblingWords);

                if (matchingSiblingId != siblingId &&
                    subsetA == false && subsetB == false &&
                    !processedQueue.Contains(searchForDuplicates))
                {
                    processedQueue.Add($"{sourceShapeId},{searchShapeId}");

                    var mergedShape = MergeCalculatorV2.MergeTwoShapes(
                        sourceShape, searchShapes[searchShapeId], words, widthMax, heightMax, scoresMin);

                    if (mergedShape is not null)
                    {
                        resultForShape.Add((ShapeModel)mergedShape);
                    }
                }
            }

            // swift gave us 8 shapes but c# got no shapes at all for game 8808 (the second game we are processing)
            var siblingWordsAsListInt = new List<int>(siblingWords);


            var siblingCount = resultForShape.Count;

            var extraShapes = GetLeafShapesForLastWordsAddedToCurrentShape(
                wordIndex,
                siblingWordsAsListInt,
                leafShapesAddedToBecomeSiblings,
                sourceShape,
                sourceShapeId,
                searchShapes,
                words,
                scoresMin,
                widthMax,
                heightMax);

            resultForShape.AddRange(extraShapes);

            if (resultForShape.Count > 0)
            {
                resultForShape.Sort((a, b) =>
                {

                    return b.Score.CompareTo(a.Score);
                });

                result.Add(new TreeNodeModel(
                    parentShape: sourceShape,
                    childShapes: resultForShape,
                    bestDescendant: resultForShape[0],
                    siblingCount: siblingCount,
                    shapesCreated: 0)
                );
            }
        }
        result = TreeNodeList.SortByBestDescendant(result);

        return result;
    }


    public static List<ShapeModel> GetLeafShapesForLastWordsAddedToCurrentShape(

        in WordIndexModelV2 wordIndex,
        in List<int> siblingWords,
        in List<int> shapesToExclude,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        in List<int> scoresMin,
        int widthMax,
        int heightMax)
    {
        var instructions = wordIndex.FindMatches(siblingWords, shapesToExclude, sourceShape, sourceShapeId, searchShapes);

        var leafShapes = MergeCalculatorV2.GetShapesFromInstructions(
            instructions, sourceShape, searchShapes, words, scoresMin, widthMax, heightMax);

        return leafShapes;
    }



    public static Tuple<List<TreeNodeModel>, int> ExecuteLookaheadAndBeam(
        int lookaheadDepth,
        int beamWidth,
        in List<TreeNodeModel> treeNodes,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        int widthMax,
        int heightMax,
        in WordIndexModelV2 wordIndex,
        in List<int> scoresMin)
    {
        var shapesCreatedCount = 0;

        for (var treeNodeId = 0; treeNodeId < treeNodes.Count; treeNodeId++)
        {
            var treeNode = treeNodes[treeNodeId];

            var (bestShape, shapesCreated) = GetNodesAccordingToLookaheadDepth(
                lookaheadDepth, treeNode, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);


            treeNodes[treeNodeId].SetBestDescendant((ShapeModel)bestShape);


            shapesCreatedCount += shapesCreated;
        }

        List<TreeNodeModel> treeNodesSorted = TreeNodeList.SortByBestDescendant(treeNodes);


        var result = TreeNodeList.ApplyBeamWidth(treeNodesSorted, beamWidth);

        return new Tuple<List<TreeNodeModel>, int>(result, shapesCreatedCount);
    }


    public static Tuple<ShapeModel, int> GetNodesAccordingToLookaheadDepth(
        int lookaheadDepth,
        in TreeNodeModel treeNode,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        int widthMax,
        int heightMax,
        in WordIndexModelV2 wordIndex,
        in List<int> scoresMin)
    {
        var treeNodes = new List<TreeNodeModel> { treeNode };
        var bestShape = treeNode.ParentShape;
        var shapesCreated = 0;

        for (var i = 1; i < lookaheadDepth; i++)
        {
            treeNodes = ExecuteLevelInParallel(
                treeNodes,
                searchShapes,
                words,
                widthMax,
                heightMax,
                wordIndex,
                scoresMin);


            var currentBestShapeNullable = TreeNodeList.GetBestShape(treeNodes);
            if (currentBestShapeNullable is not null)
            {
                var currentBestShape = (ShapeModel)currentBestShapeNullable;
                if (currentBestShape.Score > bestShape.Score)

                    bestShape = currentBestShape;
            }
        }

        // How big is this max scoring shape?  Do it later
        return new Tuple<ShapeModel, int>(bestShape, shapesCreated);
    }


    public static List<TreeNodeModel> ExecuteLevelInParallel(
        in List<TreeNodeModel> treeNodes,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        int widthMax,
        int heightMax,
        in WordIndexModelV2 wordIndex,
        in List<int> scoresMin)
    {


        var a0 = ExecuteAsync(0, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a1 = ExecuteAsync(1, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a2 = ExecuteAsync(2, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a3 = ExecuteAsync(3, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a4 = ExecuteAsync(4, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a5 = ExecuteAsync(5, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a6 = ExecuteAsync(6, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a7 = ExecuteAsync(7, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a8 = ExecuteAsync(8, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);
        var a9 = ExecuteAsync(9, treeNodes, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);

        var collection = new List<List<TreeNodeModel>> { a0, a1, a2, a3, a4, a5, a6, a7, a8, a9 };

        var result = collection.SelectMany(e => e).ToList();

        return result;
    }


    public static List<TreeNodeModel> ExecuteAsync(
        int zeroToNine,
        in List<TreeNodeModel> treeNodes,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        int widthMax,
        int heightMax,
        in WordIndexModelV2 wordIndex,
        in List<int> scoresMin)
    {
        var result = new List<TreeNodeModel>();

        for (var treeNodeId = zeroToNine; treeNodeId < treeNodes.Count; treeNodeId += 10)
        {
            var treeNodesResult = ExecuteTreeNode(
                treeNodes[treeNodeId],
                searchShapes,
                words,
                widthMax,
                heightMax,
                wordIndex,
                scoresMin);

            result.AddRange(treeNodesResult);
        }

        return result;
    }

    

    

    

    //// We are adapting this one to improve it
    //public static bool ExecuteGameImproved(
    //    int gameId,
    //    List<string> words,
    //    int lookaheadDepth,
    //    int beamWidth,
    //    int maxDepth,
    //    int rootWidth,
    //    bool useGuidedScores)
    //{
    //    DateTime startTime = DateTime.Now;


    //    GameModel game = GameList.FindGame(gameId);

    //    int winningScore = game.WinningScore;

    //    ShapeModel bestShape = Execute(
    //        gameId,
    //        words,
    //        lookaheadDepth,
    //        beamWidth,
    //        maxDepth,
    //        rootWidth,
    //        winningScore,
    //        useGuidedScores);

    //    if (bestShape.Score >= game.WinningScore)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}


}