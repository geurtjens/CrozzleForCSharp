using System;
using CrozzleInterfaces;

namespace ShapeMakerCSharp
{
	public interface IShapeModel
	{
		public ShapeModel ToShape();
		public List<PlacementModel> ToPlacements();
	}
}

