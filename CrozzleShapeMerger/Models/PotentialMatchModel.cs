using System;
namespace CrozzleShapeMerger;

public readonly record struct PotentialMatchModel
{
	public readonly int SourceShapeId;
	public readonly int SearchShapeId;
	public readonly int MatchingWordCount;

    public PotentialMatchModel(int sourceShapeId, int searchShapeId, int matchingWordCount)
	{
		SourceShapeId = sourceShapeId;
		SearchShapeId = searchShapeId;
		MatchingWordCount = matchingWordCount;
	}
}