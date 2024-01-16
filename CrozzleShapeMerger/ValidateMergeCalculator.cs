using System;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public class ValidateMergeCalculator
{

    public static MergeInstructionModel? Execute(
        int matchCount,
        in ShapeModel sourceShape,
        int sourceShapeId,
        in ShapeModel searchShape,
        int searchShapeId)
    {

        // We only have 1 match
        if (matchCount == 1)
        {
            MergeInstructionModel? match = SingleWordMatch(
                sourceShape: sourceShape,
                sourceShapeId: sourceShapeId,
                searchShape: searchShape,
                searchShapeId: searchShapeId);

            return match;
        }
        else if (matchCount > 1)
        {
            // We have more than one match
            if (matchCount < sourceShape.Placements.Count)
            {
                var multiWordMatch2 = MultiWordMatch(
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


    public static MergeInstructionModel? SingleWordMatch(
        in ShapeModel sourceShape,
        int sourceShapeId,
        in ShapeModel searchShape,
        int searchShapeId)
    {
        for (int sourcePos = 0; sourcePos < sourceShape.Placements.Count; sourcePos++)
        {

            /// Tells us the location of the word matching with the current word or else -1
            var searchPos = MatchingPlacementPosition(
                searchShape: searchShape,
                wordId: (int)(sourceShape.Placements[sourcePos].W));

            if (searchPos != -1)
            {
                var flipped = sourceShape.Placements[sourcePos].Z != searchShape.Placements[searchPos].Z;

                return new MergeInstructionModel(
                    sourceShapeId: sourceShapeId,
                    searchShapeId: searchShapeId,
                    matchingWordCount: 1,
                    firstSourcePos: sourcePos,
                    firstSearchPos: searchPos,
                    flipped: flipped);
            }
        }
        return null;
    }


    public static MergeInstructionModel? MultiWordMatch(
        in ShapeModel sourceShape,
        int sourceShapeId,
        in ShapeModel searchShape,
        int searchShapeId,
        int matchingWordCount)
    {

        if (IsSubset(
            matchingWordCount: matchingWordCount,
            sourceShape: sourceShape,
            searchShape: searchShape))
        {
            return null;
        }

        var matchesModel = GetMatches(
            sourceShape: sourceShape,
            searchShape: searchShape);

        var firstIsFlipped = (sourceShape.Placements[matchesModel.FirstSourcePos].Z != searchShape.Placements[matchesModel.FirstSearchPos].Z);

        var sameDirectionIsOk = IsSameDirection(
            firstSourcePos: matchesModel.FirstSourcePos,
            matches: matchesModel.Matches,
            firstIsFlipped: firstIsFlipped,
            sourceShape: sourceShape,
            searchShape: searchShape);


        if (sameDirectionIsOk == false)
        {
            return null;
        }


        var isMatchingDistance = IsSameDistance(
            firstSourcePos: matchesModel.FirstSourcePos,
            firstSearchPos: matchesModel.FirstSearchPos,
            matches: matchesModel.Matches,
            isFlipped: firstIsFlipped,
            sourceShape: sourceShape,
            searchShape: searchShape);

        if (isMatchingDistance == false)
        {
            return null;
        }
        else
        {

            return new MergeInstructionModel(
                sourceShapeId: sourceShapeId,
                searchShapeId: searchShapeId,
                matchingWordCount: (matchingWordCount),
                firstSourcePos: matchesModel.FirstSourcePos,
                firstSearchPos: matchesModel.FirstSearchPos,
                flipped: firstIsFlipped);
        }
    }


    public static MatchesModel GetMatches(
        in ShapeModel sourceShape,
        in ShapeModel searchShape)
    {

        var firstSourcePos = -1;
        var firstSearchPos = -1;
        var matches = new List<int>();
        int matchingWordCount = 0;
        for (int sourcePos = 0; sourcePos < sourceShape.Placements.Count; sourcePos++)
        {

            /// Tells us the location of the word matching with the current word or else -1
            var searchPos = MatchingPlacementPosition(
                searchShape: searchShape,
                wordId: (int)(sourceShape.Placements[sourcePos].W));

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


    /// WHEN there a word in `searchShape` that is same as the word we are looking for then return its position
    /// OTHERWISE return -1
    public static int MatchingPlacementPosition(
        in ShapeModel searchShape,
        int wordId)
    {
        for (int placementId = 0; placementId < searchShape.Placements.Count; placementId++)
        {
            if (searchShape.Placements[placementId].W == wordId)
            {
                return placementId;
            }
        }
        return -1;
    }


    public static bool IsSubset(
        int matchingWordCount,
        ShapeModel sourceShape,
        ShapeModel searchShape)
    {
        // If we have the smaller and larger the wrong way around then call again but this time making smaller actually smaller

        if (matchingWordCount == sourceShape.Placements.Count || matchingWordCount == searchShape.Placements.Count)
        {
            // We have found some shape to be a subset of another shape
            return true;
        } else
        { 
            return false;
        }

    }


    


    // While we are here lets see if they are the same orientation
    public static bool IsSameDirection(
        int firstSourcePos,
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

                bool isFlipped = (sourceShape.Placements[sourcePos].Z != searchShape.Placements[searchPos].Z);
                if (firstIsFlipped != isFlipped)
                {
                    return false;
                }
            }
        }
        return true;
    }


    public static bool IsSameDistance(
        int firstSourcePos,
        int firstSearchPos,
        in List<int> matches,
        bool isFlipped,
        in ShapeModel sourceShape,
        in ShapeModel searchShape)
    {

        /// How could the first match be the same
        var sourceX = (int)(sourceShape.Placements[firstSourcePos].X);
        var sourceY = (int)(sourceShape.Placements[firstSourcePos].Y);

        var searchX = (int)(searchShape.Placements[firstSearchPos].X);
        var searchY = (int)(searchShape.Placements[firstSearchPos].Y);


        for (int sourcePos = (firstSourcePos + 1); sourcePos < matches.Count; sourcePos++)
        {
            //for i in (firstMatch+1)..<matchingWords.count {
            var searchPos = matches[sourcePos];


            if (searchPos != -1)
            {
                var sourceX_diff = sourceX - (int)(sourceShape.Placements[sourcePos].X);
                var sourceY_diff = sourceY - (int)(sourceShape.Placements[sourcePos].Y);

                var searchX_diff = searchX - (int)(searchShape.Placements[searchPos].X);
                var searchY_diff = searchY - (int)(searchShape.Placements[searchPos].Y);


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
}