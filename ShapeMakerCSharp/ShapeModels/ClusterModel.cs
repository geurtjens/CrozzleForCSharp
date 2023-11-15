using System;
using CrozzleInterfaces;

namespace ShapeMakerCSharp
{
    public readonly record struct ClusterModel
    {
        public readonly List<int> wordsHorizontal;
        public readonly List<int> wordsVertical;

        public readonly List<ClusterPosition> patternHorizontal;
        public readonly List<ClusterPosition> patternVertical;

        public readonly List<byte> lengthsHorizontal;
        public readonly List<byte> lengthsVertical;

        public readonly ushort score;
        public readonly byte width;
        public readonly byte height;


        public ClusterModel(
            in List<int> wordsHorizontal,
            in List<int> wordsVertical,
            in List<ClusterPosition> patternHorizontal,
            in List<ClusterPosition> patternVertical,
            in List<string> start,
            in List<string> end,
            in List<int> len)
        {
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

            this.score = ScoreCalculator.clusterCalculator(
                wordsHorizontal,
                patternHorizontal,
                start,
                end,
                wordsHorizontal.Count,
                wordsVertical.Count);

            this.width = widthCalculation(
                wordsHorizontal,
                patternHorizontal,
                wordsVertical.Count,
                _lengthsHorizontal);

            this.height = widthCalculation(
                wordsVertical,
                patternVertical,
                wordsHorizontal.Count,
                _lengthsVertical);
        }



        public ShapeModel ToShape()
        {
            return new ShapeModel(score, width, height, ToPlacements());
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
            in List<int> words,
            in List<ClusterPosition> patterns,
            int wordCountOther,
            in List<byte> len)
        {
            int maxLeft = 0;
            int maxRight = 0;

            for (int i = 0; i < words.Count; i++)
            {
                int length = (int)len[i] - wordCountOther;
                var pattern = patterns[i];

                switch (pattern)
                {
                    case ClusterPosition.leading:
                        if (length > maxLeft)
                        {
                            maxLeft = length;
                        }
                        break;
                    case ClusterPosition.trailing:
                        if (length > maxRight)
                        {
                            maxRight = length;
                        }
                        break;
                    case ClusterPosition.middle:
                        break;
                    case ClusterPosition.outer:
                        break;
                }
            }
            int width = maxLeft + maxRight + wordCountOther + 2;
            return (byte)width;
        }


        private int maxLeftCalculate()
        {
            var maxLeft = 0;

            for (int i = 0; i < wordsHorizontal.Count; i++)
            {
                var length = (int)(lengthsHorizontal[i] - wordsVertical.Count);

                if (patternHorizontal[i] == ClusterPosition.leading && length > maxLeft)
                {
                    maxLeft = length;
                }
            }
            return maxLeft;
        }


        private int maxUpCalculate()
        {
            var maxUp = 0;

            for (int i = 0; i < wordsVertical.Count; i++)
            {
                var length = (int)(lengthsVertical[i] - wordsHorizontal.Count);

                if (patternVertical[i] == ClusterPosition.leading && length > maxUp)
                {
                    maxUp = length;
                }
            }
            return maxUp;
        }


        private PlacementList ToPlacements()
        {
            var interlockWidth = wordsVertical.Count;
            var interlockHeight = wordsHorizontal.Count;

            var maxLeft = maxLeftCalculate();
            var maxUp = maxUpCalculate();

            var placements = new PlacementList();

            for (int i = 0; i < wordsHorizontal.Count; i++)
            {
                var pattern = patternHorizontal[i];
                var length = (int)(lengthsHorizontal[i] - interlockWidth);
                var y = maxUp + i + 1;
                var wordId = wordsHorizontal[i];
                if (pattern == ClusterPosition.leading)
                {
                    var placement = new PlacementModel(w: (byte)wordId, x: (byte)(maxLeft - length), y: (byte)y, z: true, l: lengthsHorizontal[i]);
                    placements.Add(placement);
                }
                else
                {
                    var placement = new PlacementModel(w: (byte)wordId, x: (byte)maxLeft, y: (byte)y, z: true, l: lengthsHorizontal[i]);
                    placements.Add(placement);
                }
            }
            for (int i = 0; i < wordsVertical.Count; i++)
            {
                var pattern = patternVertical[i];
                var length = (int)(lengthsVertical[i] - interlockHeight);
                var x = maxLeft + i + 1;
                var wordId = wordsVertical[i];
                if (pattern == ClusterPosition.leading)
                {
                    var placement = new PlacementModel(w: (byte)wordId, x: (byte)x, y: (byte)(maxUp - length), z: false, l: lengthsVertical[i]);
                    placements.Add(placement);
                }
                else
                {
                    // y is maxUp - 1 because it needs to add his .
                    var placement = new PlacementModel(w: (byte)(wordId), x: (byte)(x), y: (byte)(maxUp), z: false, l: lengthsVertical[i]);
                    placements.Add(placement);
                }
            }
            //placements.sort { $0.w < $1.w}
            return placements;
        }

    }
}