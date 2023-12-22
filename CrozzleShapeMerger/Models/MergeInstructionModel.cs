using System;
namespace CrozzleShapeMerger;

public class MergeInstructionModel
{
    /// position of the shape in the first shape list that is going to be used in the merge
    public readonly int SourceShapeId;
    /// position of the shape in the secend shape list that is going to be used in the merge
    public readonly int SearchShapeId;

    /// how many words are the same in both of these shapes
    public readonly int MatchingWordCount;

    /// position of first matching word in first shape
    public readonly int FirstSourcePos;

    /// position of first matching owrd in second shape
    public readonly int FirstSearchPos;

    /// does the second shape have to be flipped before they come together
    public readonly bool Flipped;


    public MergeInstructionModel(int sourceShapeId, int searchShapeId, int matchingWordCount, int firstSourcePos, int firstSearchPos, bool flipped)
    {
        SourceShapeId = sourceShapeId;
        SearchShapeId = searchShapeId;
        MatchingWordCount = matchingWordCount;
        FirstSourcePos = firstSourcePos;
        FirstSearchPos = firstSearchPos;
        Flipped = flipped;
    }
}