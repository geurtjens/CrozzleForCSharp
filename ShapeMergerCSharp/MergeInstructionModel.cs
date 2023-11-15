using System;
namespace ShapeMergerCSharp
{
    public class MergeInstructionModel
    {
        /// position of the shape in the first shape list that is going to be used in the merge
        public readonly int sourceShapeId;
        /// position of the shape in the secend shape list that is going to be used in the merge
        public readonly int searchShapeId;

        /// how many words are the same in both of these shapes
        public readonly int matchingWordCount;

        /// position of first matching word in first shape
        public readonly int firstSourcePos;

        /// position of first matching owrd in second shape
        public readonly int firstSearchPos;

        /// does the second shape have to be flipped before they come together
        public readonly bool flipped;


        public MergeInstructionModel(int sourceShapeId, int searchShapeId, int matchingWordCount, int firstSourcePos, int firstSearchPos, bool flipped)
        {
            this.sourceShapeId = sourceShapeId;
            this.searchShapeId = searchShapeId;
            this.matchingWordCount = matchingWordCount;
            this.firstSourcePos = firstSourcePos;
            this.firstSearchPos = firstSearchPos;
            this.flipped = flipped;
        }
    }
}

