using System;
using System.Text.RegularExpressions;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public readonly record struct WordToShapeIndex
{

    /// <summary>
    /// Another novel idea is that we can capture the words inside each of the shapes
    /// So we do not have to iterate through the placement lists
    /// </summary>
    public readonly List<List<int>> wordsForShapes;

    /// <summary>
    /// We might also like to do a score breakdown so we search only those that already have a specific contributing score
    /// </summary>

    





    public readonly List<List<int>> index;


    /// <summary>
    /// FUTURE OPTIMIZATION: Two shapes that should merge because of common words, cannot merge, or opposite, can merge.
    /// Another brainstorming idea is that if we know
    /// ForEach shape that should be able to connect because of common letters
    /// These are the shapes that either actual can merge or cannot merge.
    /// So we can then use this knowledge as an initial check.
    /// Because we know that the sum of the parts of the shapes, if non of them can merge already
    /// then they wont be able to merge as a whole.  The more shapes added the worse it gets
    /// So an optimization where we search through a list of numbers and find if its worth proceeding or not.
    /// The number of mergable shapes should be quite low I think so the limit already exists, so preprocess that limit.
    ///
    /// 
    /// </summary>



    public readonly int wordCount;
    public readonly int interlockability;
    public readonly int shapeCount;

    public List<int> findMatchUsingIndex(
        in ShapeModel sourceShape,
        int searchMin,
        int searchMax)
    {
        
        var matches = new List<int>();
        for (int wordPos=0; wordPos<sourceShape.placements.Count; wordPos++)
        {
            int w = sourceShape.placements[wordPos].w;

            matches.AddRange(index[w]);
        }

        // Remove items out of score
        matches = matches.Where(e => e >= searchMin && e <= searchMax).ToList();

        matches.Sort();


        return matches;
    }


    /// <summary>
    /// Use pre calculated index to identify all shapes that contain the same words
    /// </summary>
    /// <param name="sourceShape"></param>
    /// <returns></returns>
    public List<int> findMatches(in ShapeModel sourceShape)
    {
        var matches = new List<int>();

        for (int wordPos = 0; wordPos < sourceShape.placements.Count; wordPos++)
        {
            int w = sourceShape.placements[wordPos].w;

            matches.AddRange(index[w]);
        }
        matches = matches.Distinct().ToList();
        matches.Sort();

        return matches;
    }


    // <summary>
    /// Use pre calculated index to identify all shapes that contain the same words
    /// </summary>
    /// <param name="sourceShape"></param>
    /// <returns></returns>
    public List<int> FindMatchesForWordList(in List<int> sourceShapeWords)
    {
        var matches = new List<int>();

        for (int wordPos = 0; wordPos < sourceShapeWords.Count; wordPos++)
        {
            int w = sourceShapeWords[wordPos];

            matches.AddRange(index[w]);
        }

        matches.Sort();

        return matches;
    }


    public List<int> FindMatches(in ShapeModel sourceShape, int sourceShapePosition)
    {
        var shapesWithSameWords = new List<int>();

        for (int wordPos = 0; wordPos < sourceShape.placements.Count; wordPos++)
        {
            int w = sourceShape.placements[wordPos].w;

            shapesWithSameWords.AddRange(index[w]);
        }

        shapesWithSameWords = shapesWithSameWords.Distinct().ToList();
        shapesWithSameWords = shapesWithSameWords.Where(e => e != sourceShapePosition).ToList();

        shapesWithSameWords.Sort();

        return shapesWithSameWords;
    }


    /// <summary>
    /// When finding all shapes that match with all other shapes we want to compare the earlier ones only with the later ones.
    /// Otherwise we will find duplicates.
    /// So this is used when we have a bunch of shapes all compared with each other.
    /// </summary>
    /// <param name="sourceShape"></param>
    /// <param name="sourceShapePosition"></param>
    /// <returns></returns>
    public List<int> FindMatchesAbove(in ShapeModel sourceShape, int sourceShapePosition)
    {
        var shapesWithSameWords = new List<int>();

        for (int wordPos = 0; wordPos < sourceShape.placements.Count; wordPos++)
        {
            int w = sourceShape.placements[wordPos].w;

            shapesWithSameWords.AddRange(index[w]);
        }

        shapesWithSameWords = shapesWithSameWords.Distinct().ToList();
        shapesWithSameWords = shapesWithSameWords.Where(e => e > sourceShapePosition).ToList();

        shapesWithSameWords.Sort();

        return shapesWithSameWords;
    }

    /// <summary>
    /// Using an internal data structure of all word ids we stored within wordsForShapes
    /// When finding all shapes that match with all other shapes we want to compare the earlier ones only with the later ones.
    /// Otherwise we will find duplicates.
    /// So this is used when we have a bunch of shapes all compared with each other.
    /// </summary>
    /// <param name="sourceShapePosition"></param>
    /// <returns></returns>
    public List<int> FindMatchesAbove(int sourceShapePosition)
    {
        var shapesWithSameWords = new List<int>();

        for (int wordPos = 0; wordPos < this.wordsForShapes[sourceShapePosition].Count; wordPos++)
        {
            int w = this.wordsForShapes[sourceShapePosition][wordPos];

            shapesWithSameWords.AddRange(index[w]);
        }

        shapesWithSameWords = shapesWithSameWords.Distinct().ToList();
        shapesWithSameWords = shapesWithSameWords.Where(e => e > sourceShapePosition).ToList();

        shapesWithSameWords.Sort();

        return shapesWithSameWords;
    }


    /// <summary>
    /// When you want to find all matching shapes within a group of shapes.
    /// You can then schedule work for each of them to be resolved in parallel accross many cores, later.
    /// </summary>
    /// <param name="shapes"></param>
    /// <returns></returns>

    public List<MatchingShapesModel> FindMatchesAllShapes(in List<ShapeModel> shapes)
    {
        var result = new List<MatchingShapesModel>();

        for (int shapeId=0; shapeId< shapes.Count; shapeId++)
        {
            List<int> shapesWithSameWords = FindMatchesAbove(shapes[shapeId], shapeId);

            if (shapesWithSameWords.Count > 0)
            {
                result.Add(new MatchingShapesModel(shapeId, shapesWithSameWords));
            }
        }
        return result;
    }


    /// <summary>
    /// When you want to find all matching shapes within a group of shapes.
    /// You can then schedule work for each of them to be resolved in parallel accross many cores, later.
    /// </summary>
    /// <param name="shapes"></param>
    /// <returns></returns>

    public List<MatchingShapesModel> FindMatchesAllShapes()
    {
        var result = new List<MatchingShapesModel>();

        for (int shapeId = 0; shapeId < this.wordsForShapes.Count; shapeId++)
        {
            List<int> shapesWithSameWords = FindMatchesAbove(shapeId);

            if (shapesWithSameWords.Count > 0)
            {
                result.Add(new MatchingShapesModel(shapeId, shapesWithSameWords));
            }
        }
        return result;
    }



    public WordToShapeIndex(in List<ShapeModel> shapes, int wordCount)
    {

        var indexTemp = new List<List<int>>();
        for (int wordId = 0; wordId < wordCount; wordId++)
        {
            indexTemp.Add(new List<int>());
        }


        var wordsForShapesTemp = new List<List<int>>();
        for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
        {
            var wordIds = new List<int>();


            for (int placementId = 0; placementId < shapes[shapeId].placements.Count; placementId++)
            {
                int w = (int)(shapes[shapeId].placements[placementId].w);
                indexTemp[w].Add(shapeId);

                wordIds.Add(w);
            }
            wordsForShapesTemp.Add(wordIds);
        }


        int interlockabilityTemp = 0;
        for (int wordId = 0; wordId < wordCount; wordId++)
        {
            interlockabilityTemp += indexTemp[wordId].Count;
        }

        this.wordCount = wordCount;
        this.index = indexTemp;
        this.interlockability = interlockabilityTemp;
        this.shapeCount = shapes.Count;
        this.wordsForShapes = wordsForShapesTemp;
    }


    public string WordToShapeCountStatisticsCsv()
    {
        string result = "";
        for (int wordId = 0; wordId < this.index.Count; wordId++)
        {
            if (result != "")
            {
                result += ",";
            }
            result += this.index[wordId].Count;
        }
        return result;
    }


    public string StatisticsToJson()
    {
        string statisticsText = WordToShapeCountStatisticsCsv();
        var result = "{" + $"\"wordCount\": {this.wordCount}, \"shapeCount\": {this.shapeCount}, \"wordToShapeSum\": {this.interlockability}, \"wordToShapeCount\": \"{statisticsText}\"" + "}";

        return result;
    }
}

