using System;
namespace CrozzleInterfaces
{
	public class ShapeListList : List<ShapeList>
	{
        public ShapeList CombineShapes()
        {
            var result = new ShapeList();
            foreach (var item in this)
            {
                result.AddRange(item);
            }
            return result;
        }
    }
}

