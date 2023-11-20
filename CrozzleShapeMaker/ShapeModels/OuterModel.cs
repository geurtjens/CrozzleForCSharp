using CrozzleInterfaces;

namespace CrozzleShapeMaker;

public readonly record struct OuterModel
{
    public readonly List<int> wordsHorizontal;
    public readonly List<int> wordsVertical;
    public readonly List<ClusterPosition> patternHorizontal;
    public readonly List<ClusterPosition> patternVertical;

    public readonly List<int> outerPos;

    public readonly List<byte> lengthsHorizontal;
    public readonly List<byte> lengthsVertical;

    public readonly ushort score;
    public readonly byte width;
    public readonly byte height;

    public OuterModel(
        in List<int> wordsHorizontal,
        in List<int> wordsVertical,
        in List<ClusterPosition> patternHorizontal,
        in List<ClusterPosition> patternVertical,
        in List<string> words,
        in List<string> end,
        in List<int> len,
        in List<int> outerPos)
    {
        this.wordsHorizontal = wordsHorizontal;
        this.wordsVertical = wordsVertical;
        this.patternHorizontal = patternHorizontal;
        this.patternVertical = patternVertical;
        this.outerPos = outerPos;

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

        // lets find the outer
        this.lengthsHorizontal = _lengthsHorizontal;
        this.lengthsVertical = _lengthsVertical;

        this.width = (byte)widthCalculation(wordsHorizontal, patternHorizontal, (int)wordsVertical.Count, _lengthsHorizontal);


        int outerStart = outerPos[0];
        int outerLocation = 0;
        int middleLocation = 1;
        if (outerStart == -1)
        {
            outerLocation = 1;
            middleLocation = 0;
            outerStart = outerPos[1];
        }

        var middleWord = words[wordsVertical[middleLocation]];
        var outerWord = words[wordsVertical[outerLocation]];

        int score = ((int)wordsHorizontal.Count + (int)wordsVertical.Count) * 10;

        foreach (var letter in middleWord)
        {
            score += ScoreCalculator.score(letter);
        }
        for (int i = 0; i < wordsHorizontal.Count; i++)
        {
            score += ScoreCalculator.score(outerWord[outerStart + i]);
        }

        this.score = (ushort)score;

        int _height = _lengthsVertical[outerLocation] + 2;
        if (outerPos[0] == -1)
        {
            _height = _lengthsVertical[1] + 2;
        }

        this.height = (byte)_height;
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


    public ShapeModel ToShape()
    {
        return new ShapeModel(score, width, height, ToPlacements());
    }


    private int maxLeftCalculate()
    {

        int maxLeft = 0;

        for (int i = 0; i < wordsHorizontal.Count; i++)
        {
            int length = lengthsHorizontal[i] - wordsVertical.Count;

            if (patternHorizontal[i] == ClusterPosition.leading && length > maxLeft)
            {
                maxLeft = length;
            }
        }
        return maxLeft;
    }


    private int widthCalculation(
        List<int> words,
        List<ClusterPosition> patterns,
        int wordCountOther,
        List<byte> len)
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
                    break; // THIS IS NOT GOING TO WORK
            }
        }
        int width = maxLeft + maxRight + wordCountOther + 2;
        return width;
    }


    private List<PlacementModel> ToPlacements()
    {
        int interlockWidth = (int)wordsVertical.Count;
        int maxUp = 1;

        foreach (var item in outerPos)
        {
            if (item != -1)
            {
                maxUp = item;
            }
        }

        // This means that outerStart + 1 is the y location of middle and also the starting y of all the horizontal words

        int maxLeft = maxLeftCalculate();

        var placements = new List<PlacementModel>();
        for (int i = 0; i < wordsHorizontal.Count; i++)
        {
            var pattern = patternHorizontal[i];
            int length = lengthsHorizontal[i] - interlockWidth;
            int y = maxUp + i + 1;
            int wordId = wordsHorizontal[i];
            if (pattern == ClusterPosition.leading)
            {
                var placement = new PlacementModel((byte)wordId, (byte)(maxLeft - length), (byte)y, true, lengthsHorizontal[i]);
                placements.Add(placement);
            }
            else
            {
                var placement = new PlacementModel((byte)wordId, (byte)maxLeft, (byte)y, true, lengthsHorizontal[i]);
                placements.Add(placement);
            }
        }

        // the outer is the one at the top and the middle is the one starting at maxUp
        int outerLocation = 0;
        
        if (outerPos[0] == -1)
        {
            outerLocation = 1;
        }

        int w0 = (byte)wordsVertical[0];
        int w1 = (byte)wordsVertical[1];
        int len0 = (byte)lengthsVertical[0];
        int len1 = (byte)lengthsVertical[1];

        if (outerLocation == 0)
        {
            var outerPlacement = new PlacementModel((byte)w0, (byte)(maxLeft + 1), 0, false, (byte)len0);
            var middlePlacement = new PlacementModel((byte)w1, (byte)(maxLeft + 2), (byte)maxUp, false, (byte)len1);

            placements.Add(outerPlacement);
            placements.Add(middlePlacement);
        }
        else
        {
            var middlePlacement = new PlacementModel((byte)w0, (byte)(maxLeft + 1), (byte)maxUp, false, (byte)len0);
            var outerPlacement = new PlacementModel((byte)w1, (byte)(maxLeft + 2), 0, false, (byte)len1);

            placements.Add(middlePlacement);
            placements.Add(outerPlacement);
        }

        return placements;
    }

}