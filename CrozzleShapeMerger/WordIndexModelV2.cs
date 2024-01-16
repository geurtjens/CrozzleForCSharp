using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public class WordIndexModelV2
{
    public readonly List<List<int>> Index;


    public List<MergeInstructionModel> CheckMatchesForLeafs(
        in List<int> matches,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in List<ShapeModel> searchShapes)
    {
        var result = new List<MergeInstructionModel>();

        foreach (var searchShapeId in matches)
        {

            var matchCount = FindMatchCount(
                sourceShape: sourceShape,
                searchShape: searchShapes[searchShapeId]);


            if (matchCount != sourceShape.Placements.Count && matchCount != searchShapes[searchShapeId].Placements.Count)
            {

                var item = ValidateMergeCalculator.Execute(
                    matchCount: matchCount,
                    sourceShape: sourceShape,
                    sourceShapeId: sourceShapeId,
                    searchShape: searchShapes[searchShapeId],
                    searchShapeId: searchShapeId);

                if (item is not null)
                {
                    result.Add(item!);
                }
            }
        }
        return result;
    }












    

    /// `WordIndexModelV2` is used to `findMatches`between a `sourceShape` and a collection of `searchShapes` to returns  `[MergeInstructionModel]`.
    ///  These instructions contain a potential merge between the `sourceShape` and `searchShape`.
    ///
    /// If there is only 1 common word between them then we find the `firstSourcePos` and `firstSearchPos`.
    ///
    /// If there are more than 1 common word then we first check that the number of common words is not the same as the number of words in the `sourceShape` otherwise it would be a subset of the `searchShape` and so impossible to merge.
    /// We check that each matching word `isSameDistance` from `firstSourcePos` in `sourceShape` as it is from `firstSearchPos` in `searchShape`.
    /// We check that each matching word `isSameDirection` as direction between `firstSourcePos` and `firstSearchPos`.  So if these two are opposite direction then all other common words should be opposite direction.  And if they are same direction then the other common words should be same direction.
    ///
    /// This struct stores an `index` of words used in  `[ShapeModel]`collection.
    /// When we want to find shapes we can merge with a `sourceShape` we can `findMatches` by getting them out of the `index`
    /// `findMatches` finds all matching words for all of the words found in the `sourceShape`.  So we can then go through this list and calculate how many words are common and act accordingly.
    ///
    /// Uses its `index` to `processMatches` to find both `singleWordMatch` and `multiWordMatch`



    /// Use this when you do not know the size of the shapes, so we can have multiple sized shapes for example
    /// For bulk loads this can take an extra 7 seconds so if all shapes are same size then use the other init

    /// We go through each word and build up a list of shapes that contain the same words as the shape we are looking through
    public List<int> FindMatchUsingIndex(
        in ShapeModel sourceShape,
        int searchMin,
        int searchMax)
    {

        var matches = new List<int>();
        for (int sourcePos = 0; sourcePos < sourceShape.Placements.Count; sourcePos++)
        {
            int w = (int)sourceShape.Placements[sourcePos].W;

            matches.AddRange(this.Index[w]);
        }

        // Remove items out of score
        matches = matches.Where(e => e >= searchMin || e <= searchMax).ToList();

        matches.Sort();


        return matches;
    }

    


    public WordIndexModelV2(in List<ShapeModel> shapes, int wordCount)
    {
        var indexTemp = new List<List<int>>();
        for (int i = 0; i < wordCount; i++)
        {
            indexTemp.Add(new List<int>());
        }

        for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
        {
            for (int placementId = 0; placementId < shapes[shapeId].Placements.Count; placementId++)
            {
                int w = (int)(shapes[shapeId].Placements[placementId].W);
                indexTemp[w].Add(shapeId);
            }
        }
        this.Index = indexTemp;
    }

    /// Use this when you know the size of the shape
    public WordIndexModelV2(
        in List<ShapeModel> shapes,
        int wordsPerShape,
        int wordCount)
    {

        var indexTemp = new List<List<int>>();
        for (int i = 0; i < wordCount; i++)
        {
            indexTemp.Add(new List<int>());
        }



        for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
        {
            for (int placementId = 0; placementId < wordsPerShape; placementId++)
            {
                var w = (int)(shapes[shapeId].Placements[placementId].W);
                indexTemp[w].Add(shapeId);
            }
        }
        this.Index = indexTemp;
    }


    public List<MergeInstructionModel> FindMatches(
        in List<int> words,
        in ShapeModel sourceShape,
        int sourceShapeId,
        int searchMin,
        int searchMax,
        in List<ShapeModel> searchShapes)
    {

        // Find potential matches by using the index against all words in shape
        var matches = FindMatchUsingIndex(sourceShape: sourceShape, searchMin: searchMin, searchMax: searchMax);



        var result = new List<MergeInstructionModel>();

        if (matches.Count == 0)
        {
            return result;
        }

        var searchShapeId = matches[0];
        var previous = matches[0];
        var matchCount = 1;

        for (int i = 1; i < matches.Count; i++)
        {
            searchShapeId = matches[i];
            if (previous == searchShapeId)
            {
                matchCount += 1;
            }
            else
            {
                var item1 = ValidateMergeCalculator.Execute(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[previous], searchShapeId: previous);
                if (item1 is not null)
                {
                    result.Add(item1!);
                }

                previous = searchShapeId;
                matchCount = 1;
            }
        }

        if (searchShapeId != previous)
        {
            Console.WriteLine("What should we do here then with previous and searchShapeId being different");
        }
        // Process last one, should this be previous or should it be searchShapeId?
        var item2 = ValidateMergeCalculator.Execute(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[searchShapeId], searchShapeId: searchShapeId);
        if (item2 is not null)
        {
            result.Add(item2!);
        }

        return result;
    }


    public int FindMatchCount(
        in ShapeModel sourceShape,
        in ShapeModel searchShape)
    {
        var matchCount = 0;
        foreach (var sourcePlacement in sourceShape.Placements)
        {
            foreach (var searchPlacement in searchShape.Placements)
            {
                if (sourcePlacement.W == searchPlacement.W)
                {
                    matchCount += 1;
                }
            }
        }
        return matchCount;
    }


    public List<MergeInstructionModel> CheckMatches(
        in List<int> matches,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in List<ShapeModel> searchShapes)
    {
        var result = new List<MergeInstructionModel>();

        var searchShapeId = matches[0];
        var previous = matches[0];
        var matchCount = 1;
        for (int i = 1; i < matches.Count; i++)
        {
            searchShapeId = matches[i];


            if (previous == searchShapeId)
            {
                matchCount += 1;
            }
            else
            {
                var item1 = ValidateMergeCalculator.Execute(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[previous], searchShapeId: previous);
                if (item1 is not null)
                {
                    result.Add(item1!);
                }

                previous = searchShapeId;
                matchCount = 1;
            }
        }

        if (searchShapeId != previous)
        {
            Console.WriteLine("What should we do here then with previous and searchShapeId being different");
        }
        // Process last one, should this be previous or should it be searchShapeId?
        var item2 = ValidateMergeCalculator.Execute(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[searchShapeId], searchShapeId: searchShapeId);
        if (item2 is not null)
        {
            result.Add(item2!);
        }

        return result;
    }



    public List<MergeInstructionModel> FindMatches(
        in List<int> containingWords,
        in List<int> shapesToExclude,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in List<ShapeModel> searchShapes)
    {

        // Find potential matches by using the index against all words in shape
        var matches = FindMatchUsingIndex(words: containingWords, shapesToExclude: shapesToExclude);

        if (matches.Count == 0)
        {
            return new List<MergeInstructionModel>();
        }

        return CheckMatchesForLeafs(matches: matches, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShapes: searchShapes);
    }



    public List<MergeInstructionModel> FindMatches(
        in ShapeModel sourceShape,
        int sourceShapeId,
        int searchMin,
        int searchMax,
        in List<ShapeModel> searchShapes)
    {
        // Find potential matches by using the index against all words in shape
        var matches = FindMatchUsingIndex(sourceShape: sourceShape, searchMin: searchMin, searchMax: searchMax);

        if (matches.Count == 0)
        {
            return new List<MergeInstructionModel>();
        }

        return CheckMatches(matches: matches, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShapes: searchShapes);
    }


    List<int> FindMatchUsingIndex(
        in List<int> words,
        in List<int> shapesToExclude)
    {

        var matches = new List<int>();
        foreach (var w in words)
        {
            matches.AddRange(this.Index[w]);
        }

        // This will remove those that we do not want
        matches = matches.Except(shapesToExclude).ToList();

        matches.Sort();
        return matches;
    }


    //// Finds all matches in the source shape and search shape and includes word count.  Maybe we dont need the word count?
    //List<PotentialMatchModel> FindMatches(
    //    in List<ShapeModel> sourceShapes,
    //    int sourceShapeId,
    //    int searchMin,
    //    int searchMax,
    //    in List<ShapeModel> searchShapes)
    //{

    //    var result = new List<PotentialMatchModel>();


    //    for (int shapeId = 0; shapeId < sourceShapes.Count; shapeId++)
    //    {
    //        // Find potential matches by using the index against all words in shape
    //        var matches = FindMatchUsingIndex(sourceShape: sourceShapes[shapeId], searchMin: searchMin, searchMax: searchMax);


    //        int searchShapeId = matches[0];
    //        int previous = matches[0];
    //        var matchCount = 1;


    //        for (int i = 1; i < matches.Count; i++)
    //        {
    //            searchShapeId = matches[i];
    //            if (previous == searchShapeId)
    //            {
    //                matchCount += 1;
    //            }
    //            else
    //            {
    //                result.Add(new PotentialMatchModel(sourceShapeId: sourceShapeId, searchShapeId: searchShapeId, matchingWordCount: matchCount));
    //            }
    //        }
    //    }
    //    return result;
    //}
}
