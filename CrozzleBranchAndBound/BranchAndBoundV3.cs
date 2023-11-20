using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleShapeMerger;

namespace CrozzleBranchAndBound;

public class BranchAndBoundV3
{

    public static Tuple<int, List<ShapeModel>, WordIndexModelV2, List<TreeNodeModel>, List<int>, int, int>
        GetStartingData(int gameId, List<string> words, int rootWidth, bool useGuidedScores)
    {
        GameModel game = GameList.FindGame(gameId);
        int widthMax = game.widthMax;
        int heightMax = game.heightMax;
        int winningScore = game.winningScore;

        StartingDataModel startingDataModel = StartingDataCalculator.Execute(gameId, words, rootWidth, useGuidedScores);

        WordIndexModelV2 searchWordIndex = new WordIndexModelV2(shapes: startingDataModel.searchShapes, wordCount: startingDataModel.words.Count);

        List<TreeNodeModel> startingTreeNodes = StartingTreeNodeCalculator.Execute(
            startingDataModel.startingShapes,
            startingDataModel.searchShapes,
            startingDataModel.words,
            startingDataModel.scoresMin,
            startingDataModel.maxWidth,
            startingDataModel.maxHeight,
            searchWordIndex);






        WordIndexModelV2 wordIndex = new WordIndexModelV2(startingDataModel.searchShapes, words.Count);





        return new Tuple<int, List<ShapeModel>, WordIndexModelV2, List<TreeNodeModel>, List<int>, int, int>(
            winningScore, startingDataModel.searchShapes, wordIndex, startingTreeNodes, startingDataModel.scoresMin, widthMax, heightMax);
    }




    public static List<int> ExecuteGamesAllWords(
        in List<int> gameIds,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        bool useGuidedScores)
    {
        DateTime startTime = DateTime.Now;



        List<int> successfulGames = new List<int>();
        Console.WriteLine($"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"rootWidth\": {rootWidth}, \"maxDepth\": {maxDepth}, \"games\": {gameIds.Count}");
        Console.WriteLine(string.Join(", ", gameIds));
        foreach (int gameId in gameIds)
        {
            GameModel game = GameList.FindGame(gameId);

            ShapeModel bestShape = ExecuteGame(
                game.gameId,
                game.words,
                lookaheadDepth,
                beamWidth,
                maxDepth,
                rootWidth,
                game.winningScore,
                useGuidedScores);

            if (bestShape.score >= game.winningScore)
            {
                successfulGames.Add(game.gameId);
            }

        }

        Console.WriteLine($"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"successes\": {successfulGames.Count}, \"time\": \"{DateTimeCalculator.Duration(startTime)}\"");
        if (successfulGames.Count == gameIds.Count)
        {
            Console.WriteLine("ALL GAMES SUCCEEDED");
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }
        else
        {
            var missingStuff = new HashSet<int>(gameIds).Except(new HashSet<int>(successfulGames)).OrderBy(x => x).ToList();
            List<int> missing = (List<int>)missingStuff;
            Console.WriteLine("MISSING " + string.Join(", ", missing));
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }

        return successfulGames;
    }

    public static List<int> ExecuteGamesWinningWords(
        List<int> gameIds,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        bool useGuidedScores)
    {
        DateTime startTime = DateTime.Now;

        List<int> successfulGames = new List<int>();

        Console.WriteLine($"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"rootWidth\": {rootWidth}, \"maxDepth\": {maxDepth}, \"games\": {gameIds.Count}");
        Console.WriteLine(string.Join(", ", gameIds));

        foreach (int gameId in gameIds)
        {
            GameModel game = GameList.FindGame(gameId);
            ShapeModel bestShape = ExecuteGame(
                game.gameId, game.winningWords, lookaheadDepth, beamWidth,
                maxDepth, rootWidth, game.winningScore, useGuidedScores);

            if (bestShape.score >= game.winningScore)
            {
                successfulGames.Add(game.gameId);
            }

        }

        Console.WriteLine($"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"successes\": {successfulGames.Count}, \"time\": \"{DateTimeCalculator.Duration(startTime)}\"");
        if (successfulGames.Count == gameIds.Count)
        {
            Console.WriteLine("ALL GAMES SUCCEEDED");
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }
        else
        {
            var missing = gameIds.Except(successfulGames).OrderBy(x => x).ToList();
            Console.WriteLine("MISSING " + string.Join(", ", missing));
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }

        return successfulGames;
    }


    // We are adapting this one to improve it
    public static bool ExecuteGameImproved(
        int gameId,
        List<string> words,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        bool useGuidedScores)
    {
        DateTime startTime = DateTime.Now;


        GameModel game = GameList.FindGame(gameId);

        int winningScore = game.winningScore;

        ShapeModel bestShape = ExecuteGame(
            gameId,
            words,
            lookaheadDepth,
            beamWidth,
            maxDepth,
            rootWidth,
            winningScore,
            useGuidedScores);

        if (bestShape.score >= game.winningScore)
        {
            return true;
        }
        else
        {
            return false;
        }
    }










    public static ShapeModel ExecuteGame(
        int gameId,
        in List<string> words,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        int winningScore,
        bool useGuidedScores)
    {
        var (winningScoreValue, searchShapes, wordIndex, rootTreeNodes, scoresMin, widthMax, heightMax) =
            GetStartingData(gameId, words, rootWidth, useGuidedScores);

        Console.WriteLine($"{{\"game\": {gameId}, \"wordCount\": {words.Count}, \"searchShapes\": {searchShapes.Count}, " +
            $"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"rootWidth\": {rootWidth}, " +
            $"\"maxDepth\": {maxDepth}, \"cycles\": [");

        var bestShapes = ExecuteLeaf(gameId, words, lookaheadDepth, beamWidth, maxDepth, rootWidth,
            winningScore, useGuidedScores, searchShapes, wordIndex, widthMax, heightMax, scoresMin, rootTreeNodes);

        var bestShape = bestShapes[0];

        if (bestShapes[0].score == winningScoreValue)
        {
            return bestShapes[0];
        }

        for (var i = 0; i < bestShapes.Count; i++)
        {
            var shapes = SiblingMergeCalculator.GetAllMatchingShapes(
                wordIndex,
                bestShapes[i],
                0,
                searchShapes,
                words,
                scoresMin,
                widthMax,
                heightMax);

            foreach (var shape in shapes)
            {
                if (shape.score > bestShape.score)
                {
                    bestShape = shape;
                }
            }
        }

        if (bestShape.score >= winningScoreValue)
        {
            Console.WriteLine($"HUMAN SCORE {gameId} Calculated at end");
        }

        return bestShape;
    }

    public static List<ShapeModel> ExecuteLeaf(
        int gameId,
        in List<string> words,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        int winningScore,
        bool useGuidedScores,
        in List<ShapeModel> searchShapes,
        in WordIndexModelV2 wordIndex,
        int widthMax,
        int heightMax,
        in List<int> scoresMin,
        in List<TreeNodeModel> rootTreeNodes)
    {
        var startTime = DateTimeCalculator.Now();

        var bestShape = rootTreeNodes[0].parentShape;
        var bestScores = new List<ushort>();
        var shapesCreatedCount = 0;
        var shapesCreated = 0;

        var treeNodes = rootTreeNodes;
        var previousNodes = treeNodes;

        for (var cycleId = 0; cycleId < maxDepth; cycleId++)
        {
            shapesCreatedCount = 0;
            treeNodes = ExecuteAll(treeNodes, searchShapes, words, widthMax, heightMax,
                wordIndex, scoresMin);

            shapesCreatedCount = treeNodes.Count;
            foreach (var treeNode in treeNodes)
            {
                shapesCreatedCount += treeNode.childShapes.Count;
            }

            (treeNodes, shapesCreated) = ExecuteLookaheadAndBeamAsync(
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
                    childShapes.AddRange(treeNode.childShapes);
                }

                childShapes = ShapeList.RemoveDuplicates(childShapes).OrderByDescending(e => e.score).ToList();

                var bestShapes = new List<ShapeModel>();

                for (var childShapeId = 0; childShapeId < childShapes.Count && bestShapes.Count < beamWidth; childShapeId++)
                {
                    bestShapes.Add(childShapes[childShapeId]);
                    bestScores.Add(childShapes[childShapeId].score);
                }

                if (bestShape.score < bestShapes[0].score)
                {
                    bestShape = bestShapes[0];
                }

                Console.WriteLine($"score:{bestShape.score}");
                Console.WriteLine(bestShape.ToTextDebug(words));

                var siblingMerges = TreeNodeList.identifySiblingMerges(treeNodes, 1, 2);

                Console.WriteLine($"{{\"cycle\": {cycleId}, \"shapesCreated\": {shapesCreatedCount}, " +
                    $"\"bestScores\": {string.Join(",", bestScores)}, " +
                    $"\"merges\": JsonConvert.SerializeObject(siblingMerges)}}");

                if (bestShape.score >= winningScore)
                {
                    Console.WriteLine($"HUMAN SCORE {gameId}");
                    Console.WriteLine(DateTimeCalculator.Duration(start: startTime));
                    return bestShapes;
                }
                else
                {
                    Console.WriteLine($"FAILED {gameId}");
                    Console.WriteLine(DateTimeCalculator.Duration(start: startTime));
                    return bestShapes;
                }
            }

            Console.WriteLine($"score:{bestShape.score}");
            Console.WriteLine(bestShape.ToTextDebug(words));

            if (treeNodes.Count > 0)
            {
                var bestShapes = treeNodes.Select(treeNode => treeNode.parentShape).ToList();
                bestShapes = ShapeList.RemoveDuplicates(bestShapes);

                foreach (var shape in bestShapes)
                {
                    bestScores.Add(shape.score);
                }

                if (bestShape.score < bestShapes[0].score)
                {
                    bestShape = bestShapes[0];
                }

                var siblingMerges = new List<(int, int, List<int>)>();

                Console.WriteLine($"{{\"cycle\": {cycleId}, \"shapesCreated\": {shapesCreatedCount}, " +
                    $"\"bestScores\": {string.Join(",", bestScores)}, " +
                    $"\"merges\": JsonConvert.SerializeObject(siblingMerges),");
            }
        }

        return new List<ShapeModel>();
    }

    public static Tuple<List<TreeNodeModel>, int> ExecuteLookaheadAndBeamAsync(
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

            var (bestShape, shapesCreated) = GetMaxScoreOfTreeNodeAsync(
                lookaheadDepth, treeNode, searchShapes, words, widthMax, heightMax, wordIndex, scoresMin);


            treeNodes[treeNodeId].SetBestDescendant((ShapeModel)bestShape);


            shapesCreatedCount += shapesCreated;
        }

        List<TreeNodeModel> treeNodesSorted = TreeNodeList.sortByBestDescendant(treeNodes);


        var result = TreeNodeList.applyBeamWidth(treeNodesSorted, beamWidth);

        return new Tuple<List<TreeNodeModel>, int>(result, shapesCreatedCount);
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

        var leafShapesAddedToBecomeSiblings = ShapeList.getLastMergeHistoryShapeId(treeNode.childShapes);
        var wordDifferenceBetweenParentAndSibling = ShapeList.getWordDifferences(treeNode.childShapes, treeNode.parentShape);

        var processedQueue = new HashSet<string>();

        for (var siblingId = 0; siblingId < leafShapesAddedToBecomeSiblings.Count; siblingId++)
        {
            var resultForShape = new List<ShapeModel>();

            var sourceShapeId = leafShapesAddedToBecomeSiblings[siblingId];
            var sourceShape = treeNode.childShapes[siblingId];
            var siblingWords = wordDifferenceBetweenParentAndSibling[siblingId];

            for (var matchingSiblingId = 0; matchingSiblingId < leafShapesAddedToBecomeSiblings.Count; matchingSiblingId++)
            {
                var searchShapeId = leafShapesAddedToBecomeSiblings[matchingSiblingId];
                var wordsInMatchingSibling = wordDifferenceBetweenParentAndSibling[matchingSiblingId];

                var searchForDuplicates = $"{searchShapeId},{sourceShapeId}";

                var subsetA = siblingWords.IsSubsetOf(wordsInMatchingSibling);
                var subsetB = wordsInMatchingSibling.IsSubsetOf(siblingWords);

                if (matchingSiblingId != siblingId &&
                    subsetA && subsetB &&
                    !processedQueue.Contains(searchForDuplicates))
                {
                    processedQueue.Add($"{sourceShapeId},{searchShapeId}");

                    var mergedShape = MergeCalculatorV2.mergeTwoShapes(
                        sourceShape, searchShapes[searchShapeId], words, widthMax, heightMax, scoresMin);

                    if (mergedShape is not null)
                    {
                        resultForShape.Add((ShapeModel)mergedShape);
                    }
                }
            }

            var siblingWordsAsListInt = new List<int>(siblingWords);

            
            var siblingCount = resultForShape.Count;

            var extraShapes = GetLeafShapes(
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

                    return b.score.CompareTo(a.score);
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
        result = TreeNodeList.sortByBestDescendant(result);

        return result;
    }

    public static List<ShapeModel> GetLeafShapes(

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
        var instructions = wordIndex.findMatches(siblingWords, shapesToExclude, sourceShape, sourceShapeId, searchShapes);

        var leafShapes = MergeCalculatorV2.GetShapesFromInstructions(
            instructions, sourceShape, searchShapes, words, scoresMin, widthMax, heightMax);

        return leafShapes;
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

    public static List<TreeNodeModel> ExecuteLevelInParallelAsync(
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

    public static Tuple<ShapeModel, int> GetMaxScoreOfTreeNodeAsync(
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
        var bestShape = treeNode.parentShape;
        var shapesCreated = 0;

        for (var i = 1; i < lookaheadDepth; i++)
        {
            treeNodes = ExecuteLevelInParallelAsync(
                treeNodes,
                searchShapes,
                words,
                widthMax,
                heightMax,
                wordIndex,
                scoresMin);


            var currentBestShapeNullable = TreeNodeList.getBestShape(treeNodes);
            if (currentBestShapeNullable is not null)
            {
                var currentBestShape = (ShapeModel)currentBestShapeNullable;
                if (currentBestShape.score > bestShape.score)

                    bestShape = currentBestShape;
            }
        }

        // How big is this max scoring shape?  Do it later
        return new Tuple<ShapeModel, int>(bestShape, shapesCreated);
    }

    public static List<TreeNodeModel> ExecuteAll(
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
        result = TreeNodeList.sortByBestDescendant(result);


        return result;
    }
}