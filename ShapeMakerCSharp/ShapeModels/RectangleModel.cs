using System;
using System.Drawing;
using CrozzleInterfaces;
using ShapeMakerCSharp;

namespace ShapeMakerCSharp
{
    public readonly record struct RectangleModel : IShapeModel
    {

        /// score awarded for this shape by the rules of crozzle
        public readonly ushort score;
        /// width of grid when shape rendered as a grid
        public readonly byte width;
        /// height of grid when shape rendered as a grid
        public readonly byte height;

        /// position of word in words list that is occupying `top` of rectangle
        public readonly byte top;
        /// letter position of first interlockin letter in `top` word
        public readonly byte topLetterPos;
        /// length of word that occupies`top` of rectangle
        public readonly byte topLength;

        /// position of word in words list that occupies `bottom` of rectangle
        public readonly byte bottom;
        /// letter position of first interlockin letter in `bottom` word
        public readonly byte bottomLetterPos;
        /// length of word that occupies `bottom` of rectangle
        public readonly byte bottomLength;

        /// position of word in words list that occupies `left` of rectangle
        public readonly byte left;
        /// letter position of first interlockin letter in `left` word
        public readonly byte leftLetterPos;
        /// length of word that occupies`left` of rectangle
        public readonly byte leftLength;

        /// position of word in words list that occupyies `right` of rectangle
        public readonly byte right;
        /// letter position of first interlockin letter in `right` word
        public readonly byte rightLetterPos;
        /// length of word that occupies `right` of rectangle
        public readonly byte rightLength;

        /// number of letters from first interlock to last interlock of `top` and `bottom` words of rectangle or square shape
        public readonly byte interlockWidth;
        /// number of letters from first interlock to last interlock of `left` and `right` words of rectangle or square shape
        public readonly byte interlockHeight;
        /// type of shape rendered. valid values are `rectangle`,`topLeft`, `topRight`, `bottomLeft`, `bottomRight`
        public readonly RectangleType type;

        public RectangleModel(ushort score, byte width, byte height,
                       byte top, byte topLetterPos, byte topLength,
                       byte bottom, byte bottomLetterPos, byte bottomLength,
                       byte left, byte leftLetterPos, byte leftLength,
                       byte right, byte rightLetterPos, byte rightLength,
                       byte interlockWidth, byte interlockHeight, RectangleType type)
        {
            this.score = score;
            this.width = width;
            this.height = height;

            this.top = top;
            this.topLetterPos = topLetterPos;
            this.topLength = topLength;

            this.bottom = bottom;
            this.bottomLetterPos = bottomLetterPos;
            this.bottomLength = bottomLength;

            this.left = left;
            this.leftLetterPos = leftLetterPos;
            this.leftLength = leftLength;

            this.right = right;
            this.rightLetterPos = rightLetterPos;
            this.rightLength = rightLength;

            this.interlockWidth = interlockWidth;
            this.interlockHeight = interlockHeight;
            this.type = type;
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
            switch (this.type)
            {
                case RectangleType.bottomRight:
                    return ToPlacementsFromRectangle();
                case RectangleType.rectangle:
                    return ToPlacementsFromRectangle();
                case RectangleType.topLeft:
                    return ToPlacementsFromTopLeft();
                case RectangleType.bottomLeft:
                    return ToPlacementsFromBottomLeft();
                case RectangleType.topRight:
                    return ToPlacementsFromTopRight();
                default:
                    return new List<PlacementModel>();
            }
        }


        /// converts `bottomLeft` rectangles to placements
        public List<PlacementModel> ToPlacementsFromBottomLeft()
        {
            var maxLeft = topLetterPos + 1;
            var maxUp = (int)(Math.Max(leftLetterPos, rightLetterPos));

            var topPlacement = new PlacementModel(
                w: top,
                x: 0,
                y: (byte)(maxUp + 1),
                z: true,
                l: topLength);

            var bottomPlacement = new PlacementModel(
                w: bottom,
                x: (byte)maxLeft,
                y: (byte)(maxUp + 1 + interlockHeight),
                z: true,
                l: bottomLength);

            var leftPlacement = new PlacementModel(
                w: left,
                x: (byte)maxLeft,
                y: (byte)(maxUp - leftLetterPos),
                z: false,
                l: leftLength);

            var rightPlacement = new PlacementModel(
                w: right,
                x: (byte)(maxLeft + interlockWidth),
                y: (byte)(maxUp - rightLetterPos),
                z: false,
                l: rightLength);

            var placements = new List<PlacementModel> { topPlacement, bottomPlacement, leftPlacement, rightPlacement };

            //placements.sort { $0.w< $1.w }

            return placements;
        }


        /// Converts `rectangles` to placements
        private List<PlacementModel> ToPlacementsFromRectangle()
        {
            var maxLeft = (int)(Math.Max(this.topLetterPos, this.bottomLetterPos));
            var maxUp = (int)(Math.Max(leftLetterPos, rightLetterPos));

            var topPlacement = new PlacementModel(
                w: top,
                x: (byte)(maxLeft - topLetterPos),
                y: (byte)(maxUp + 1),
                z: true,
                l: topLength);

            var bottomPlacement = new PlacementModel(
                w: bottom,
                x: (byte)(maxLeft - bottomLetterPos),
                y: (byte)(maxUp + 1 + interlockHeight),
                z: true,
                l: bottomLength);

            var leftPlacement = new PlacementModel(
                w: left,
                x: (byte)(maxLeft + 1),
                y: (byte)(maxUp - leftLetterPos),
                z: false,
                l: leftLength);

            var rightPlacement = new PlacementModel(
                w: right,
                x: (byte)(maxLeft + 1 + interlockWidth),
                y: (byte)(maxUp - rightLetterPos),
                z: false,
                l: rightLength);

            var placements = new List<PlacementModel> { topPlacement, bottomPlacement, leftPlacement, rightPlacement };

            // placements.sort { $0.w < $1.w }

            return placements;
        }


        /// converts `topLeft` rectangles to placements
        private List<PlacementModel> ToPlacementsFromTopLeft()
        {
            var maxLeft = bottomLetterPos;
            var maxUp = rightLetterPos + 1;

            var topPlacement = new PlacementModel(
                w: top,
                x: (byte)(maxLeft + 1),
                y: (byte)(maxUp),
                z: true,
                l: topLength
            );

            var bottomPlacement = new PlacementModel(
                w: bottom,
                x: (byte)(maxLeft - (int)(bottomLetterPos)),
                y: (byte)(maxUp + (int)(interlockHeight)),
                z: true,
                l: bottomLength);

            var leftPlacement = new PlacementModel(
                w: left,
                x: (byte)(maxLeft + 1),
                y: (byte)(maxUp),
                z: false,
                l: leftLength);

            var rightPlacement = new PlacementModel(
                w: right,
                x: (byte)(maxLeft + (int)(interlockWidth) + 1),
                y: 0,
                z: false,
                l: rightLength);

            var placements = new List<PlacementModel> { topPlacement, bottomPlacement, leftPlacement, rightPlacement };

            //placements.sort { $0.w < $1.w }

            return placements;
        }


        /// converts `topRight` rectangles to placements
        private List<PlacementModel> ToPlacementsFromTopRight()
        {
            var maxLeft = (int)(Math.Max(topLetterPos, bottomLetterPos));
            var maxUp = leftLetterPos + 1;

            var topPlacement = new PlacementModel(
                w: top,
                x: (byte)(maxLeft - topLetterPos),
                y: (byte)maxUp,
                z: true,
                l: topLength);

            var bottomPlacement = new PlacementModel(
                w: bottom,
                x: (byte)(maxLeft - bottomLetterPos),
                y: (byte)(maxUp + interlockHeight),
                z: true,
                l: bottomLength);

            var leftPlacement = new PlacementModel(
                w: left,
                x: (byte)(maxLeft + 1),
                y: 0,
                z: false,
                l: leftLength);

            var rightPlacement = new PlacementModel(
                w: right,
                x: (byte)(maxLeft + interlockWidth + 1),
                y: (byte)maxUp,
                z: false,
                l: rightLength);

            var placements = new List<PlacementModel> { topPlacement, bottomPlacement, leftPlacement, rightPlacement };

            //placements.sort { $0.w < $1.w }

            return placements;
        }
    }
}