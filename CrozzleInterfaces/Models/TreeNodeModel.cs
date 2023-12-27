using System;
namespace CrozzleInterfaces;

public class TreeNodeModel
{
    public readonly ShapeModel ParentShape;

    public readonly List<ShapeModel> ChildShapes;

    public ShapeModel BestDescendant;
    //public var scoreMax: Int

    /// How many siblings where used to calculate the children
    public readonly int SiblingCount;

    public readonly int ShapesCreated;

    public bool IsValid;

    public TreeNodeModel(in ShapeModel parentShape, in List<ShapeModel> childShapes, in ShapeModel bestDescendant, int siblingCount, int shapesCreated)
    {
        ParentShape = parentShape;
        ChildShapes = childShapes;
        BestDescendant = bestDescendant;
        SiblingCount = siblingCount;
        ShapesCreated = shapesCreated;
        IsValid = true;
    }

    
    
}

