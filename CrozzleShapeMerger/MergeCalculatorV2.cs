using System;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public class MergeCalculatorV2
{


    // Execute same shape requires that we avoid repeats and so we go through each one
    public static List<ShapeModel> ExecuteSameShapeAsync(
        in List<ShapeModel> shapes,
        in WordIndexModelV2 wordIndex,
        int sourceMax,
        int searchMax,
        in List<string> words,
        in List<int> scoresMin,
        int widthMax,
        int heightMax)
    {

        // Rather than having a loop and running one at a time we have thesethings that process all going up 10 at a time

        var a0 = ExecuteSameShapeOneAsync(
            zeroToNine: 0,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a1 = ExecuteSameShapeOneAsync(
            zeroToNine: 1,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a2 = ExecuteSameShapeOneAsync(
            zeroToNine: 2,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a3 = ExecuteSameShapeOneAsync(
            zeroToNine: 3,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a4 = ExecuteSameShapeOneAsync(
            zeroToNine: 4,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a5 = ExecuteSameShapeOneAsync(
            zeroToNine: 5,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a6 = ExecuteSameShapeOneAsync(
            zeroToNine: 6,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a7 = ExecuteSameShapeOneAsync(
            zeroToNine: 7,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a8 = ExecuteSameShapeOneAsync(
            zeroToNine: 8,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);


        var a9 = ExecuteSameShapeOneAsync(
            zeroToNine: 9,
            sourceShapes: shapes,
            wordIndex: wordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax, heightMax: heightMax);



        return new List<List<ShapeModel>> { a0, a1, a2, a3, a4, a5, a6, a7, a8, a9 }.SelectMany(e => e).ToList();
    }

    public static List<ShapeModel> ExecuteDifferentShapesAsync(
        in List<ShapeModel> sourceShapes,
        in List<ShapeModel> searchShapes,
        in WordIndexModelV2 searchWordIndex,
        int sourceMax,
        int searchMax,
        List<string> words,
        List<int> scoresMin,
        int widthMax,
        int heightMax)
    {

        // Rather than having a loop and running one at a time we have thesethings that process all going up 10 at a time

        var a0 = ExecuteDifferentShapesAsyncOne(
            zeroToNine: 0,
            sourceShapes: sourceShapes,
            searchShapes: searchShapes,
            wordIndex: searchWordIndex,
            sourceMax: sourceMax,
            searchMax: searchMax,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax,
            heightMax: heightMax);


        var a1 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 1,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a2 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 2,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a3 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 3,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a4 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 4,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a5 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 5,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a6 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 6,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a7 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 7,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a8 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 8,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


        var a9 = ExecuteDifferentShapesAsyncOne(
                zeroToNine: 9,
                sourceShapes: sourceShapes,
                searchShapes: searchShapes,
                wordIndex: searchWordIndex,
                sourceMax: sourceMax,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);

        return new List<List<ShapeModel>> { a0, a1, a2, a3, a4, a5, a6, a7, a8, a9 }.SelectMany(e => e).ToList();
    }


        


    public static List<ShapeModel> ExecuteSameShapeOneAsync(
    int zeroToNine,
    in List<ShapeModel> sourceShapes,
    in WordIndexModelV2 wordIndex,
    int sourceMax,
    int searchMax,
    List<string> words,
    List<int> scoresMin,
    int widthMax,
    int heightMax)

    {
        var result = new List<ShapeModel>();

        // The difference is that each cpu works on 0,10,20 .. or 1, 11, 21 and so we divide the task
        for (int sourceShapeId = zeroToNine; sourceShapeId < sourceMax; sourceShapeId = sourceShapeId + 10)
        {


            var shapes = ExecuteSameShapeOnce(
                sourceShapeId: sourceShapeId,
                sourceShape: sourceShapes[sourceShapeId],
                searchShapes: sourceShapes,
                wordIndex: wordIndex,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


            result.AddRange(shapes);
        }
        return result;
    }


    public static List<ShapeModel> ExecuteDifferentShapesAsyncOne(
            int zeroToNine,
            in List<ShapeModel> sourceShapes,
            in List<ShapeModel> searchShapes,
            in WordIndexModelV2 wordIndex,
            int sourceMax,
            int searchMax,
            List<string> words,
            List<int> scoresMin,
            int widthMax,
            int heightMax)
    {
        var result = new List<ShapeModel>();


        for (int sourceShapeId = zeroToNine; sourceShapeId < sourceMax; sourceShapeId = sourceShapeId + 10)
        {
            var shapes = ExecuteDifferentShapesOne(
        sourceShape: sourceShapes[sourceShapeId],
        sourceShapeId: sourceShapeId,
        searchShapes: searchShapes,
        searchWordIndex: wordIndex,
        searchMax: searchMax,
        words: words,
        scoresMin: scoresMin,
        widthMax: widthMax,
        heightMax: heightMax);


            result.AddRange(shapes);
        }
        return result;
    }


    // NonAsync version of merging shapes together.  So it runs on only one core.
    public static List<ShapeModel> ExecuteSameShapeSync(
        in List<ShapeModel> sourceShapes,
            in WordIndexModelV2 searchWordIndex,
            int searchMax,
            List<string> words,
            List<int> scoresMin,
            int widthMax,
            int heightMax)
    {
        var result = new List<ShapeModel>();


        for (int sourceShapeId = 0; sourceShapeId < sourceShapes.Count; sourceShapeId++)
        {

            var shapes = ExecuteSameShapeOnce(
                sourceShapeId: sourceShapeId,
                sourceShape: sourceShapes[sourceShapeId],
                searchShapes: sourceShapes,
                wordIndex: searchWordIndex,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);
            result.AddRange(shapes);
        }
        return result;
    }


    public static List<ShapeModel> ExecuteDifferentShapesSync(
in List<ShapeModel> sourceShapes,
    in List<ShapeModel> searchShapes,
    in WordIndexModelV2 searchWordIndex,
    int sourceMax,
    int searchMax,
    in List<string> words,
    in List<int> scoresMin,
    int widthMax,
    int heightMax)
    {
        var result = new List<ShapeModel>();

        for (int sourceShapeId = 0; sourceShapeId < sourceMax; sourceShapeId++)
        {
            var shapes = ExecuteDifferentShapesOne(
                sourceShape: sourceShapes[sourceShapeId],
                sourceShapeId: sourceShapeId,
                searchShapes: searchShapes,
                searchWordIndex: searchWordIndex,
                searchMax: searchMax,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);


            result.AddRange(shapes);
        }
        return result;
    }





    public static List<ShapeModel> ExecuteSameShapeOnce(
        int sourceShapeId,
        in ShapeModel sourceShape,
        in List<ShapeModel> searchShapes,
        in WordIndexModelV2 wordIndex,
        int searchMax,
        in List<string> words,
        in List<int> scoresMin,
        int widthMax,
        int heightMax)
    {

        //        var instructions = MatchingWordsCalculator.GetMergeInstructions(
        //            sourceShapes: sourceShapes,
        //            sourceShapeId: shapeId,
        //            sourceWordIndex: wordIndex,
        //            searchMax: searchMax)

        var instructions = wordIndex.findMatches(sourceShape: sourceShape,
                                                    sourceShapeId: sourceShapeId,
                                                    searchMin: sourceShapeId + 1,
                                                    searchMax: searchMax,
                                                    searchShapes: searchShapes);


        List<ShapeModel> shapes = GetShapesFromInstructions(
            instructions: instructions,
            sourceShape: sourceShape,
            searchShapes: searchShapes,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax,
            heightMax: heightMax);



        return shapes;
    }


    public static List<ShapeModel> ExecuteDifferentShapesOne(
        in ShapeModel sourceShape,
        int sourceShapeId,
        in List<ShapeModel> searchShapes,
        WordIndexModelV2 searchWordIndex,
        int searchMax,
        List<string> words,
        List<int> scoresMin,
        int widthMax,
        int heightMax)
    {

        //        var instructions = MatchingWordsCalculator.GetMergeInstructions(
        //            sourceShapes: sourceShapes,
        //            sourceShapeId: sourceShapeId,
        //            searchShapes: searchShapes,
        //            searchWordIndex: searchWordIndex,
        //            searchMax: searchMax)

        //        Console.WriteLine("searchWordIndex.count: {searchWordIndex.index.count)")
        //        var indexSize = 0
        //        for item in searchWordIndex.index {
        //            indexSize += item.count
        //        }
        //        Console.WriteLine("index size {indexSize)")
        var instructions = searchWordIndex.findMatches(sourceShape: sourceShape,
                                                        sourceShapeId: sourceShapeId,
                                                        searchMin: 0,
                                                        searchMax: searchMax,
                                                        searchShapes: searchShapes);



        List<ShapeModel> shapes = GetShapesFromInstructions(
            instructions: instructions,
            sourceShape: sourceShape,
            searchShapes: searchShapes,
            words: words,
            scoresMin: scoresMin,
            widthMax: widthMax,
            heightMax: heightMax);


        return shapes;
    }


    public static List<ShapeModel> GetShapesFromInstructions(
        in List<MergeInstructionModel> instructions,
        in ShapeModel sourceShape,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        in List<int> scoresMin,
        int widthMax,
        int heightMax)
    {
        List<ShapeModel> shapes = new List<ShapeModel>();


        foreach (var instruction in instructions)
        {

            var searchShape = searchShapes[instruction.searchShapeId];



            // We have matches of 2 but instruction says its a match of 1
            var (isValidSize, calcWidth, calcHeight, flipped) = MergeSizeValidation.execute(
                sourceShape: sourceShape,
                sourcePos: instruction.firstSourcePos,
                searchShape: searchShape,
                searchPos: instruction.firstSearchPos,
                widthMax: widthMax,
                heightMax: heightMax);

                

            if (isValidSize)
            {

                var potentialPlacements = MergePlacementsCalculator.Execute(
                    sourceShape.placements,
                    searchShape.placements);





                if (potentialPlacements.Count > 0)
                {

                    var potentialWidth = PlacementList.width(potentialPlacements);
                    var potentialHeight = PlacementList.height(potentialPlacements);

                    if ((calcWidth == potentialWidth && calcHeight == potentialHeight) || (calcWidth == potentialHeight && calcHeight == potentialWidth)) { }
                    else
                    {


                        Console.WriteLine("ERROR HERE");
                        Console.WriteLine(sourceShape.ToTextDebug(words: words));
                        Console.WriteLine(searchShape.ToTextDebug(words: words));


                        Console.WriteLine("// sourceShape\n");
                        if (instruction.flipped)
                        {
                            Console.WriteLine($"/*\n{sourceShape.Flip().ToTextDebug(words: words)}\n*/");
                        }
                        else
                        {
                            Console.WriteLine($"/*\n{sourceShape.ToTextDebug(words: words)}\n*/");
                        }
                        Console.WriteLine("// searchShape\n");
                        Console.WriteLine($"/*\n{searchShape.ToTextDebug(words: words)})\n*/");
                        Console.WriteLine("// result\n");
                        Console.WriteLine($"/*\n{new ShapeModel(0, (byte)PlacementList.width(potentialPlacements), (byte)PlacementList.height(potentialPlacements), potentialPlacements).ToTextDebug(words: words)}\n*/");
                        Console.WriteLine($"potentialWH::({potentialWidth},{potentialHeight}), calcWH:({calcWidth}, {calcHeight})");



                        Console.WriteLine("{instruction)");
                    }

                    if ((potentialWidth <= widthMax && potentialHeight <= heightMax) ||
                        (potentialWidth <= heightMax && potentialHeight <= widthMax))
                    {

                        var isValidShape = ShapeToTextConverterV2.ToValidShape(placements: potentialPlacements, width: (int)(potentialWidth), height: (int)(potentialHeight), words: words);


                        if (isValidShape is not null)
                        {
                            var validShape = (ShapeModel)isValidShape;

                            // I wonder if (the shape width and height are the same
                            if (potentialWidth == validShape.width && potentialHeight == validShape.height)
                            {
                                //Console.WriteLine("same")
                            }
                            else if (potentialWidth == validShape.height && potentialHeight == validShape.width)
                            {
                                //Console.WriteLine("opposite")
                            }
                            else
                            {
                                Console.WriteLine("different");
                            }


                            // is shape is not nil so it must be a valid shape
                            var wordCount = validShape.placements.Count;
                            var scoreMin = scoresMin[wordCount];
                            if (validShape.score >= scoreMin)
                            {

                                validShape.history = ShapeModel.createMergeHistory(sourceShapeHistory: sourceShape.history, searchShapeHistory: searchShape.history);
                                shapes.Add(validShape);
                            }
                        }
                    }
                    else
                    {
                        //Console.WriteLine("We thought it was a valid size but it wasnt")
                    }
                }
            }
        }
        return shapes;
    }


    public static ShapeModel? mergeTwoShapes(
        in ShapeModel sourceShape,
        in ShapeModel searchShape,
        in List<string> words,
        int widthMax,
        int heightMax,
        in List<int> scoresMin)
    {
        var matchesModel = WordIndexModelV2.GetMatches(sourceShape: sourceShape, searchShape: searchShape);

        var instruction1 = WordIndexModelV2.processMatches(matchCount: matchesModel.matchingWordCount, sourceShape: sourceShape, sourceShapeId: 0, searchShape: searchShape, searchShapeId: 0);
        if (instruction1 is null)
        {
            return null;
        }
        var instruction = (MergeInstructionModel)instruction1;

            
        var (isValidSize, calcWidth, calcHeight, flipped) = MergeSizeValidation.execute(
            sourceShape: sourceShape,
            sourcePos: instruction.firstSourcePos,
            searchShape: searchShape,
            searchPos: instruction.firstSearchPos,
            widthMax: widthMax,
            heightMax: heightMax);


        if (isValidSize)
        {

            var potentialPlacements = MergePlacementsCalculator.Execute(
                sourceShape.placements,
                searchShape.placements);


            if (potentialPlacements.Count > 0)
            {

                var potentialWidth = PlacementList.width(potentialPlacements);
                var potentialHeight = PlacementList.height(potentialPlacements);

                if ((calcWidth == potentialWidth && calcHeight == potentialHeight) || (calcWidth == potentialHeight && calcHeight == potentialWidth)) { }
                else
                {


                    Console.WriteLine("ERROR HERE");
                    Console.WriteLine(sourceShape.ToTextDebug(words: words));
                    Console.WriteLine(searchShape.ToTextDebug(words: words));


                    Console.WriteLine("// sourceShape\n");
                    if (instruction.flipped)
                    {
                        Console.WriteLine($"/*\n{sourceShape.Flip().ToTextDebug(words: words)}\n*/");
                    }
                    else
                    {
                        Console.WriteLine($"/*\n{sourceShape.ToTextDebug(words: words)}\n*/");
                    }
                    Console.WriteLine("// searchShape\n");
                    Console.WriteLine($"/*\n{searchShape.ToTextDebug(words: words)}\n*/");
                    Console.WriteLine("// result\n");
                    Console.WriteLine($"/*\n{new ShapeModel(0, (byte)PlacementList.width(potentialPlacements), (byte)PlacementList.height(potentialPlacements), potentialPlacements).ToTextDebug(words: words)}\n*/");
                    Console.WriteLine($"potentialWH::({potentialWidth},{potentialHeight}), calcWH:({calcWidth}, {calcHeight})");



                    Console.WriteLine($"{instruction}");
                }

                if ((potentialWidth <= widthMax && potentialHeight <= heightMax) ||
                    (potentialWidth <= heightMax && potentialHeight <= widthMax))
                {

                    var validShape = ShapeToTextConverterV2.ToValidShape(placements: potentialPlacements, width: (int)(potentialWidth), height: (int)(potentialHeight), words: words);

                    if (validShape is not null)
                    {

                        ShapeModel shape = (ShapeModel)validShape;

                        // I wonder if the shape width and height are the same
                        if (potentialWidth == shape.width && potentialHeight == shape.height)
                        {
                            //Console.WriteLine("same")
                        }
                        else if (potentialWidth == shape.height && potentialHeight == shape.width)
                        {
                            //Console.WriteLine("opposite")
                        }
                        else
                        {
                            Console.WriteLine("different");
                        }


                        // is shape is not nil so it must be a valid shape
                        var scoreMin = scoresMin[shape.placements.Count];
                        if (shape.score >= scoreMin)
                        {

                            shape.history = ShapeModel.createMergeHistory(sourceShapeHistory: sourceShape.history, searchShapeHistory: searchShape.history);
                            return shape;
                        }
                    }
                }
            }
            else
            {
                //Console.WriteLine("We thought it was a valid size but it wasnt")
            }
        }

        return null;
    }


}
