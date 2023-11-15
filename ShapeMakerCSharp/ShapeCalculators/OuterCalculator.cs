using System;
using ShapeMakerCSharp;
using System.Diagnostics.Metrics;
using CrozzleInterfaces;

namespace ShapeMakerCSharp
{
    public class OuterCalculator
    {

        public static int ExecuteAllSerial(
            in List<GameModel> games,
            int scoreMin,
            bool includeBreakdown)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (includeBreakdown)
            {
                Console.WriteLine("Outer Shapes");
                Console.WriteLine("GameId, WinningWordShapes, AllWordShapes");
            }

            int shapesFromWordsCount = 0;
            int shapesFromWinningWordsCount = 0;

            foreach (var game in games)
            {
                var shapesFromWinningWords = Execute(game.winningWords, scoreMin, game.widthMax, game.heightMax);
                var shapesFromWords = Execute(game.words, scoreMin, game.widthMax, game.heightMax);

                if (includeBreakdown)
                {
                    Console.WriteLine($"{game.gameId}, {shapesFromWinningWords.Count}, {shapesFromWords.Count}");
                }

                shapesFromWordsCount += shapesFromWords.Count;
                shapesFromWinningWordsCount += shapesFromWinningWords.Count;
            }

            watch.Stop();

            Console.WriteLine($"OuterCalculator produced {shapesFromWinningWordsCount} winning words records and {shapesFromWordsCount} words records in {watch.ElapsedMilliseconds} ms\n");

            return shapesFromWordsCount;
        }

        public static List<ShapeModel> Execute(
            in List<string> words,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            var letterIndex = new LetterIndexModel(words);
            var end = WordCalculator.Reverse(words);
            var len = WordCalculator.Lengths(words);

            var c2x3 = C2x3(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
            var c2x4 = C2x4(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

            var result = new List<ShapeModel>();

            result.AddRange(c2x3);
            result.AddRange(c2x4);

            return result;
        }


        public static List<ShapeModel> C2x3(
        in LetterIndexModel letterIndex,
        in List<string> words,
        in List<string> end,
        in List<int> len,
        int scoreMin,
        int widthMax,
        int heightMax)
        {

            var LRL_MO = C2x3_LRL_MO(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
            var LRL_OM = C2x3_LRL_OM(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
            var RLR_MO = C2x3_RLR_MO(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
            var RLR_OM = C2x3_RLR_OM(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

            var result = new List<ShapeModel>();

            result.AddRange(LRL_MO);
            result.AddRange(LRL_OM);
            result.AddRange(RLR_MO);
            result.AddRange(RLR_OM);

            return result;
        }


        public static List<ShapeModel> C2x4(LetterIndexModel letterIndex, List<string> words, List<string> end, List<int> len, int scoreMin, int widthMax, int heightMax)
        {

            var LRLR_MO = C2x4_LRLR_MO(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
            var LRLR_OM = C2x4_LRLR_OM(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
            var RLRL_MO = C2x4_RLRL_MO(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
            var RLRL_OM = C2x4_RLRL_OM(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

            var result = new List<ShapeModel>();

            result.AddRange(LRLR_MO);
            result.AddRange(LRLR_OM);
            result.AddRange(RLRL_MO);
            result.AddRange(RLRL_OM);

            return result;
        }


        private static List<ShapeModel> C2x3_LRL_MO(
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<string> end,
            in List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {

            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 3;
            var result = new List<ShapeModel>();

            for (int _middle1 = 0; _middle1 < wordCount; _middle1++)
            {

                if (len[_middle1] == interlockHeight)
                {
                    //print("middle1: \(words[_middle1]), interlock:\(words[_middle1][0])")
                    var left1Words = letterIndex.find(words[_middle1][0]);
                    foreach (var left1 in left1Words)
                    {

                        if (left1.end == 1 && // end[left1][1] == words[_middle1][0] &&
                            len[left1.id] >= interlockWidth &&
                            left1.id != _middle1)
                        {

                            //print("left1: \(words[left1.id]), interlock:\(end[left1.id][0])")
                            for (int _outer2 = 0; _outer2 < wordCount; _outer2++)
                            {

                                if (len[_outer2] >= interlockHeight + 2 &&
                                    _outer2 != left1.id &&
                                    _outer2 != _middle1)
                                {

                                    //print("outer2:\(words[_outer2])")
                                    for (int outer2Pos = 1; outer2Pos < (len[_outer2] - interlockHeight); outer2Pos++)
                                    {

                                        if (words[_outer2][outer2Pos + 0] == end[left1.id][0])
                                        {

                                            //print("outer2:\(words[_outer2]), interlock:\(words[_middle1][1])")
                                            var right2Words = letterIndex.find(words[_middle1][1]);
                                            foreach (var right2 in right2Words)
                                            {

                                                if (right2.start == 0 && //words[right2.id][0] == words[_middle1][1] &&
                                                    len[right2.id] >= interlockWidth &&
                                                    words[right2.id][1] == words[_outer2][outer2Pos + 1] &&
                                                    right2.id != _outer2 &&
                                                    right2.id != left1.id &&
                                                    right2.id != _middle1)
                                                {

                                                    //print("right2:\(words[right2.id])")
                                                    //print("middle1: \(words[_middle1]), interlock:\(words[_middle1][2])")
                                                    var left3Words = letterIndex.find(words[_middle1][2]);
                                                    foreach (var left3 in left3Words)
                                                    {

                                                        if (left3.end == 1 && //end[left3.id][1] == words[_middle1][2] &&
                                                            len[left3.id] >= interlockWidth &&
                                                            end[left3.id][0] == words[_outer2][outer2Pos + 2] &&
                                                            left3.id != right2.id &&
                                                            left3.id != _outer2 &&
                                                            left3.id != left1.id &&
                                                            left3.id != _middle1)
                                                        {

                                                            var cluster = new OuterModel(
                                                                new List<int> { left1.id, right2.id, left3.id },
                                                                new List<int> { _middle1, _outer2 },
                                                                new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                words,
                                                                end,
                                                                len,
                                                                new List<int> { -1, outer2Pos });

                                                            if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                            {
                                                                result.Add(cluster.ToShape());
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
            }
            return result;
        }


        private static List<ShapeModel> C2x3_LRL_OM(
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<string> end,
            in List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 3;
            var result = new List<ShapeModel>();

            for (int _outer1 = 0; _outer1 < wordCount; _outer1++)
            {
                if (len[_outer1] >= interlockHeight + 2)
                {
                    for (int outer1Pos = 1; outer1Pos < (len[_outer1] - interlockHeight); outer1Pos++)
                    {
                        var left1Words = letterIndex.find(words[_outer1][outer1Pos]);

                        foreach (var left1 in left1Words)
                        {
                            if (left1.end == 1 &&//end[left1][1] == words[_outer1][outer1Pos + 0] &&
                                len[left1.id] >= interlockWidth &&
                                left1.id != _outer1)
                            {
                                var middle2Words = letterIndex.find(end[left1.id][0]);

                                foreach (var middle2 in middle2Words)
                                {
                                    if (middle2.start == 0 && //words[middle2][0] == end[left1][0] &&
                                        len[middle2.id] == interlockHeight &&
                                        middle2.id != left1.id &&
                                        middle2.id != _outer1)
                                    {
                                        var right2Words = letterIndex.find(words[_outer1][outer1Pos + 1]);

                                        foreach (var right2 in right2Words)
                                        {
                                            if (right2.start == 0 && //words[right2][0] == words[_outer1][outer1Pos + 1] &&
                                                len[right2.id] >= interlockWidth &&
                                                words[right2.id][1] == words[middle2.id][1] &&
                                                right2.id != middle2.id &&
                                                right2.id != left1.id &&
                                                right2.id != _outer1)
                                            {
                                                var left3Words = letterIndex.find(words[_outer1][outer1Pos + 2]);

                                                foreach (var left3 in left3Words)
                                                {
                                                    if (left3.end == 1 && //end[left3][1] == words[_outer1][outer1Pos + 2] &&
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][0] == words[middle2.id][2] &&
                                                        left3.id != right2.id &&
                                                        left3.id != middle2.id &&
                                                        left3.id != left1.id &&
                                                        left3.id != _outer1)
                                                    {
                                                        var cluster = new OuterModel(
                                                            new List<int> { left1.id, right2.id, left3.id },
                                                            new List<int> { _outer1, middle2.id },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                            words,
                                                            end,
                                                            len,
                                                            new List<int> { outer1Pos, -1 });

                                                        if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                        {
                                                            result.Add(cluster.ToShape());
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


        private static List<ShapeModel> C2x3_RLR_OM(
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<string> end,
            in List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {

            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 3;
            var result = new List<ShapeModel>();

            for (int _outer1 = 0; _outer1 < wordCount; _outer1++)
            {
                if (len[_outer1] >= interlockHeight + 2)
                {
                    for (int outer1Pos = 1; outer1Pos < (len[_outer1] - interlockHeight); outer1Pos++)
                    {
                        var right1Words = letterIndex.find(words[_outer1][outer1Pos + 0]);

                        foreach (var right1 in right1Words)
                        {
                            if (right1.start == 0 && //words[right1][0] == words[_outer1][outer1Pos + 0] &&
                                len[right1.id] >= interlockWidth &&
                                right1.id != _outer1)
                            {
                                var middle2Words = letterIndex.find(words[right1.id][1]);

                                foreach (var middle2 in middle2Words)
                                {
                                    if (middle2.start == 0 && //words[middle2][0] == words[right1][1] &&
                                        len[middle2.id] == interlockHeight &&
                                        middle2.id != right1.id &&
                                        middle2.id != _outer1)
                                    {
                                        var left2Words = letterIndex.find(words[middle2.id][1]);

                                        foreach (var left2 in left2Words)
                                        {
                                            if (left2.end == 0 && //end[left2][0] == words[middle2][1] &&
                                                len[left2.id] >= interlockWidth &&
                                                end[left2.id][1] == words[_outer1][outer1Pos + 1] &&
                                                left2.id != middle2.id &&
                                                left2.id != right1.id &&
                                                left2.id != _outer1)
                                            {
                                                var right3Words = letterIndex.find(words[middle2.id][2]);

                                                foreach (var right3 in right3Words)
                                                {
                                                    if (right3.start == 1 && //words[right3][1] == words[middle2][2] &&
                                                        len[right3.id] >= interlockWidth &&
                                                        words[right3.id][0] == words[_outer1][outer1Pos + 2] &&
                                                        right3.id != left2.id &&
                                                        right3.id != middle2.id &&
                                                        right3.id != right1.id &&
                                                        right3.id != _outer1)
                                                    {
                                                        var cluster = new OuterModel(
                                                            new List<int> { right1.id, left2.id, right3.id },
                                                            new List<int> { _outer1, middle2.id },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                            words,
                                                            end,
                                                            len,
                                                            new List<int> { outer1Pos, -1 });

                                                        if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                        {
                                                            result.Add(cluster.ToShape());
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


        private static List<ShapeModel> C2x3_RLR_MO(
            LetterIndexModel letterIndex,
            List<string> words,
            List<string> end,
            List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {

            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 3;
            var result = new List<ShapeModel>();

            for (int _middle1 = 0; _middle1 < wordCount; _middle1++)
            {
                if (len[_middle1] == interlockHeight)
                {
                    var right1Words = letterIndex.find(words[_middle1][0]);

                    foreach (var right1 in right1Words)
                    {
                        if (right1.start == 0 && //words[right1][0] == words[_middle1][0] &&
                            len[right1.id] >= interlockWidth &&
                            right1.id != _middle1)
                        {
                            for (int _outer2 = 0; _outer2 < wordCount; _outer2++)
                            {
                                if (len[_outer2] >= interlockHeight + 2 &&
                                    _outer2 != right1.id &&
                                    _outer2 != _middle1)
                                {
                                    for (int outer2Pos = 1; outer2Pos < (len[_outer2] - interlockHeight); outer2Pos++)
                                    {
                                        if (words[_outer2][outer2Pos + 0] == words[right1.id][1])
                                        {
                                            var left2Words = letterIndex.find(words[_outer2][outer2Pos + 1]);

                                            foreach (var left2 in left2Words)
                                            {
                                                if (left2.end == 0 && // end[left2][0] == words[outer2][outer2Pos + 1] &&
                                                    len[left2.id] >= interlockWidth &&
                                                    end[left2.id][1] == words[_middle1][1] &&
                                                    left2.id != _outer2 &&
                                                    left2.id != right1.id &&
                                                    left2.id != _middle1)
                                                {
                                                    var right3Words = letterIndex.find(words[_middle1][2]);

                                                    foreach (var right3 in right3Words)
                                                    {
                                                        if (right3.start == 0 && //words[right3][0] == words[_middle1][2] &&
                                                            len[right3.id] >= interlockWidth &&
                                                            words[right3.id][1] == words[_outer2][outer2Pos + 2] &&
                                                            right3.id != left2.id &&
                                                            right3.id != _outer2 &&
                                                            right3.id != right1.id &&
                                                            right3.id != _middle1)
                                                        {
                                                            var cluster = new OuterModel(
                                                                new List<int> { right1.id, left2.id, right3.id },
                                                                new List<int> { _middle1, _outer2 },
                                                                new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                words,
                                                                end,
                                                                len,
                                                                new List<int> { -1, outer2Pos });

                                                            if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                            {
                                                                result.Add(cluster.ToShape());
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
            }
            return result;
        }


        private static List<ShapeModel> C2x4_RLRL_MO(
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<string> end,
            in List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 4;
            var result = new List<ShapeModel>();

            for (int _middle1 = 0; _middle1 < wordCount; _middle1++)
            {
                if (len[_middle1] == interlockHeight)
                {
                    var right1Words = letterIndex.find(words[_middle1][0]);

                    foreach (var right1 in right1Words)
                    {
                        if (right1.start == 0 && //words[right1.id][0] == words[_middle1][0] &&
                            len[right1.id] >= interlockWidth &&
                            right1.id != _middle1)
                        {
                            for (int _outer2 = 0; _outer2 < wordCount; _outer2++)
                            {
                                if (len[_outer2] >= interlockHeight + 2 &&
                                    _outer2 != right1.id &&
                                    _outer2 != _middle1)
                                {
                                    for (int outer2Pos = 1; outer2Pos < (len[_outer2] - interlockHeight); outer2Pos++)
                                    {
                                        if (words[_outer2][outer2Pos + 0] == words[right1.id][1])
                                        {
                                            var left2Words = letterIndex.find(words[_outer2][outer2Pos + 1]);

                                            foreach (var left2 in left2Words)
                                            {
                                                if (left2.end == 0 && //end[left2.id][0] == words[outer2][outer2Pos + 1] &&
                                                    len[left2.id] >= interlockWidth &&
                                                    end[left2.id][1] == words[_middle1][1] &&
                                                    left2.id != _outer2 &&
                                                    left2.id != right1.id &&
                                                    left2.id != _middle1)
                                                {
                                                    var right3Words = letterIndex.find(words[_outer2][outer2Pos + 2]);

                                                    foreach (var right3 in right3Words)
                                                    {
                                                        if (right3.start == 1 && //words[right3.id][1] == words[outer2][outer2Pos + 2] &&
                                                           len[right3.id] >= interlockWidth &&
                                                            words[right3.id][0] == words[_middle1][2] &&
                                                            right3.id != left2.id &&
                                                            right3.id != _outer2 &&
                                                            right3.id != right1.id &&
                                                            right3.id != _middle1)
                                                        {
                                                            var left4Words = letterIndex.find(words[_outer2][outer2Pos + 3]);

                                                            foreach (var left4 in left4Words)
                                                            {
                                                                if (left4.end == 0 && //end[left4.id][0] == words[outer2][outer2Pos + 3] &&
                                                                    len[left4.id] >= interlockWidth &&
                                                                    end[left4.id][1] == words[_middle1][3] &&
                                                                    left4.id != right3.id &&
                                                                    left4.id != left2.id &&
                                                                    left4.id != _outer2 &&
                                                                    left4.id != right1.id &&
                                                                    left4.id != _middle1)
                                                                {
                                                                    var cluster = new OuterModel(
                                                                        new List<int> { right1.id, left2.id, right3.id, left4.id },
                                                                        new List<int> { _middle1, _outer2 },
                                                                        new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                        new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                        words,
                                                                        end,
                                                                        len,
                                                                        new List<int> { -1, outer2Pos });

                                                                    if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                                    {
                                                                        result.Add(cluster.ToShape());
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
                    }
                }
            }
            return result;
        }


        private static List<ShapeModel> C2x4_RLRL_OM(
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<string> end,
            in List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {

            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 4;
            var result = new List<ShapeModel>();

            for (int _outer1 = 0; _outer1 < wordCount; _outer1++)
            {
                if (len[_outer1] >= interlockHeight + 2)
                {
                    for (int outer1Pos = 1; outer1Pos < (len[_outer1] - interlockHeight); outer1Pos++)
                    {
                        var right1Words = letterIndex.find(words[_outer1][outer1Pos + 0]);

                        foreach (var right1 in right1Words)
                        {
                            if (right1.start == 0 && //words[right1.id][0] == words[_outer1][outer1Pos + 0] &&
                                len[right1.id] >= interlockWidth &&
                                right1.id != _outer1)
                            {
                                var middle2Words = letterIndex.find(words[right1.id][1]);

                                foreach (var middle2 in middle2Words)
                                {
                                    if (middle2.start == 0 && //words[middle2.id][0] == words[right1.id][1] &&
                                        len[middle2.id] == interlockHeight &&
                                        middle2.id != right1.id &&
                                        middle2.id != _outer1)
                                    {
                                        var left2Words = letterIndex.find(words[middle2.id][1]);

                                        foreach (var left2 in left2Words)
                                        {
                                            if (left2.end == 0 && //end[left2.id][0] == words[middle2.id][1] &&
                                                len[left2.id] >= interlockWidth &&
                                                end[left2.id][1] == words[_outer1][outer1Pos + 1] &&
                                                left2.id != middle2.id &&
                                                left2.id != right1.id &&
                                                left2.id != _outer1)
                                            {
                                                var right3Words = letterIndex.find(words[middle2.id][2]);

                                                foreach (var right3 in right3Words)
                                                {
                                                    if (right3.start == 1 && //words[right3.id][1] == words[middle2.id][2] &&
                                                         len[right3.id] >= interlockWidth &&
                                                         words[right3.id][0] == words[_outer1][outer1Pos + 2] &&
                                                         right3.id != left2.id &&
                                                         right3.id != middle2.id &&
                                                         right3.id != right1.id &&
                                                         right3.id != _outer1)
                                                    {
                                                        var left4Words = letterIndex.find(words[middle2.id][3]);

                                                        foreach (var left4 in left4Words)
                                                        {
                                                            if (left4.end == 0 && //end[left4.id][0] == words[middle2][3] &&
                                                                len[left4.id] >= interlockWidth &&
                                                                end[left4.id][1] == words[_outer1][outer1Pos + 3] &&
                                                                left4.id != right3.id &&
                                                                left4.id != left2.id &&
                                                                left4.id != middle2.id &&
                                                                left4.id != right1.id &&
                                                                left4.id != _outer1)
                                                            {
                                                                var cluster = new OuterModel(
                                                                    new List<int> { right1.id, left2.id, right3.id, left4.id },
                                                                    new List<int> { _outer1, middle2.id },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                    words,
                                                                    end,
                                                                    len,
                                                                    new List<int> { outer1Pos, -1 });

                                                                if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                                {
                                                                    result.Add(cluster.ToShape());
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
                }
            }
            return result;
        }


        private static List<ShapeModel> C2x4_LRLR_OM(
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<string> end,
            in List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {

            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 4;
            var result = new List<ShapeModel>();

            for (int _outer1 = 0; _outer1 < wordCount; _outer1++)
            {
                if (len[_outer1] >= interlockHeight + 2)
                {
                    for (int outer1Pos = 1; outer1Pos < (len[_outer1] - interlockHeight); outer1Pos++)
                    {
                        var left1Words = letterIndex.find(words[_outer1][outer1Pos + 0]);

                        foreach (var left1 in left1Words)
                        {
                            if (left1.end == 1 && //end[left1.id][1] == words[_outer1][outer1Pos + 0] &&
                                len[left1.id] >= interlockWidth &&
                                left1.id != _outer1)
                            {
                                var middle2Words = letterIndex.find(end[left1.id][0]);

                                foreach (var middle2 in middle2Words)
                                {
                                    if (middle2.start == 0 && //words[middle2.id][0] == end[left1.id][0] &&
                                        len[middle2.id] == interlockHeight &&
                                        middle2.id != left1.id &&
                                        middle2.id != _outer1)
                                    {
                                        var right2Words = letterIndex.find(words[middle2.id][1]);

                                        foreach (var right2 in right2Words)
                                        {
                                            if (right2.start == 1 && //words[right2.id][1] == words[middle2.id][1] &&
                                                len[right2.id] >= interlockWidth &&
                                                words[right2.id][0] == words[_outer1][outer1Pos + 1] &&
                                                right2.id != middle2.id &&
                                                right2.id != left1.id &&
                                                right2.id != _outer1)
                                            {
                                                var left3Words = letterIndex.find(words[middle2.id][2]);

                                                foreach (var left3 in left3Words)
                                                {
                                                    if (left3.end == 0 && //end[left3.id][0] == words[middle2.id][2] &&
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][1] == words[_outer1][outer1Pos + 2] &&
                                                        left3.id != right2.id &&
                                                        left3.id != middle2.id &&
                                                        left3.id != left1.id &&
                                                        left3.id != _outer1)
                                                    {
                                                        var right4Words = letterIndex.find(words[middle2.id][3]);

                                                        foreach (var right4 in right4Words)
                                                        {
                                                            if (right4.start == 1 && //words[right4.id][1] == words[middle2.id][3] &&
                                                                len[right4.id] >= interlockWidth &&
                                                                words[right4.id][0] == words[_outer1][outer1Pos + 3] &&
                                                                right4.id != left3.id &&
                                                                right4.id != right2.id &&
                                                                right4.id != middle2.id &&
                                                                right4.id != left1.id &&
                                                                right4.id != _outer1)
                                                            {
                                                                var cluster = new OuterModel(
                                                                    new List<int> { left1.id, right2.id, left3.id, right4.id },
                                                                    new List<int> { _outer1, middle2.id },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                    words,
                                                                    end,
                                                                    len,
                                                                    new List<int> { outer1Pos, -1 });

                                                                if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                                {
                                                                    result.Add(cluster.ToShape());
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
                }
            }
            return result;
        }


        private static List<ShapeModel> C2x4_LRLR_MO(
            in LetterIndexModel letterIndex,
            in List<string> words,
            in List<string> end,
            in List<int> len,
            int scoreMin,
            int widthMax,
            int heightMax)
        {
            int wordCount = (int)words.Count;
            int interlockWidth = 2;
            int interlockHeight = 4;
            var result = new List<ShapeModel>();

            for (int _middle1 = 0; _middle1 < wordCount; _middle1++)
            {
                if (len[_middle1] == interlockHeight)
                {
                    var left1Words = letterIndex.find(words[_middle1][0]);
                    foreach (var left1 in left1Words)
                    {
                        if (left1.end == 1 && //end[left1.id][1] == words[_middle1][0] &&
                            len[left1.id] >= interlockWidth &&
                            left1.id != _middle1)
                        {
                            for (int _outer2 = 0; _outer2 < wordCount; _outer2++)
                            {
                                if (len[_outer2] >= interlockHeight + 2 &&
                                    _outer2 != left1.id &&
                                    _outer2 != _middle1)
                                {
                                    for (int outer2Pos = 1; outer2Pos < (len[_outer2] - interlockHeight); outer2Pos++)
                                    {
                                        if (words[_outer2][outer2Pos + 0] == end[left1.id][0])
                                        {
                                            var right2Words = letterIndex.find(words[_outer2][outer2Pos + 1]);

                                            foreach (var right2 in right2Words)
                                            {
                                                if (right2.start == 1 && //words[right2.id][1] == words[outer2][outer2Pos + 1] &&
                                                    len[right2.id] >= interlockWidth &&
                                                    words[right2.id][0] == words[_middle1][1] &&
                                                    right2.id != _outer2 &&
                                                    right2.id != left1.id &&
                                                    right2.id != _middle1)
                                                {
                                                    var left3Words = letterIndex.find(words[_middle1][2]);

                                                    foreach (var left3 in left3Words)
                                                    {
                                                        if (left3.end == 1 && // end[left3.id][1] == words[_middle1][2] &&
                                                            len[left3.id] >= interlockWidth &&
                                                            end[left3.id][0] == words[_outer2][outer2Pos + 2] &&
                                                            left3.id != right2.id &&
                                                            left3.id != _outer2 &&
                                                            left3.id != left1.id &&
                                                            left3.id != _middle1)
                                                        {
                                                            var right4Words = letterIndex.find(words[_middle1][3]);

                                                            foreach (var right4 in right4Words)
                                                            {
                                                                if (right4.start == 0 && //words[right4.id][0] == words[_middle1][3] &&
                                                                    len[right4.id] >= interlockWidth &&
                                                                    words[right4.id][1] == words[_outer2][outer2Pos + 3] &&
                                                                    right4.id != left3.id &&
                                                                    right4.id != right2.id &&
                                                                    right4.id != _outer2 &&
                                                                    right4.id != left1.id &&
                                                                    right4.id != _middle1)
                                                                {
                                                                    var cluster = new OuterModel(
                                                                        new List<int> { left1.id, right2.id, left3.id, right4.id },
                                                                        new List<int> { _middle1, _outer2 },
                                                                        new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                        new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                        words,
                                                                        end,
                                                                        len,
                                                                        new List<int> { -1, outer2Pos });

                                                                    if (cluster.isValid(scoreMin, widthMax, heightMax))
                                                                    {
                                                                        result.Add(cluster.ToShape());
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
                    }
                }
            }
            return result;
        }
    }
}

