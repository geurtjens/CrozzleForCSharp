namespace CrozzleShapeMerger;

public readonly record struct MatchingShapesModel
{
	public readonly int ShapeId;
	public readonly List<int> MatchingShapeIds;
	public MatchingShapesModel(int shapeId, in List<int> matchingShapeIds)
	{
		ShapeId = shapeId;
		MatchingShapeIds = matchingShapeIds;
	}
}