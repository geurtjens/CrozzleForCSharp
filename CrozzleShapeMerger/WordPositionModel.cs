using System;
namespace CrozzleShapeMerger;

public readonly struct WordPositionModel
{
	public readonly int ShapeId;
	public readonly int Position;

	public WordPositionModel(int shapeId, int position)
	{
		ShapeId = shapeId;
		Position = position;
	}
}

