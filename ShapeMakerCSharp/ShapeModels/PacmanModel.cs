using System;
using CrozzleInterfaces;
using ShapeMakerCSharp;
using static System.Formats.Asn1.AsnWriter;

namespace ShapeMakerCSharp
{
    public readonly record struct PacmanModel
    {
        public readonly PacmanType pacmanType;
        public readonly List<int> wordsHorizontal;
        public readonly List<int> wordsVertical;
        public readonly List<ClusterPosition> patternHorizontal;
        public readonly List<ClusterPosition> patternVertical;

        public readonly List<byte> lengthsHorizontal;
        public readonly List<byte> lengthsVertical;

        public readonly ushort score;
        public readonly byte width;
        public readonly byte height;

        public PacmanModel(
            PacmanType type,
            in List<int> wordsHorizontal,
            in List<int> wordsVertical,
            in List<ClusterPosition> patternHorizontal,
            in List<ClusterPosition> patternVertical,
            in List<string> start,
            in List<string> end,
            in List<int> len)
        {
            this.pacmanType = type;
            this.wordsHorizontal = wordsHorizontal;
            this.wordsVertical = wordsVertical;
            this.patternHorizontal = patternHorizontal;
            this.patternVertical = patternVertical;

            var _lengthsHorizontal = new List<byte>();
            foreach (var wordId in wordsHorizontal)
            {
                _lengthsHorizontal.Add((byte)len[wordId]);
            }

            var _lengthsVertical = new List<byte>();
            foreach (var wordId in wordsVertical)
            {
                _lengthsVertical.Add((byte)len[wordId]);
            }
            this.lengthsHorizontal = _lengthsHorizontal;
            this.lengthsVertical = _lengthsVertical;

            this.score = scoreCalculator(type, wordsHorizontal, start, end);
                

            this.width = widthCalculation(
                type,
                _lengthsHorizontal);

            this.height = heightCalculation(
                type,
                _lengthsVertical);
        }

        private static ushort scoreCalculator(PacmanType type, in List<int> wordsHorizontal, in List<String> start, in List<String> end)
        {
            var score = 6 * 10;

            switch (type) {
                case PacmanType.topRight:

                    for (int i = 0; i < 2; i++)
                    {
                        score += ScoreCalculator.score(end[wordsHorizontal[0]][i]);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        score += ScoreCalculator.score(start[wordsHorizontal[1]][i]);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        score += ScoreCalculator.score(end[wordsHorizontal[2]][i]);
                    }

                    return (ushort)score;

                case PacmanType.bottomRight:
                    
                    for (int i = 0; i < 3; i++)
                    {
                        score += ScoreCalculator.score(end[wordsHorizontal[0]][i]);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        score += ScoreCalculator.score(start[wordsHorizontal[1]][i]);
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        score += ScoreCalculator.score(end[wordsHorizontal[2]][i]);
                    }

                    return (ushort)score;

                case PacmanType.topLeft:
                    
                    for (int i = 0; i < 2; i++) {
                        score += ScoreCalculator.score(start[wordsHorizontal[0]][i]);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        score += ScoreCalculator.score(end[wordsHorizontal[1]][i]);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        score += ScoreCalculator.score(start[wordsHorizontal[2]][i]);
                    }

                    return (ushort)score;

                default:
                    return 0;
            }
        }
    

        public ShapeModel ToShape()
        {
            return new ShapeModel(score, width, height, ToPlacements());
        }

        private List<PlacementModel> ToPlacements()
        {
            switch (pacmanType)
            {
                case PacmanType.topRight:
                    return topRightPlacements();
                case PacmanType.bottomRight:
                    return bottomRightPlacements();
                case PacmanType.topLeft:
                    return topLeftPlacements();
                default:
                    return new List<PlacementModel>();
            }
        }


        private List<PlacementModel> bottomRightPlacements()
        {
            var interlockWidth = (byte)(this.wordsVertical.Count);
            var interlockHeight = (byte)(this.wordsHorizontal.Count);

            var maxLeft = (byte)Math.Max(lengthsHorizontal[0], lengthsHorizontal[2] + 1);
            var maxUp = (byte)Math.Max(lengthsVertical[0], lengthsVertical[2] + 1);

            /*
                . .
                T S
                R.E
              .BULL.
               .SOLD.
            .UNITS.
                .S
                 .
             */

            var x0 = (byte)(maxLeft - lengthsHorizontal[0]);
            var x1 = (byte)(maxLeft - interlockWidth);
            var x2 = (byte)(maxLeft - lengthsHorizontal[2] - 1);

            var x3 = (byte)(maxLeft + 1 - interlockWidth);
            var x4 = (byte)(maxLeft + 2 - interlockWidth);
            var x5 = (byte)(maxLeft + 3 - interlockWidth);

            var y0 = (byte)(maxUp + 1 - interlockHeight);
            var y1 = (byte)(maxUp + 2 - interlockHeight);
            var y2 = (byte)(maxUp + 3 - interlockHeight);

            var y3 = (byte)(maxUp - lengthsVertical[0]);
            var y4 = (byte)(maxUp - interlockWidth);
            var y5 = (byte)(maxUp - lengthsVertical[2] - 1);

            var placements = new List<PlacementModel> {
                new PlacementModel(w: (byte)wordsHorizontal[0], x: x0, y: y0, z: true, l: lengthsHorizontal[0]),
                new PlacementModel(w: (byte)wordsHorizontal[1], x: x1, y: y1, z: true, l: lengthsHorizontal[1]),
                new PlacementModel(w: (byte)wordsHorizontal[2], x: x2, y: y2, z: true, l: lengthsHorizontal[2]),

                new PlacementModel(w: (byte)wordsVertical[0], x: x3, y: y3, z: false, l: lengthsVertical[0]),
                new PlacementModel(w: (byte)wordsVertical[1], x: x4, y: y4, z: false, l: lengthsVertical[1]),
                new PlacementModel(w: (byte)wordsVertical[2], x: x5, y: y5, z: false, l: lengthsVertical[2])
            };

            return placements;
        }

        private List<PlacementModel> topLeftPlacements()
        {
            var interlockWidth = (byte)wordsVertical.Count;
            var interlockHeight = (byte)wordsHorizontal.Count;

            var maxLeft = (byte)lengthsHorizontal[1] - interlockWidth;
            var maxUp = (byte)lengthsVertical[1] - interlockHeight;

            /*
                    .
                    N
                    O.
                   .TRUST.
              .TRUSTEE.
                  .ASSETS.
                   X.E
                   . R
                     V
                     E
                     .
            */
            var x0 = (byte)(maxLeft + 1); // Plus one because the size of the top must include the last . as its a pacman placement
            var x1 = (byte)0;
            var x2 = (byte)maxLeft;

            var x3 = (byte)(maxLeft + 1);
            var x4 = (byte)(maxLeft + 2);
            var x5 = (byte)(maxLeft + 3);

            var y0 = (byte)(maxUp + 1);
            var y1 = (byte)(maxUp + 2);
            var y2 = (byte)(maxUp + 3);

            var y3 = (byte)(maxUp + 1);
            var y4 = (byte)0;
            var y5 = (byte)maxUp;

            var placements = new List<PlacementModel> {
                new PlacementModel(w: (byte)wordsHorizontal[0], x: x0, y: y0, z: true, l: lengthsHorizontal[0]),
                new PlacementModel(w: (byte)wordsHorizontal[1], x: x1, y: y1, z: true, l: lengthsHorizontal[1]),
                new PlacementModel(w: (byte)wordsHorizontal[2], x: x2, y: y2, z: true, l: lengthsHorizontal[2]),

                new PlacementModel(w: (byte)wordsVertical[0], x: x3, y: y3, z: false, l: lengthsVertical[0]),
                new PlacementModel(w: (byte)wordsVertical[1], x: x4, y: y4, z: false, l: lengthsVertical[1]),
                new PlacementModel(w: (byte)wordsVertical[2], x: x5, y: y5, z: false, l: lengthsVertical[2])
            };

            return placements;
        }

        private List<PlacementModel> topRightPlacements()
        {
            var interlockWidth = (byte)wordsVertical.Count;
            var interlockHeight = (byte)wordsHorizontal.Count;

            var maxLeft = (byte)Math.Max(lengthsHorizontal[0] + 1, lengthsHorizontal[2]);
            var maxUp = (byte)(lengthsVertical[1] - interlockHeight);

            /*
                     .
                     B
                    .U
               .PARITY.
                   .RESERVE.
             .DEBENTURE.
                    S.L
                    T L
                    . .
             */

            //print(lengthsHorizontal)
            // The difference between the maximum length leading and the length of the word
            var x0 = (byte)(maxLeft - lengthsHorizontal[0] - 1); // Plus one because the size of the top must include the last . as its a pacman placement
            var x1 = (byte)(maxLeft - interlockWidth);
            var x2 = (byte)(maxLeft - lengthsHorizontal[2]);

            var x3 = (byte)(maxLeft + 1 - interlockWidth);
            var x4 = (byte)(maxLeft + 2 - interlockWidth);
            var x5 = (byte)(maxLeft + 3 - interlockWidth);

            var y0 = (byte)(maxUp + 1);
            var y1 = (byte)(maxUp + 2);
            var y2 = (byte)(maxUp + 3);

            var y3 = (byte)maxUp;
            var y4 = (byte)0;
            var y5 = (byte)(maxUp + 1);

            var placements = new List<PlacementModel> {
                new PlacementModel(w: (byte)wordsHorizontal[0], x: x0, y: y0, z: true, l: lengthsHorizontal[0]),
                new PlacementModel(w: (byte)wordsHorizontal[1], x: x1, y: y1, z: true, l: lengthsHorizontal[1]),
                new PlacementModel(w: (byte)wordsHorizontal[2], x: x2, y: y2, z: true, l: lengthsHorizontal[2]),

                new PlacementModel(w: (byte)wordsVertical[0], x: x3, y: y3, z: false, l: lengthsVertical[0]),
                new PlacementModel(w: (byte)wordsVertical[1], x: x4, y: y4, z: false, l: lengthsVertical[1]),
                new PlacementModel(w: (byte)wordsVertical[2], x: x5, y: y5, z: false, l: lengthsVertical[2])
            };

            return placements;
        }


        public bool isValid(int scoreMin, int widthMax, int heightMax)
        {
            if (this.score < scoreMin)
            {
                return false;
            }
            if ((this.width <= widthMax && this.height <= heightMax) || (this.width <= heightMax && this.height <= widthMax))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private byte widthCalculation(
            PacmanType type,
            List<byte> len)
        {

            int len0 = len[0];
            int len1 = len[1];
            int len2 = len[2];

            int interlockWidth = 3;  // Only works for 3x3 at the moment

            int maxLeading = 0;
            int maxTrailing = 0;
            int result = 0;

            switch (type)
            {
                case PacmanType.topRight:
                    maxLeading = Math.Max(len0 + 1, len2);
                    maxTrailing = len1;
                    result = maxLeading + maxTrailing - interlockWidth + 2;
                    break;
                case PacmanType.bottomRight:
                    maxLeading = Math.Max(len0, len2 + 1);
                    maxTrailing = len1;
                    result = maxLeading + maxTrailing - interlockWidth + 2;
                    break;
                case PacmanType.topLeft:
                    maxLeading = len1;
                    maxTrailing = Math.Max(len0 + 1, len2);
                    result = maxLeading + maxTrailing - interlockWidth + 2;
                    break;
            }
            return (byte)result;
        }


        private byte heightCalculation(
            PacmanType type,
            List<byte> len)
        {

            int len0 = len[0];
            int len1 = len[1];
            int len2 = len[2];

            int interlockHeight = 3;

            int maxLeading = 0;
            int maxTrailing = 0;
            switch (type)
            {
                case PacmanType.topRight:
                    maxLeading = len1;
                    maxTrailing = Math.Max(len0, len2 + 1);
                    break;
                case PacmanType.bottomRight:
                    maxLeading = Math.Max(len0, len2 + 1);
                    maxTrailing = len1;
                    break;
                case PacmanType.topLeft:
                    maxLeading = len1;
                    maxTrailing = Math.Max(len0 + 1, len2);
                    break;
            }
            int result = maxLeading + maxTrailing - interlockHeight + 2;
            return (byte)result;
        }


    }
}