using System;
namespace CrozzleInterfaces
{
    public record struct TreeNodeModel
    {
        public readonly ShapeModel parentShape;

        public readonly List<ShapeModel> childShapes;

        public ShapeModel bestDescendant;
        //public var scoreMax: Int

        /// How many siblings where used to calculate the children
        public readonly int siblingCount;

        public readonly int shapesCreated;

        public bool isValid;

        public TreeNodeModel(in ShapeModel parentShape, in List<ShapeModel> childShapes, in ShapeModel bestDescendant, int siblingCount, int shapesCreated)
        {
            this.parentShape = parentShape;
            this.childShapes = childShapes;
            this.bestDescendant = bestDescendant;
            this.siblingCount = siblingCount;
            this.shapesCreated = shapesCreated;
            this.isValid = true;
        }

        public void SetToInvalid()
        {
            this.isValid = false;
        }
        public void SetBestDescendant(ShapeModel bestShape)
        {
            this.bestDescendant = bestShape;
        }
    }
}

