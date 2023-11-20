using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public class WordIndexModelV2
{

    public List<MergeInstructionModel> checkMatchesForLeafs(
        in List<int> matches,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in List<ShapeModel> searchShapes)
    {
        var result = new List<MergeInstructionModel>();

        foreach (var searchShapeId in matches)
        {

            var matchCount = findMatchCount(sourceShape: sourceShape, searchShape: searchShapes[searchShapeId]);


            if (matchCount != sourceShape.placements.Count && matchCount != searchShapes[searchShapeId].placements.Count)
            {

                var item = WordIndexModelV2.processMatches(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[searchShapeId], searchShapeId: searchShapeId);


                if (item is not null)
                {
                    result.Add(item!);
                }
            }
        }
        return result;
    }





    static bool isSameDistance(
            int firstSourcePos,
            int firstSearchPos,
            in List<int> matches,
            bool isFlipped,
            in ShapeModel sourceShape,
            in ShapeModel searchShape)
    {

        /// How could the first match be the same
        var sourceX = (int)(sourceShape.placements[firstSourcePos].x);
        var sourceY = (int)(sourceShape.placements[firstSourcePos].y);

        var searchX = (int)(searchShape.placements[firstSearchPos].x);
        var searchY = (int)(searchShape.placements[firstSearchPos].y);


        for (int sourcePos = (firstSourcePos + 1); sourcePos < matches.Count; sourcePos++)
        {
            //for i in (firstMatch+1)..<matchingWords.count {
            var searchPos = matches[sourcePos];


            if (searchPos != -1)
            {
                var sourceX_diff = sourceX - (int)(sourceShape.placements[sourcePos].x);
                var sourceY_diff = sourceY - (int)(sourceShape.placements[sourcePos].y);

                var searchX_diff = searchX - (int)(searchShape.placements[searchPos].x);
                var searchY_diff = searchY - (int)(searchShape.placements[searchPos].y);


                if (isFlipped)
                {
                    if (sourceX_diff != searchY_diff || sourceY_diff != searchX_diff)
                    {
                        return false;
                    }
                }
                else
                {
                    if (sourceX_diff != searchX_diff || sourceY_diff != searchY_diff)
                    {
                        return false;
                    }
                }
            }
        }
        // We have passed all the distance checks
        return true;
    }



    // While we are here lets see if they are the same orientation
    static bool isSameDirection(
        int firstSourcePos,
        int firstSearchPos,
        in List<int> matches,
        bool firstIsFlipped,
        in ShapeModel sourceShape,
        in ShapeModel searchShape)
    {

        for (int sourcePos = (firstSourcePos + 1); sourcePos < matches.Count; sourcePos++)
        {
            var searchPos = matches[sourcePos];
            if (searchPos != -1)
            {

                bool isFlipped = (sourceShape.placements[sourcePos].z != searchShape.placements[searchPos].z);
                if (firstIsFlipped != isFlipped)
                {
                    return false;
                }
            }
        }
        return true;
    }


    public readonly List<List<int>> index;

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
    public List<int> findMatchUsingIndex(
        in ShapeModel sourceShape,
        int searchMin,
        int searchMax)
    {

        var matches = new List<int>();
        for (int sourcePos = 0; sourcePos < sourceShape.placements.Count; sourcePos++)
        {
            int w = (int)sourceShape.placements[sourcePos].w;

            matches.AddRange(this.index[w]);
        }

        // Remove items out of score
        matches = matches.Where(e => e >= searchMin || e <= searchMax).ToList();

        matches.Sort();


        return matches;
    }

    public static MergeInstructionModel? processMatches(
        int matchCount,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in ShapeModel searchShape,
        int searchShapeId)
    {

        // We only have 1 match
        if (matchCount == 1)
        {
            var match = singleWordMatch(
                sourceShape: sourceShape,
                sourceShapeId: sourceShapeId,
                searchShape: searchShape,
                searchShapeId: searchShapeId);


            return match;


        }
        else if (matchCount > 1)
        {

            // We have more than one match
            if (matchCount < sourceShape.placements.Count)
            {

                var multiWordMatch2 = multiWordMatch(
                    sourceShape: sourceShape,
                    sourceShapeId: sourceShapeId,
                    searchShape: searchShape,
                    searchShapeId: searchShapeId,
                    matchingWordCount: matchCount);


                return multiWordMatch2;
            }
            else
            {
                return null;
            }
        }
        return null;


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
            for (int placementId = 0; placementId < shapes[shapeId].placements.Count; placementId++)
            {
                int w = (int)(shapes[shapeId].placements[placementId].w);
                indexTemp[w].Add(shapeId);
            }
        }
        this.index = indexTemp;
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
                var w = (int)(shapes[shapeId].placements[placementId].w);
                indexTemp[w].Add(shapeId);
            }
        }
        this.index = indexTemp;
    }


    public List<MergeInstructionModel> findMatches(
        in List<int> words,
        in ShapeModel sourceShape,
        int sourceShapeId,
        int searchMin,
        int searchMax,
        in List<ShapeModel> searchShapes)
    {

        // Find potential matches by using the index against all words in shape
        var matches = findMatchUsingIndex(sourceShape: sourceShape, searchMin: searchMin, searchMax: searchMax);



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
                var item1 = WordIndexModelV2.processMatches(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[previous], searchShapeId: previous);
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
        var item2 = WordIndexModelV2.processMatches(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[searchShapeId], searchShapeId: searchShapeId);
        if (item2 is not null)
        {
            result.Add(item2!);
        }

        return result;
    }


    public int findMatchCount(
        in ShapeModel sourceShape,
        in ShapeModel searchShape)
    {
        var matchCount = 0;
        foreach (var sourcePlacement in sourceShape.placements)
        {
            foreach (var searchPlacement in searchShape.placements)
            {
                if (sourcePlacement.w == searchPlacement.w)
                {
                    matchCount += 1;
                }
            }
        }
        return matchCount;
    }


    public List<MergeInstructionModel> checkMatches(
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
                var item1 = WordIndexModelV2.processMatches(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[previous], searchShapeId: previous);
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
        var item2 = WordIndexModelV2.processMatches(matchCount: matchCount, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShape: searchShapes[searchShapeId], searchShapeId: searchShapeId);
        if (item2 is not null)
        {
            result.Add(item2!);
        }

        return result;
    }



    public List<MergeInstructionModel> findMatches(
        in List<int> containingWords,
        in List<int> shapesToExclude,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in List<ShapeModel> searchShapes)
    {

        // Find potential matches by using the index against all words in shape
        var matches = findMatchUsingIndex(words: containingWords, shapesToExclude: shapesToExclude);

        if (matches.Count == 0)
        {
            return new List<MergeInstructionModel>();
        }

        return checkMatchesForLeafs(matches: matches, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShapes: searchShapes);
    }



    public List<MergeInstructionModel> findMatches(
        in ShapeModel sourceShape,
        int sourceShapeId,
        int searchMin,
        int searchMax,
        in List<ShapeModel> searchShapes)
    {
        // Find potential matches by using the index against all words in shape
        var matches = findMatchUsingIndex(sourceShape: sourceShape, searchMin: searchMin, searchMax: searchMax);

        if (matches.Count == 0)
        {
            return new List<MergeInstructionModel>();
        }

        return checkMatches(matches: matches, sourceShape: sourceShape, sourceShapeId: sourceShapeId, searchShapes: searchShapes);
    }

    /// Is there a placement in the searchShape that has the same word as what we are looking for
    /// if so then what is the word position within the shape
    private static int MatchingPlacementPosition(
        in ShapeModel searchShape,
        int wordId)
    {

        for (int placementId = 0; placementId < searchShape.placements.Count; placementId++)
        {
            if (searchShape.placements[placementId].w == wordId)
            {
                return placementId;
            }
        }
        return -1;
    }




    private static MergeInstructionModel? singleWordMatch(
        in ShapeModel sourceShape,
        int sourceShapeId,
        in ShapeModel searchShape,
        int searchShapeId)
    {

        for (int sourcePos = 0; sourcePos < sourceShape.placements.Count; sourcePos++)
        {

            /// Tells us the location of the word matching with the current word or else -1
            var searchPos = WordIndexModelV2.MatchingPlacementPosition(searchShape: searchShape,
                                                      wordId: (int)(sourceShape.placements[sourcePos].w));


            if (searchPos != -1)
            {
                var flipped = sourceShape.placements[sourcePos].z != searchShape.placements[searchPos].z;

                return new MergeInstructionModel(sourceShapeId: sourceShapeId,
                                             searchShapeId: searchShapeId,
                                             matchingWordCount: 1,
                                             firstSourcePos: sourcePos,
                                             firstSearchPos: searchPos,
                                             flipped: flipped);
            }
        }
        return null;
    }


    public static MatchesModel GetMatches(
        in ShapeModel sourceShape,
        in ShapeModel searchShape)
    {

        var firstSourcePos = -1;
        var firstSearchPos = -1;
        var matches = new List<int>();
        int matchingWordCount = 0;
        for (int sourcePos = 0; sourcePos < sourceShape.placements.Count; sourcePos++)
        {

            /// Tells us the location of the word matching with the current word or else -1
            var searchPos = MatchingPlacementPosition(searchShape: searchShape,
                                                      wordId: (int)(sourceShape.placements[sourcePos].w));
            matches.Add(searchPos);

            if (searchPos != -1)
            {
                if (firstSourcePos == -1)
                {
                    firstSourcePos = sourcePos;
                    firstSearchPos = searchPos;
                }
                matchingWordCount += 1;
            }
        }
        return new MatchesModel(matches, firstSourcePos, firstSearchPos, matchingWordCount);
    }


    static MergeInstructionModel? multiWordMatch(
        in ShapeModel sourceShape,
        int sourceShapeId,
        in ShapeModel searchShape,
        int searchShapeId,
        int matchingWordCount)
    {

        // If we have the smaller and larger the wrong way around then call again but this time making smaller actually smaller

        if (matchingWordCount == sourceShape.placements.Count || matchingWordCount == searchShape.placements.Count)
        {
            // We have found some shape to be a subset of another shape
            return null;
        }



        var matchesModel = WordIndexModelV2.GetMatches(sourceShape: sourceShape, searchShape: searchShape);


        var firstIsFlipped = (sourceShape.placements[matchesModel.firstSourcePos].z != searchShape.placements[matchesModel.firstSearchPos].z);


        var sameDirectionIsOk = isSameDirection(
            firstSourcePos: matchesModel.firstSourcePos,
            firstSearchPos: matchesModel.firstSearchPos,
            matches: matchesModel.matches,
            firstIsFlipped: firstIsFlipped,
            sourceShape: sourceShape,
            searchShape: searchShape);


        if (sameDirectionIsOk == false)
        {
            return null;
        }


        var isMatchingDistance = isSameDistance(firstSourcePos: matchesModel.firstSourcePos,
                                                  firstSearchPos: matchesModel.firstSearchPos,
                                                  matches: matchesModel.matches,
                                                  isFlipped: firstIsFlipped,
                                                  sourceShape: sourceShape,
                                                  searchShape: searchShape);



        if (isMatchingDistance == false)
        {
            return null;
        }
        else
        {

            return new MergeInstructionModel(sourceShapeId: sourceShapeId,
                                         searchShapeId: searchShapeId,
                                         matchingWordCount: (matchingWordCount),
                                         firstSourcePos: matchesModel.firstSourcePos,
                                         firstSearchPos: matchesModel.firstSearchPos,
                                         flipped: firstIsFlipped);
        }
    }




    List<int> findMatchUsingIndex(
        in List<int> words,
        in List<int> shapesToExclude)
    {

        var matches = new List<int>();
        foreach (var w in words)
        {
            matches.AddRange(this.index[w]);
        }

        // This will remove those that we do not want
        matches = matches.Except(shapesToExclude).ToList();

        matches.Sort();
        return matches;
    }


    // Finds all matches in the source shape and search shape and includes word count.  Maybe we dont need the word count?
    List<PotentialMatchModel> findMatches(
        in List<ShapeModel> sourceShapes,
        int sourceShapeId,
        int searchMin,
        int searchMax,
        in List<ShapeModel> searchShapes)
    {

        var result = new List<PotentialMatchModel>();


        for (int shapeId = 0; shapeId < sourceShapes.Count; shapeId++)
        {
            // Find potential matches by using the index against all words in shape
            var matches = findMatchUsingIndex(sourceShape: sourceShapes[shapeId], searchMin: searchMin, searchMax: searchMax);


            int searchShapeId = matches[0];
            int previous = matches[0];
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
                    result.Add(new PotentialMatchModel(sourceShapeId: sourceShapeId, searchShapeId: searchShapeId, matchingWordCount: matchCount));
                }
            }
        }
        return result;
    }
}
