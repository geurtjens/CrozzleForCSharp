using System;
using CrozzleInterfaces;

namespace ShapeMakerCSharp
{
    public class RectangleCalculatorV2
    {


        public static int ExecuteAllSerial(
            in List<GameModel> games,
            int scoreMin,
            bool includeBreakdown = false)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (includeBreakdown)
            {
                Console.WriteLine("RectangleV2 Shapes");
                Console.WriteLine("GameId, WinningWordShapes, AllWordShapes");
            }

            int shapesFromWordsCount = 0;
            int shapesFromWinningWordsCount = 0;

            foreach (GameModel game in games)
            {
                var shapesFromWinningWords = Execute(game.winningWords, scoreMin, game.widthMax, game.heightMax);
                var shapesFromWords = Execute(game.words, scoreMin, game.widthMax, game.heightMax);

                var a = new List<ShapeModel>();
                a.Capacity = shapesFromWinningWords.Count;
                foreach(var shape in shapesFromWinningWords)
                {
                    a.Add(shape.ToShape());
                }

                var b = new List<ShapeModel>();
                b.Capacity = shapesFromWords.Count;
                foreach (var shape in shapesFromWords)
                {
                    b.Add(shape.ToShape());
                }


                if (includeBreakdown)
                {
                    Console.WriteLine($"{game.gameId}, {shapesFromWinningWords.Count}, {shapesFromWords.Count}");
                }

                shapesFromWordsCount += b.Count;
                shapesFromWinningWordsCount += a.Count;

            }
            watch.Stop();

            Console.WriteLine($"RectangleCalculatorV2 produced {shapesFromWinningWordsCount} winning words records and {shapesFromWordsCount} words records in {watch.ElapsedMilliseconds} ms\n");

            return shapesFromWordsCount;
        }


        private static int CalculateWidthIndented(
            int letterPos,
            int wordLength,
            int indentedWordLength)
        {
            int bottomLeft = letterPos;
            int bottomRight = wordLength - letterPos;
            int topRight = indentedWordLength + 1;
            int width = bottomLeft + Math.Max(topRight, bottomRight);
            return width + 2;
        }

        private static int CalculateWidth(
            int topLength,
            int bottomLength,
            int topLetterPos,
            int bottomLetterPos)
        {
            int before = Math.Max(topLetterPos, bottomLetterPos);

            int topRemaining = topLength - topLetterPos;
            int bottomRemaining = bottomLength - bottomLetterPos;

            int after = Math.Max(topRemaining, bottomRemaining);

            int width = before + after;

            return width + 2; // We add +2 for the blocking characters
        }



        public static List<RectangleModel> Square(
            int interlockWidth,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            var result = new List<RectangleModel>();

            int wordCount = words.Count;

            for (int _top = 0; _top < wordCount; _top++)
            {

                if (lengths[_top] >= interlockWidth)
                {
                    for (int _topLetterPos = 0; _topLetterPos < lengths[_top] - interlockWidth; _topLetterPos++)
                    {
                        var leftWords = letterIndex.find(words[_top][_topLetterPos]);

                        foreach (var left in leftWords)
                        {
                            if (left.end >= interlockWidth && left.id > _top)
                            {
                                var bottomWords = letterIndex.find(words[left.id][left.start + interlockWidth]);

                                foreach (var bottom in bottomWords)
                                {
                                    if (bottom.end >= interlockWidth &&
                                        bottom.id != left.id &&
                                        bottom.id != _top)
                                    {
                                        var rightWords = letterIndex.find(words[_top][_topLetterPos + interlockWidth]);

                                        foreach (var right in rightWords)
                                        {
                                            if (right.end >= interlockWidth &&
                                                right.id != bottom.id &&
                                                right.id != left.id &&
                                                right.id != _top)
                                            {
                                                if (words[bottom.id][bottom.start + interlockWidth] == words[right.id][right.start + interlockWidth])
                                                {
                                                    int score = ScoreCalculator.rectangle(
                                                        words[_top][_topLetterPos],
                                                        words[_top][_topLetterPos + interlockWidth],
                                                        words[bottom.id][bottom.start],
                                                        words[bottom.id][bottom.start + interlockWidth]);

                                                    if (score >= scoreMin)
                                                    {
                                                        int width = CalculateWidth(
                                                            lengths[_top],
                                                            lengths[bottom.id],
                                                            _topLetterPos,
                                                            bottom.start);

                                                        int height = CalculateWidth(
                                                            lengths[left.id],
                                                            lengths[right.id],
                                                            left.start,
                                                            right.start);

                                                        if ((width <= widthMax && height <= heightMax) ||
                                                            (width <= heightMax && height <= widthMax))
                                                        {

                                                            RectangleModel rectangle = new RectangleModel(
                                                                (ushort)score,
                                                                (byte)width,
                                                                (byte)height,
                                                                (byte)_top,
                                                                (byte)_topLetterPos,
                                                                (byte)lengths[_top],
                                                                (byte)bottom.id,
                                                                (byte)bottom.start,
                                                                (byte)lengths[bottom.id],
                                                                (byte)left.id,
                                                                (byte)left.start,
                                                                (byte)lengths[left.id],
                                                                (byte)right.id,
                                                                (byte)right.start,
                                                                (byte)lengths[right.id],
                                                                (byte)interlockWidth,
                                                                (byte)interlockWidth,
                                                                RectangleType.rectangle);

                                                            result.Add(rectangle);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }


        public static List<RectangleModel> Rectangle(
            int interlockWidth,
            int interlockHeight,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            if (interlockWidth > interlockHeight)
            {
                return new List<RectangleModel>();
            }

            var result = new List<RectangleModel>();

            int wordCount = words.Count;

            for (int _top = 0; _top < wordCount; _top++)
            {
                if (lengths[_top] >= interlockWidth)
                {
                    for (int _topLetterPos = 0; _topLetterPos < (lengths[_top] - interlockWidth); _topLetterPos++)
                    {
                        var leftWords = letterIndex.find(words[_top][_topLetterPos]);

                        foreach (var left in leftWords)
                        {
                            if (left.end >= interlockHeight
                                && left.id != _top)
                            {
                                var bottomWords = letterIndex.find(words[left.id][left.start + interlockHeight]);

                                foreach (var bottom in bottomWords)
                                {
                                    if (bottom.end >= interlockWidth &&
                                        bottom.id != left.id &&
                                        bottom.id != _top)
                                    {
                                        var rightWords = letterIndex.find(words[_top][_topLetterPos + interlockWidth]);

                                        foreach (var right in rightWords)
                                        {
                                            if (right.end >= interlockHeight &&
                                                right.id != bottom.id &&
                                                right.id != left.id &&
                                                right.id != _top)
                                            {
                                                /// I dont think this check is valid but will fix later
                                                if (words[bottom.id][bottom.start + interlockWidth] == words[right.id][right.start + interlockHeight])
                                                {
                                                    int score = ScoreCalculator.rectangle(
                                                        words[_top][_topLetterPos],
                                                        words[_top][_topLetterPos + interlockWidth],
                                                        words[bottom.id][bottom.start],
                                                        words[bottom.id][bottom.start + interlockWidth]);

                                                    if (score >= scoreMin)
                                                    {

                                                        int width = CalculateWidth(
                                                            lengths[_top],
                                                            lengths[bottom.id],
                                                            _topLetterPos,
                                                            bottom.start);

                                                        int height = CalculateWidth(
                                                            lengths[left.id],
                                                            lengths[right.id],
                                                            left.start,
                                                            right.start);

                                                        if ((width <= widthMax && height <= heightMax) ||
                                                            (width <= heightMax && height <= widthMax))
                                                        {

                                                            RectangleModel rectangle = new RectangleModel(
                                                                (ushort)score,
                                                                (byte)width,
                                                                (byte)height,
                                                                (byte)_top,
                                                                (byte)_topLetterPos,
                                                                (byte)lengths[_top],
                                                                (byte)bottom.id,
                                                                (byte)bottom.start,
                                                                (byte)lengths[bottom.id],
                                                                (byte)left.id,
                                                                (byte)left.start,
                                                                (byte)lengths[left.id],
                                                                (byte)right.id,
                                                                (byte)right.start,
                                                                (byte)lengths[right.id],
                                                                (byte)interlockWidth,
                                                                (byte)interlockHeight,
                                                                RectangleType.rectangle);

                                                            result.Add(rectangle);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static List<RectangleModel> TopLeftRectangle(
            int interlockWidth,
            int interlockHeight,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            if (interlockWidth > interlockHeight)
            {
                return new List<RectangleModel>();
            }

            var result = new List<RectangleModel>();

            int wordCount = words.Count;

            /*
                  .AZURE
                  S I
            DECORATIONS
                  A N
                  R
            */


            for (int _left = 0; _left < wordCount; _left++)
            {
                if (lengths[_left] >= interlockHeight)
                {
                    int _leftLetterPos = interlockHeight - 1;

                    var bottomWords = letterIndex.find(words[_left][_leftLetterPos]);

                    foreach (var bottom in bottomWords)
                    {
                        if (bottom.end >= interlockWidth &&
                            bottom.id != _left)
                        {
                            var rightWords = letterIndex.find(words[bottom.id][bottom.start + interlockWidth]);

                            foreach (var right in rightWords)
                            {
                                if (right.start >= interlockHeight &&
                                    right.id != bottom.id &&
                                    right.id != _left)
                                {
                                    var topWords = letterIndex.find(words[right.id][right.start - interlockHeight]);

                                    foreach (var top in topWords)
                                    {

                                        if (top.start == interlockWidth - 1 &&
                                            top.id != right.id &&
                                            top.id != bottom.id &&
                                            top.id != _left)
                                        {
                                            int score = ScoreCalculator.topLeft(
                                                words[top.id][top.start],
                                                words[bottom.id][bottom.start],
                                                words[bottom.id][bottom.start + interlockWidth]);

                                            if (score >= scoreMin)
                                            {
                                                int width = CalculateWidthIndented(
                                                    bottom.start,
                                                    lengths[bottom.id],
                                                    lengths[top.id]);

                                                int height = CalculateWidthIndented(
                                                    right.start - interlockHeight,
                                                    lengths[right.id],
                                                    lengths[_left]);

                                                if ((width <= widthMax && height <= heightMax) ||
                                                    (width <= heightMax && height <= widthMax))
                                                {
                                                    RectangleModel rectangle = new RectangleModel(
                                                        (ushort)score,
                                                        (byte)width,
                                                        (byte)height,
                                                        (byte)top.id,
                                                        (byte)top.start,
                                                        (byte)lengths[top.id],
                                                        (byte)bottom.id,
                                                        (byte)bottom.start,
                                                        (byte)lengths[bottom.id],
                                                        (byte)_left,
                                                        (byte)_leftLetterPos,
                                                        (byte)lengths[_left],
                                                        (byte)right.id,
                                                        (byte)(right.start - interlockHeight),
                                                        (byte)lengths[right.id],
                                                        (byte)interlockWidth,
                                                        (byte)interlockHeight,
                                                        RectangleType.topLeft);

                                                    result.Add(rectangle);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }


        public static List<RectangleModel> TopLeftSquare(
            int interlockWidth,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            var result = new List<RectangleModel>();

            int interlockHeight = interlockWidth;

            int wordCount = words.Count;

            /*
                  .AZURE
                  S I
            DECORATIONS
                  A N
                  R
            */


            for (int _left = 0; _left < wordCount; _left++)
            {
                if (lengths[_left] >= interlockHeight)
                {
                    int _leftLetterPos = interlockHeight - 1;

                    var bottomWords = letterIndex.find(words[_left][_leftLetterPos]);

                    foreach (var bottom in bottomWords)
                    {
                        if (bottom.end >= interlockWidth &&
                            bottom.id != _left)
                        {
                            var rightWords = letterIndex.find(words[bottom.id][bottom.start + interlockWidth]);

                            foreach (var right in rightWords)
                            {
                                if (right.start >= interlockHeight &&
                                    right.id != bottom.id &&
                                    right.id != _left)
                                {
                                    var topWords = letterIndex.find(words[right.id][right.start - interlockHeight]);

                                    foreach (var top in topWords)
                                    {
                                        if (top.start == interlockWidth - 1 &&
                                            top.id != right.id &&
                                            top.id != bottom.id &&
                                            top.id > _left)
                                        {
                                            int score = ScoreCalculator.topLeft(
                                                words[top.id][top.start],
                                                words[bottom.id][bottom.start],
                                                words[bottom.id][bottom.start + interlockWidth]);

                                            if (score >= scoreMin)
                                            {
                                                int width = CalculateWidthIndented(
                                                    bottom.start,
                                                    lengths[bottom.id],
                                                    lengths[top.id]);

                                                int height = CalculateWidthIndented(
                                                    right.start - interlockHeight,
                                                    lengths[right.id],
                                                    lengths[_left]);

                                                if ((width <= widthMax && height <= heightMax) ||
                                                    (width <= heightMax && height <= widthMax))
                                                {

                                                    RectangleModel rectangle = new RectangleModel(
                                                        (ushort)score,
                                                        (byte)width,
                                                        (byte)height,
                                                        (byte)top.id,
                                                        (byte)top.start,
                                                        (byte)lengths[top.id],
                                                        (byte)bottom.id,
                                                        (byte)bottom.start,
                                                        (byte)lengths[bottom.id],
                                                        (byte)_left,
                                                        (byte)_leftLetterPos,
                                                        (byte)lengths[_left],
                                                        (byte)right.id,
                                                        (byte)(right.start - interlockHeight),
                                                        (byte)lengths[right.id],
                                                        (byte)interlockWidth,
                                                        (byte)interlockHeight,
                                                        RectangleType.topLeft);

                                                    result.Add(rectangle);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static List<RectangleModel> BottomRightRectangle(
            int interlockWidth,
            int interlockHeight,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {

            if (interlockWidth > interlockHeight)
            {
                return new List<RectangleModel>();
            }

            var result = new List<RectangleModel>();

            int wordCount = words.Count;
            /*
                T
              Z R
            WHITE
              O E
             INN.
            */


            for (int _right = 0; _right < wordCount; _right++)
            {
                if (lengths[_right] >= interlockHeight)
                {
                    int _rightLetterPos = lengths[_right] - interlockHeight;

                    var topWords = letterIndex.find(words[_right][_rightLetterPos]);

                    foreach (var top in topWords)
                    {
                        if (top.start >= interlockWidth &&
                            top.id != _right)
                        {
                            var leftWords = letterIndex.find(words[top.id][top.start - interlockWidth]);

                            foreach (var left in leftWords)
                            {
                                if (left.end >= interlockHeight &&
                                    left.id != top.id &&
                                    left.id != _right)
                                {
                                    var bottomWords = letterIndex.find(words[left.id][left.start + interlockHeight]);

                                    foreach (var bottom in bottomWords)
                                    {
                                        if (bottom.end == interlockWidth - 1 &&
                                            bottom.id != left.id &&
                                            bottom.id != top.id &&
                                            bottom.id != _right)
                                        {

                                            int score = ScoreCalculator.bottomRight(
                                                words[left.id][left.start],
                                                words[top.id][top.start],
                                                words[bottom.id][bottom.start]);

                                            if (score >= scoreMin)
                                            {
                                                int width = CalculateWidth(
                                                    lengths[top.id],
                                                    lengths[bottom.id],
                                                    top.start - interlockWidth,
                                                    bottom.start);

                                                int height = CalculateWidth(
                                                    lengths[left.id],
                                                    lengths[_right],
                                                    left.start,
                                                    _rightLetterPos);

                                                if ((width <= widthMax && height <= heightMax) ||
                                                    (width <= heightMax && height <= widthMax))
                                                {
                                                    RectangleModel rectangle = new RectangleModel(
                                                        (ushort)score,
                                                        (byte)width,
                                                        (byte)height,
                                                        (byte)top.id,
                                                        (byte)(top.start - interlockWidth),
                                                        (byte)lengths[top.id],
                                                        (byte)bottom.id,
                                                        (byte)bottom.start,
                                                        (byte)lengths[bottom.id],
                                                        (byte)left.id,
                                                        (byte)left.start,
                                                        (byte)lengths[left.id],
                                                        (byte)_right,
                                                        (byte)_rightLetterPos,
                                                        (byte)lengths[_right],
                                                        (byte)interlockWidth,
                                                        (byte)interlockHeight,
                                                        RectangleType.bottomRight);

                                                    result.Add(rectangle);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static List<RectangleModel> BottomRightSquare(
            int interlockWidth,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            var result = new List<RectangleModel>();

            int interlockHeight = interlockWidth;

            int wordCount = words.Count;
            /*
                T
              Z R
            WHITE
              O E
             INN.
            */


            for (int _right = 0; _right < wordCount; _right++)
            {
                if (lengths[_right] >= interlockHeight)
                {
                    int _rightLetterPos = lengths[_right] - interlockHeight;

                    var topWords = letterIndex.find(words[_right][_rightLetterPos]);

                    foreach (var top in topWords)
                    {
                        if (top.start >= interlockWidth &&
                            top.id != _right)
                        {
                            var leftWords = letterIndex.find(words[top.id][top.start - interlockWidth]);

                            foreach (var left in leftWords)
                            {
                                if (left.end >= interlockHeight &&
                                    left.id > top.id && // Stops duplicates in squares
                                    left.id != _right)
                                {
                                    var bottomWords = letterIndex.find(words[left.id][left.start + interlockHeight]);

                                    foreach (var bottom in bottomWords)
                                    {
                                        if (bottom.end == interlockWidth - 1 &&
                                            bottom.id != left.id &&
                                            bottom.id != top.id &&
                                            bottom.id != _right)
                                        {
                                            int score = ScoreCalculator.bottomRight(
                                                words[left.id][left.start],
                                                words[top.id][top.start],
                                                words[bottom.id][bottom.start]);

                                            if (score >= scoreMin)
                                            {

                                                int width = CalculateWidth(
                                                    lengths[top.id],
                                                    lengths[bottom.id],
                                                    top.start - interlockWidth,
                                                    bottom.start);

                                                int height = CalculateWidth(
                                                    lengths[left.id],
                                                    lengths[_right],
                                                    left.start,
                                                    _rightLetterPos);

                                                if ((width <= widthMax && height <= heightMax) ||
                                                    (width <= heightMax && height <= widthMax))
                                                {

                                                    RectangleModel rectangle = new RectangleModel(
                                                        (ushort)score,
                                                        (byte)width,
                                                        (byte)height,
                                                        (byte)top.id,
                                                        (byte)(top.start - interlockWidth),
                                                        (byte)lengths[top.id],
                                                        (byte)bottom.id,
                                                        (byte)bottom.start,
                                                        (byte)lengths[bottom.id],
                                                        (byte)left.id,
                                                        (byte)left.start,
                                                        (byte)lengths[left.id],
                                                        (byte)_right,
                                                        (byte)_rightLetterPos,
                                                        (byte)lengths[_right],
                                                        (byte)interlockWidth,
                                                        (byte)interlockHeight,
                                                        RectangleType.bottomRight);

                                                    result.Add(rectangle);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static List<RectangleModel> TopRightSquare(
            int interlockWidth,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            int interlockHeight = interlockWidth;

            return TopRightRectangle(interlockWidth, interlockHeight, letterIndex, words, lengths, scoreMin, widthMax, heightMax);
        }

        public static List<RectangleModel> TopRightRectangle(
            int interlockWidth,
            int interlockHeight,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            if (interlockWidth > interlockHeight)
            {
                return new List<RectangleModel>();
            }
            return TopRightRectangleBase(interlockWidth, interlockHeight, letterIndex, words, lengths, scoreMin, widthMax, heightMax);
        }

        public static List<RectangleModel> BottomLeftRectangle(
            int interlockWidth,
            int interlockHeight,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            /*
                .
                H
              . O
           .HAZELNUT.
              I I
              O D
              N A
              .HYMN.
                .
            */


            if (interlockHeight <= interlockWidth)
            {
                return new List<RectangleModel>();
            }

            var result = new List<RectangleModel>();

            int wordCount = words.Count;

            for (int _bottom = 0; _bottom < wordCount; _bottom++)
            {
                if (lengths[_bottom] >= interlockWidth)
                {
                    int _bottomLetterPos = interlockWidth - 1;

                    var rightWords = letterIndex.find(words[_bottom][_bottomLetterPos]);

                    foreach (var right in rightWords)
                    {
                        if (right.start >= interlockHeight &&
                            right.id != _bottom)
                        {
                            var topWords = letterIndex.find(words[right.id][right.start - interlockHeight]);

                            foreach (var top in topWords)
                            {
                                if (top.start >= interlockWidth &&
                                    top.id != right.id &&
                                    top.id != _bottom)
                                {
                                    var leftWords = letterIndex.find(words[top.id][top.start - interlockWidth]);

                                    foreach (var left in leftWords)
                                    {
                                        if (left.end == interlockHeight - 1 &&
                                            left.id != top.id &&
                                            left.id != right.id &&
                                            left.id != _bottom)
                                        {
                                            int score = ScoreCalculator.bottomLeft(
                                                words[top.id][top.start - interlockWidth],
                                                words[top.id][top.start],
                                                words[_bottom][_bottomLetterPos]);

                                            if (score >= scoreMin)
                                            {

                                                int width = CalculateWidthIndented(
                                                    top.start - interlockWidth,
                                                    lengths[top.id],
                                                    lengths[_bottom]);

                                                int height = CalculateWidth(
                                                    lengths[left.id],
                                                    lengths[right.id],
                                                    left.start,
                                                    right.start - interlockHeight);

                                                if ((width <= widthMax && height <= heightMax) || (width <= heightMax && height <= widthMax))
                                                {
                                                    RectangleModel rectangle = new RectangleModel(
                                                        (ushort)score,
                                                        (byte)width,
                                                        (byte)height,
                                                        (byte)top.id,
                                                        (byte)(top.start - interlockWidth),
                                                        (byte)lengths[top.id],
                                                        (byte)_bottom,
                                                        (byte)_bottomLetterPos,
                                                        (byte)lengths[_bottom],
                                                        (byte)left.id,
                                                        (byte)left.start,
                                                        (byte)lengths[left.id],
                                                        (byte)right.id,
                                                        (byte)(right.start - interlockHeight),
                                                        (byte)lengths[right.id],
                                                        (byte)interlockWidth,
                                                        (byte)interlockHeight,
                                                        RectangleType.bottomLeft);

                                                    //print(donut.ToShape().ToTextDebug(words: words))
                                                    result.Add(rectangle);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static List<RectangleModel> TopRightRectangleBase(
            int interlockWidth,
            int interlockHeight,
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<int> lengths,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            var result = new List<RectangleModel>();

            int wordCount = words.Count;
            /*
               H
             TOYS.
               M A
               NAZARETH
                 U
                 R
                 E
            */


            //        if (interlockHeight < interlockWidth) {
            //            return result;
            //        }

            for (int _top = 0; _top < wordCount; _top++)
            {
                if (lengths[_top] >= interlockWidth)
                {
                    int _topLetterPos = lengths[_top] - interlockWidth;

                    var leftWords = letterIndex.find(words[_top][_topLetterPos]);

                    foreach (var left in leftWords)
                    {
                        if (left.end >= interlockHeight &&
                            left.id != _top)
                        {
                            var bottomWords = letterIndex.find(words[left.id][left.start + interlockHeight]);

                            foreach (var bottom in bottomWords)
                            {
                                if (bottom.end >= interlockWidth &&
                                    bottom.id != left.id &&
                                    bottom.id != _top)
                                {
                                    var rightWords = letterIndex.find(words[bottom.id][bottom.start + interlockWidth]);

                                    foreach (var right in rightWords)
                                    {
                                        if (right.start == interlockHeight - 1 &&
                                            right.id != bottom.id &&
                                            right.id != left.id &&
                                            right.id != _top)
                                        {
                                            int score = ScoreCalculator.topRight(
                                                    words[_top][_topLetterPos],
                                                    words[bottom.id][bottom.start],
                                                    words[bottom.id][bottom.start + interlockWidth]);

                                            if (score >= scoreMin)
                                            {
                                                int width = CalculateWidth(
                                                    lengths[_top],
                                                    lengths[bottom.id],
                                                    _topLetterPos,
                                                    bottom.start);

                                                int height = CalculateWidthIndented(
                                                    left.start,
                                                    lengths[left.id],
                                                    lengths[right.id]);

                                                if ((width <= widthMax && height <= heightMax) ||
                                                    (width <= heightMax && height <= widthMax))
                                                {

                                                    RectangleModel rectangle = new RectangleModel(
                                                        (ushort)score,
                                                        (byte)width,
                                                        (byte)height,
                                                        (byte)_top,
                                                        (byte)_topLetterPos,
                                                        (byte)lengths[_top],
                                                        (byte)bottom.id,
                                                        (byte)bottom.start,
                                                        (byte)lengths[bottom.id],
                                                        (byte)left.id,
                                                        (byte)left.start,
                                                        (byte)lengths[left.id],
                                                        (byte)right.id,
                                                        (byte)right.start,
                                                        (byte)lengths[right.id],
                                                        (byte)interlockWidth,
                                                        (byte)interlockHeight,
                                                        RectangleType.topRight);

                                                    result.Add(rectangle);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static List<RectangleModel> Execute(
            in List<string> words,
            int scoreMin,
            int widthMax,
            int heightMax)
        {

            var lengths = WordList.Lengths(words);
            var letterIndex = new LetterIndexModel(words);


            var d3x3 = Square(
                2,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            ////print("d3x3 \(d3x3.count)")

            var d3x4 = Rectangle(
                 2,
                 3,
                 letterIndex,
                 words,
                 lengths,
                 scoreMin,
                 widthMax,
                 heightMax);

            //print("d3x4 \(d3x4.count)")

            var d3x5 = Rectangle(
                2,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d3x5 \(d3x5.count)")

            var d3x6 = Rectangle(
                2,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d3x6 \(d3x6.count)")

            var d4x4 = Square(
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d4x4 \(d4x4.count)")

            var d4x5 = Rectangle(
                3,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d4x5 \(d4x5.count)")

            var d4x6 = Rectangle(
                3,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d4x6 \(d4x6.count)")

            var d5x5 = Square(
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d5x5 \(d5x5.count)")

            var d5x6 = Rectangle(
                4,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d5x6 \(d5x6.count)")

            var d6x6 = Square(
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("d6x6 \(d6x6.count)")

            var o3x3_BottomRight = BottomRightSquare(
                2,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x3_BottomRight \(o3x3_BottomRight.count)")

            var o3x3_TopLeft = TopLeftSquare(
                2,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x3_TopLeft \(o3x3_TopLeft.count)")

            var o3x3_TopRight = TopRightSquare(
                2,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x3_TopRight \(o3x3_TopRight.count)")

            var o3x4_BottomLeft = BottomLeftRectangle(
                2,
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x4_BottomLeft \(o3x4_BottomLeft.count)")

            var o3x4_BottomRight = BottomRightRectangle(
                2,
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x4_BottomRight \(o3x4_BottomRight.count)")

            var o3x4_TopLeft = TopLeftRectangle(
                2,
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x4_TopLeft \(o3x4_TopLeft.count)")

            var o3x4_TopRight = TopRightRectangle(
                2,
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x4_TopRight \(o3x4_TopRight.count)")

            var o3x5_BottomLeft = BottomLeftRectangle(
                2,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x5_BottomLeft \(o3x5_BottomLeft.count)")

            var o3x5_BottomRight = BottomRightRectangle(
                2,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x5_BottomRight \(o3x5_BottomRight.count)")

            var o3x5_TopLeft = TopLeftRectangle(
                2,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x5_TopLeft \(o3x5_TopLeft.count)")

            var o3x5_TopRight = TopRightRectangle(
                2,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x5_TopRight \(o3x5_TopRight.count)")

            var o3x6_BottomLeft = BottomLeftRectangle(
                2,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x6_BottomLeft \(o3x6_BottomLeft.count)")

            var o3x6_BottomRight = BottomRightRectangle(
                2,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x6_BottomRight \(o3x6_BottomRight.count)")

            var o3x6_TopLeft = TopLeftRectangle(
                2,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x6_TopLeft \(o3x6_TopLeft.count)")

            var o3x6_TopRight = TopRightRectangle(
                2,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o3x6_TopRight \(o3x6_TopRight.count)")

            var o4x4_BottomRight = BottomRightSquare(
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x4_BottomRight \(o4x4_BottomRight.count)")

            var o4x4_TopLeft = TopLeftSquare(
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x4_TopLeft \(o4x4_TopLeft.count)")

            var o4x4_TopRight = TopRightSquare(
                3,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x4_TopRight \(o4x4_TopRight.count)")

            var o4x5_BottomLeft = BottomLeftRectangle(
                3,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x5_BottomLeft \(o4x5_BottomLeft.count)")

            var o4x5_BottomRight = BottomRightRectangle(
                3,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x5_BottomRight \(o4x5_BottomRight.count)")

            var o4x5_TopLeft = TopLeftRectangle(
                3,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x5_TopLeft \(o4x5_TopLeft.count)")

            var o4x5_TopRight = TopRightRectangle(
                3,
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x5_TopRight \(o4x5_TopRight.count)")

            var o4x6_BottomLeft = BottomLeftRectangle(
                3,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x6_BottomLeft \(o4x6_BottomLeft.count)")

            var o4x6_BottomRight = BottomRightRectangle(
                3,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x6_BottomRight \(o4x6_BottomRight.count)")

            var o4x6_TopLeft = TopLeftRectangle(
                3,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x6_TopLeft \(o4x6_TopLeft.count)")

            var o4x6_TopRight = TopRightRectangle(
                3,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o4x6_TopRight \(o4x6_TopRight.count)")

            var o5x5_BottomRight = BottomRightSquare(
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o5x5_BottomRight \(o5x5_BottomRight.count)")

            var o5x5_TopLeft = TopLeftSquare(
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o5x5_TopLeft \(o5x5_TopLeft.count)")

            var o5x5_TopRight = TopRightSquare(
                4,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o5x5_TopRight \(o5x5_TopRight.count)")

            var o5x6_BottomLeft = BottomLeftRectangle(
                4,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o5x6_BottomLeft \(o5x6_BottomLeft.count)")

            var o5x6_BottomRight = BottomRightRectangle(
                4,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o5x6_BottomRight \(o5x6_BottomRight.count)")

            var o5x6_TopLeft = TopLeftRectangle(
                4,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o5x6_TopLeft \(o5x6_TopLeft.count)")

            var o5x6_TopRight = TopRightRectangle(
                4,
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o5x6_TopRight \(o5x6_TopRight.count)")

            var o6x6_BottomRight = BottomRightSquare(
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o6x6_BottomRight \(o6x6_BottomRight.count)")

            var o6x6_TopLeft = TopLeftSquare(
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o6x6_TopLeft \(o6x6_TopLeft.count)")

            var o6x6_TopRight = TopRightSquare(
                5,
                letterIndex,
                words,
                lengths,
                scoreMin,
                widthMax,
                heightMax);

            //print("o6x6_TopRight \(o6x6_TopRight.count)")


            var result = new List<RectangleModel>();

            result.AddRange(d3x3);
            result.AddRange(o3x3_TopLeft);
            result.AddRange(o3x3_TopRight);
            result.AddRange(o3x3_BottomRight);

            result.AddRange(d3x4);
            result.AddRange(o3x4_TopLeft);
            result.AddRange(o3x4_TopRight);
            result.AddRange(o3x4_BottomRight);
            result.AddRange(o3x4_BottomLeft);

            result.AddRange(d3x5);
            result.AddRange(o3x5_TopLeft);
            result.AddRange(o3x5_TopRight);
            result.AddRange(o3x5_BottomRight);
            result.AddRange(o3x5_BottomLeft);

            result.AddRange(d3x6);
            result.AddRange(o3x6_TopLeft);
            result.AddRange(o3x6_TopRight);
            result.AddRange(o3x6_BottomRight);
            result.AddRange(o3x6_BottomLeft);

            result.AddRange(d4x4);
            result.AddRange(o4x4_TopLeft);
            result.AddRange(o4x4_TopRight);
            result.AddRange(o4x4_BottomRight);

            result.AddRange(d4x5);
            result.AddRange(o4x5_TopLeft);
            result.AddRange(o4x5_TopRight);
            result.AddRange(o4x5_BottomRight);
            result.AddRange(o4x5_BottomLeft);

            result.AddRange(d4x6);
            result.AddRange(o4x6_TopLeft);
            result.AddRange(o4x6_TopRight);
            result.AddRange(o4x6_BottomRight);
            result.AddRange(o4x6_BottomLeft);

            result.AddRange(d5x5);
            result.AddRange(o5x5_TopLeft);
            result.AddRange(o5x5_TopRight);
            result.AddRange(o5x5_BottomRight);

            result.AddRange(d5x6);
            result.AddRange(o5x6_TopLeft);
            result.AddRange(o5x6_TopRight);
            result.AddRange(o5x6_BottomRight);
            result.AddRange(o5x6_BottomLeft);

            result.AddRange(d6x6);
            result.AddRange(o6x6_TopLeft);
            result.AddRange(o6x6_TopRight);
            result.AddRange(o6x6_BottomRight);

            return result;
        }




    }
}