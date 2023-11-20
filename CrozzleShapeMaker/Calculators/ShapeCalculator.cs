using CrozzleInterfaces;

namespace CrozzleShapeMaker;

public class ShapeCalculator
{
    public static List<ShapeModel> CombineShapes(in List<List<ShapeModel>> listOfShapeLists)
    {
        var result = new List<ShapeModel>();
        foreach (var item in listOfShapeLists)
        {
            result.AddRange(item);
        }
        return result;
    }
}