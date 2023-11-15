using System;
using CrozzleInterfaces;

namespace ShapeMakerCSharp
{
    public readonly record struct EdgeModel : IShapeModel
    {

        public readonly byte horizontalWordId;
        /// position of the interlocking letter for the horizontal word
        public readonly byte horizontalPosition;
        /// length of the horizontal word
        public readonly byte horizontalLength;

        /// second word involved in the edge.  It will have the higher wordId out of both words being interlocked, to avoid duplicates
        public readonly byte verticalWordId;
        /// position of the interlocking letter for the vertical word
        public readonly byte verticalPosition;
        /// length of the vertical word
        public readonly byte verticalLength;

        /// When shape is rendered into text, this will be the width of the text
        public readonly byte width;
        /// When shape is rendered into text, this will be the height of the text
        public readonly byte height;
        /// Score of the shape
        public readonly ushort score;

        public EdgeModel(
            byte horizontalWordId, byte horizontalPosition, byte horizontalLength,
            byte verticalWordId, byte verticalPosition, byte verticalLength,
            byte width, byte height, ushort score)
        {
            this.horizontalWordId = horizontalWordId;
            this.horizontalPosition = horizontalPosition;
            this.horizontalLength = horizontalLength;
            this.verticalWordId = verticalWordId;
            this.verticalPosition = verticalPosition;
            this.verticalLength = verticalLength;
            this.width = width;
            this.height = height;
            this.score = score;
        }


        public ShapeModel ToShape()
        {
            var placements = ToPlacements().OrderBy(o => o.w).ToList();

            var shape = new ShapeModel(score, width, height, placements);

            if (shape.placements[0].z == false)
            {
                return ShapeCalculator.Flip(shape);
            }
            else
            {
                return shape;
            }
        }


        public List<PlacementModel> ToPlacements()
        {

            var horizontal = new PlacementModel(
                    w: horizontalWordId,
                    x: 0,
                    y: (byte)(verticalPosition + 1),
                    z: true,
                    l: horizontalLength
                );
            var vertical = new PlacementModel(
                w: verticalWordId,
                x: (byte)(horizontalPosition + 1),
                y: 0,
                z: false,
                l: verticalLength
            );
            return new List<PlacementModel> { horizontal, vertical };
        }
    }
}
