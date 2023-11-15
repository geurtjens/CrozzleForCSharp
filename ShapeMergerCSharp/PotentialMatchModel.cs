using System;
namespace ShapeMergerCSharp
{
	public readonly record struct PotentialMatchModel
	{
		public readonly int sourceShapeId;
		public readonly int searchShapeId;
		public readonly int matchingWordCount;

        public PotentialMatchModel(int sourceShapeId, int searchShapeId, int matchingWordCount)
		{
			this.sourceShapeId = sourceShapeId;
			this.searchShapeId = searchShapeId;
			this.matchingWordCount = matchingWordCount;
		}
    }
}