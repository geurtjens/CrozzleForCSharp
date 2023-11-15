using System;
namespace CrozzleInterfaces
{
	public class ShapeListList
	{
        public List<ShapeModel> CombineShapes(in List<List<ShapeModel>> shapesList)
        {
            var result = new List<ShapeModel>();
            foreach (var item in shapesList)
            {
                result.AddRange(item);
            }
            return result;
        }
    }
}

