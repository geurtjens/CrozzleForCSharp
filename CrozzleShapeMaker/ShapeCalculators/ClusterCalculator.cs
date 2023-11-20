using CrozzleInterfaces;

namespace CrozzleShapeMaker;

public class ClusterCalculator
{


    public static int ExecuteAllSerial(
        in List<GameModel> games,
        int scoreMin,
        bool includeBreakdown)
    {

        var watch = System.Diagnostics.Stopwatch.StartNew();
        int shapesFromWordsCount = 0;
        int shapesFromWinningWordsCount = 0;
        if (includeBreakdown) { 
            Console.WriteLine("Cluster Shapes");
            Console.WriteLine("GameId, WinningWordShapes, AllWordShapes");
        }
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

        Console.WriteLine($"ClusterCalculator produced {shapesFromWinningWordsCount} winning words records and {shapesFromWordsCount} words records in {watch.ElapsedMilliseconds} ms\n");

        return shapesFromWordsCount;
    }


    public static List<ShapeModel> Execute(
        List<string> words,
        int scoreMin,
        int widthMax,
        int heightMax)
    {

        var letterIndex = new LetterIndexModel(words);
        var end = WordList.Reversed(words);
        var len = WordList.Lengths(words);

        var c2x2 = C2x2(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x3 = C2x3(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x4 = C2x4(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x5 = C2x5(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x6 = C2x6(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var c3x3 = C3x3(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x4 = C3x4(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x5 = C3x5(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c2x2);
        result.AddRange(c2x3);
        result.AddRange(c2x4);
        result.AddRange(c2x5);
        result.AddRange(c2x6);

        result.AddRange(c3x3);
        result.AddRange(c3x4);
        result.AddRange(c3x5);

        return result;
    }


    public static List<ShapeModel> C2x2(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        var c2x2_LR_UD = C2x2_LR_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x2_RL_DU = C2x2_RL_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x2_RL_UD = C2x2_RL_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c2x2_LR_UD);
        result.AddRange(c2x2_RL_DU);
        result.AddRange(c2x2_RL_UD);

        return result;
    }


    public static List<ShapeModel> C2x3(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        var c2x3_LRL_DU = C2x3_LRL_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x3_LRL_UD = C2x3_LRL_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x3_RLR_DU = C2x3_RLR_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x3_RLR_UD = C2x3_RLR_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c2x3_LRL_DU);
        result.AddRange(c2x3_LRL_UD);
        result.AddRange(c2x3_RLR_DU);
        result.AddRange(c2x3_RLR_UD);

        return result;
    }


    public static List<ShapeModel> C2x4(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        var c2x4_LRLR_DU = C2x4_LRLR_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x4_LRLR_UD = C2x4_LRLR_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x4_RLRL_DU = C2x4_RLRL_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x4_RLRL_UD = C2x4_RLRL_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c2x4_LRLR_DU);
        result.AddRange(c2x4_LRLR_UD);
        result.AddRange(c2x4_RLRL_DU);
        result.AddRange(c2x4_RLRL_UD);

        return result;
    }


    public static List<ShapeModel> C2x5(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        var c2x5_LRLRL_DU = C2x5_LRLRL_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x5_LRLRL_UD = C2x5_LRLRL_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x5_RLRLR_DU = C2x5_RLRLR_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x5_RLRLR_UD = C2x5_RLRLR_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c2x5_LRLRL_DU);
        result.AddRange(c2x5_LRLRL_UD);
        result.AddRange(c2x5_RLRLR_DU);
        result.AddRange(c2x5_RLRLR_UD);

        return result;
    }


    public static List<ShapeModel> C2x6(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        var c2x6_LRLRLR_DU = C2x6_LRLRLR_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x6_LRLRLR_UD = C2x6_LRLRLR_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x6_RLRLRL_DU = C2x6_RLRLRL_DU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c2x6_RLRLRL_UD = C2x6_RLRLRL_UD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c2x6_LRLRLR_DU);
        result.AddRange(c2x6_LRLRLR_UD);
        result.AddRange(c2x6_RLRLRL_DU);
        result.AddRange(c2x6_RLRLRL_UD);

        return result;
    }


    public static List<ShapeModel> C3x3(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        var c3x3_LRL_UDU = C3x3_LRL_UDU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x3_RLR_DUD = C3x3_RLR_DUD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x3_RLR_UDU = C3x3_RLR_UDU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c3x3_LRL_UDU);
        result.AddRange(c3x3_RLR_DUD);
        result.AddRange(c3x3_RLR_UDU);

        return result;
    }


    public static List<ShapeModel> C3x4(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        var c3x4_LRLR_DUD = C3x4_LRLR_DUD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x4_LRLR_UDU = C3x4_LRLR_UDU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x4_RLRL_DUD = C3x4_RLRL_DUD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x4_RLRL_UDU = C3x4_RLRL_UDU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c3x4_LRLR_DUD);
        result.AddRange(c3x4_LRLR_UDU);
        result.AddRange(c3x4_RLRL_DUD);
        result.AddRange(c3x4_RLRL_UDU);

        return result;
    }


    public static List<ShapeModel> C3x5(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        var c3x5_LRLRL_DUD = C3x5_LRLRL_DUD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x5_LRLRL_UDU = C3x5_LRLRL_UDU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x5_RLRLR_DUD = C3x5_RLRLR_DUD(letterIndex, words, end, len, scoreMin, widthMax, heightMax);
        var c3x5_RLRLR_UDU = C3x5_RLRLR_UDU(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

        var result = new List<ShapeModel>();

        result.AddRange(c3x5_LRLRL_DUD);
        result.AddRange(c3x5_LRLRL_UDU);
        result.AddRange(c3x5_RLRLR_DUD);
        result.AddRange(c3x5_RLRLR_UDU);

        return result;
    }


    private static List<ShapeModel> C2x2_LR_UD(
        in LetterIndexModel letterIndex,
        in List<string> words,
        in List<string> end,
        in List<int> len,
        int scoreMin,
        int widthMax,
        int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 2;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(end[_up1][1]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 &&
                        len[left1.id] >= interlockWidth &&
                        left1.id > _up1)
                    {
                        var down2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][0] &&

                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {
                                        var cluster = new ClusterModel(
                                            new List<int> { left1.id, right2.id },
                                            new List<int> { _up1, down2.id },
                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                            words, end, len
                                        );

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
        return result;
    }


    private static List<ShapeModel> C2x2_RL_DU(
        in LetterIndexModel letterIndex,
        in List<string> words,
        in List<string> end,
        in List<int> len,
        int scoreMin,
        int widthMax,
        int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 2;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _down1)
                    {
                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 1 &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != right1.id &&
                                up2.id != _down1)
                            {
                                var left2Words = letterIndex.find(end[up2.id][0]);

                                // This is where I put the (up2+1)
                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 &&
                                        left2.id > up2.id && // To avoid duplicates we assure that left is higher than up
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {
                                        var cluster = new ClusterModel(
                                            new List<int> { right1.id, left2.id }, // We could put id here if needed
                                            new List<int> { _down1, up2.id },
                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                            words, end, len);

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
        return result;
    }


    // This one does not need duplicate removal
    private static List<ShapeModel> C2x2_RL_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 2;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(end[_up1][1]);

                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {
                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == end[_up1][0] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {
                                        var cluster = new ClusterModel(
                                            new List<int> { right1.id, left2.id }, // We could put id here if needed
                                            new List<int> { _up1, down2.id },
                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                            words, end, len);

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
        return result;
    }


    private static List<ShapeModel> C2x3_LRL_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 3;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(words[_down1][0]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _down1)
                    {
                        var up2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 2 &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != left1.id &&
                                up2.id != _down1)
                            {
                                var right2Words = letterIndex.find(end[up2.id][1]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == words[_down1][1] &&
                                        right2.id != up2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _down1)
                                    {
                                        var left3Words = letterIndex.find(words[_down1][2]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 1 &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == words[_down1][2] &&
                                                end[left3.id][0] == end[up2.id][0] &&
                                                left3.id != right2.id &&
                                                left3.id != up2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _down1)
                                            {
                                                var cluster = new ClusterModel(
                                                    new List<int> { left1.id, right2.id, left3.id },
                                                    new List<int> { _down1, up2.id },
                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                    words, end, len);

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
        return result;
    }


    private static List<ShapeModel> C2x3_LRL_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 3;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(end[_up1][2]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _up1)
                    {
                        var down2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][1] &&
                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {
                                        var left3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 0 &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == end[_up1][0] &&
                                                left3.id != right2.id &&
                                                left3.id != down2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _up1)
                                            {
                                                var cluster = new ClusterModel(
                                                    new List<int> { left1.id, right2.id, left3.id },
                                                    new List<int> { _up1, down2.id },
                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                    words, end, len);

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
        return result;
    }


    private static List<ShapeModel> C2x3_RLR_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 3;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _down1)
                    {
                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 2 &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != right1.id &&
                                up2.id != _down1)
                            {
                                var left2Words = letterIndex.find(end[up2.id][1]);

                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {
                                        var right3Words = letterIndex.find(end[up2.id][0]);

                                        foreach (var right3 in right3Words)
                                        {
                                            if (right3.start == 1 &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == words[_down1][2] &&
                                                right3.id != left2.id &&
                                                right3.id != up2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _down1)
                                            {
                                                var cluster = new ClusterModel(
                                                    new List<int> { right1.id, left2.id, right3.id },
                                                    new List<int> { _down1, up2.id },
                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                    words, end, len);

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
        return result;
    }


    private static List<ShapeModel> C2x3_RLR_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 3;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(end[_up1][2]);
                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {
                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == end[_up1][1] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {
                                        var right3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var right3 in right3Words)
                                        {
                                            if (right3.start == 1 &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == end[_up1][0] &&
                                                right3.id != left2.id &&
                                                right3.id != down2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _up1)
                                            {
                                                var cluster = new ClusterModel(
                                                    new List<int> { right1.id, left2.id, right3.id },
                                                    new List<int> { _up1, down2.id },
                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                    words, end, len);

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
        return result;
    }


    private static List<ShapeModel> C2x4_LRLR_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(words[_down1][0]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _down1)
                    {
                        var up2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 3 &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != left1.id &&
                                up2.id != _down1)
                            {
                                var right2Words = letterIndex.find(end[up2.id][2]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == words[_down1][1] &&
                                        right2.id != up2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _down1)
                                    {
                                        var left3Words = letterIndex.find(end[up2.id][1]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 0 &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == words[_down1][2] &&
                                                left3.id != right2.id &&
                                                left3.id != up2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _down1)
                                            {
                                                var right4Words = letterIndex.find(end[up2.id][0]);

                                                foreach (var right4 in right4Words)
                                                {
                                                    if (right4.start == 1 &&
                                                        len[right4.id] >= interlockWidth &&
                                                        words[right4.id][0] == words[_down1][3] &&
                                                        right4.id != left3.id &&
                                                        right4.id != right2.id &&
                                                        right4.id != up2.id &&
                                                        right4.id != left1.id &&
                                                        right4.id != _down1)
                                                    {
                                                        var cluster = new ClusterModel(
                                                            new List<int> { left1.id, right2.id, left3.id, right4.id },
                                                            new List<int> { _down1, up2.id },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                            words, end, len);

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


    private static List<ShapeModel> C2x4_LRLR_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(end[_up1][3]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _up1)
                    {
                        var down2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][2] &&
                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {
                                        var left3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 0 &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == end[_up1][1] &&
                                                left3.id != right2.id &&
                                                left3.id != down2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _up1)
                                            {
                                                var right4Words = letterIndex.find(words[down2.id][3]);

                                                foreach (var right4 in right4Words)
                                                {
                                                    if (right4.start == 1 &&
                                                        len[right4.id] >= interlockWidth &&
                                                        words[right4.id][0] == end[_up1][0] &&
                                                        right4.id != left3.id &&
                                                        right4.id != right2.id &&
                                                        right4.id != down2.id &&
                                                        right4.id != left1.id &&
                                                        right4.id != _up1)
                                                    {
                                                        var cluster = new ClusterModel(
                                                            new List<int> { left1.id, right2.id, left3.id, right4.id },
                                                            new List<int> { _up1, down2.id },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                            words, end, len);

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


    private static List<ShapeModel> C2x4_RLRL_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _down1)
                    {
                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 3 &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != right1.id &&
                                up2.id != _down1)
                            {
                                var left2Words = letterIndex.find(end[up2.id][2]);

                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {
                                        var right3Words = letterIndex.find(end[up2.id][1]);

                                        foreach (var right3 in right3Words)
                                        {
                                            if (right3.start == 1 &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == words[_down1][2] &&
                                                right3.id != left2.id &&
                                                right3.id != up2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _down1)
                                            {
                                                var left4Words = letterIndex.find(end[up2.id][0]);

                                                foreach (var left4 in left4Words)
                                                {
                                                    if (left4.end == 0 &&
                                                        len[left4.id] >= interlockWidth &&
                                                        end[left4.id][1] == words[_down1][3] &&
                                                        left4.id != right3.id &&
                                                        left4.id != left2.id &&
                                                        left4.id != up2.id &&
                                                        left4.id != right1.id &&
                                                        left4.id != _down1)
                                                    {
                                                        var cluster = new ClusterModel(
                                                            new List<int> { right1.id, left2.id, right3.id, left4.id },
                                                            new List<int> { _down1, up2.id },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                            words, end, len);

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


    private static List<ShapeModel> C2x4_RLRL_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(end[_up1][3]);

                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {
                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 && //words[down2.id][0] == words[right1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 && //end[left2.id][0] == words[down2.id][1] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == end[_up1][2] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {
                                        var right3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var right3 in right3Words)
                                        {
                                            if (right3.start == 1 && //words[right3.id][1] == words[down2.id][2] &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == end[_up1][1] &&
                                                right3.id != left2.id &&
                                                right3.id != down2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _up1)
                                            {
                                                var left4Words = letterIndex.find(words[down2.id][3]);

                                                foreach (var left4 in left4Words)
                                                {
                                                    if (left4.end == 0 && //end[left4.id][0] == words[down2.id][3] &&
                                                        len[left4.id] >= interlockWidth &&
                                                        end[left4.id][1] == end[_up1][0] &&
                                                        left4.id != right3.id &&
                                                        left4.id != left2.id &&
                                                        left4.id != down2.id &&
                                                        left4.id != right1.id &&
                                                        left4.id != _up1)
                                                    {
                                                        var cluster = new ClusterModel(
                                                            new List<int> { right1.id, left2.id, right3.id, left4.id },
                                                            new List<int> { _up1, down2.id },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                            words, end, len);

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


    private static List<ShapeModel> C2x5_LRLRL_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(words[_down1][0]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 && //end[left1.id][1] == words[_down1][0] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _down1)
                    {
                        var up2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 4 && //end[up2.id][4] == end[left1.id][0] &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != left1.id &&
                                up2.id != _down1)
                            {
                                var right2Words = letterIndex.find(end[up2.id][3]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 && //words[right2.id][1] == end[up2.id][3] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == words[_down1][1] &&
                                        right2.id != up2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _down1)
                                    {
                                        var left3Words = letterIndex.find(end[up2.id][2]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 0 && //end[left3.id][0] == end[up2.id][2] &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == words[_down1][2] &&
                                                left3.id != right2.id &&
                                                left3.id != up2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _down1)
                                            {
                                                var right4Words = letterIndex.find(end[up2.id][1]);

                                                foreach (var right4 in right4Words)
                                                {
                                                    if (right4.start == 1 && //words[right4.id][1] == end[up2.id][1] &&
                                                        len[right4.id] >= interlockWidth &&
                                                        words[right4.id][0] == words[_down1][3] &&
                                                        right4.id != left3.id &&
                                                        right4.id != right2.id &&
                                                        right4.id != up2.id &&
                                                        right4.id != left1.id &&
                                                        right4.id != _down1)
                                                    {
                                                        var left5Words = letterIndex.find(end[up2.id][0]);

                                                        foreach (var left5 in left5Words)
                                                        {
                                                            if (left5.end == 0 && //end[left5.id][0] == end[up2.id][0] &&
                                                                len[left5.id] >= interlockWidth &&
                                                                end[left5.id][1] == words[_down1][4] &&
                                                                left5.id != right4.id &&
                                                                left5.id != left3.id &&
                                                                left5.id != right2.id &&
                                                                left5.id != up2.id &&
                                                                left5.id != left1.id &&
                                                                left5.id != _down1)
                                                            {
                                                                var cluster = new ClusterModel(
                                                                    new List<int> { left1.id, right2.id, left3.id, right4.id, left5.id },
                                                                    new List<int> { _down1, up2.id },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                    words, end, len);

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


    private static List<ShapeModel> C2x5_LRLRL_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(end[_up1][4]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 && //end[left1.id][1] == end[_up1][4] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _up1)
                    {
                        var down2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 && //words[down2.id][0] == end[left1.id][0] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 && //words[right2.id][1] == words[down2.id][1] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][3] &&
                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {
                                        var left3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 0 && //end[left3.id][0] == words[down2.id][2] &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == end[_up1][2] &&
                                                left3.id != right2.id &&
                                                left3.id != down2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _up1)
                                            {
                                                var right4Words = letterIndex.find(words[down2.id][3]);

                                                foreach (var right4 in right4Words)
                                                {
                                                    if (right4.start == 1 && //words[right4.id][1] == words[down2.id][3] &&
                                                        len[right4.id] >= interlockWidth &&
                                                        words[right4.id][0] == end[_up1][1] &&
                                                        right4.id != left3.id &&
                                                        right4.id != right2.id &&
                                                        right4.id != down2.id &&
                                                        right4.id != left1.id &&
                                                        right4.id != _up1)
                                                    {
                                                        var left5Words = letterIndex.find(words[down2.id][4]);

                                                        foreach (var left5 in left5Words)
                                                        {
                                                            if (left5.end == 0 && //end[left5.id][0] == words[down2.id][4] &&
                                                                len[left5.id] >= interlockWidth &&
                                                                end[left5.id][1] == end[_up1][0] &&
                                                                left5.id != right4.id &&
                                                                left5.id != left3.id &&
                                                                left5.id != right2.id &&
                                                                left5.id != down2.id &&
                                                                left5.id != left1.id &&
                                                                left5.id != _up1)
                                                            {
                                                                var cluster = new ClusterModel(
                                                                    new List<int> { left1.id, right2.id, left3.id, right4.id, left5.id },
                                                                    new List<int> { _up1, down2.id },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                                    words, end, len);

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


    private static List<ShapeModel> C2x5_RLRLR_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 && //words[right1.id][0] == words[_down1][0] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _down1)
                    {
                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 4 && //end[up2.id][4] == words[right1.id][1] &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != right1.id &&
                                up2.id != _down1)
                            {
                                var left2Words = letterIndex.find(end[up2.id][3]);

                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 && //end[left2.id][0] == end[up2.id][3] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {
                                        var right3Words = letterIndex.find(end[up2.id][2]);

                                        foreach (var right3 in right3Words)
                                        {
                                            if (right3.start == 1 && //words[right3.id][1] == end[up2.id][2] &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == words[_down1][2] &&
                                                right3.id != left2.id &&
                                                right3.id != up2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _down1)
                                            {
                                                var left4Words = letterIndex.find(end[up2.id][1]);

                                                foreach (var left4 in left4Words)
                                                {
                                                    if (left4.end == 0 && //end[left4.id][0] == end[up2.id][1] &&
                                                        len[left4.id] >= interlockWidth &&
                                                        end[left4.id][1] == words[_down1][3] &&
                                                        left4.id != right3.id &&
                                                        left4.id != left2.id &&
                                                        left4.id != up2.id &&
                                                        left4.id != right1.id &&
                                                        left4.id != _down1)
                                                    {
                                                        var right5Words = letterIndex.find(end[up2.id][0]);

                                                        foreach (var right5 in right5Words)
                                                        {
                                                            if (right5.start == 1 && //words[right5.id][1] == end[up2.id][0] &&
                                                                len[right5.id] >= interlockWidth &&
                                                                words[right5.id][0] == words[_down1][4] &&
                                                                right5.id != left4.id &&
                                                                right5.id != right3.id &&
                                                                right5.id != left2.id &&
                                                                right5.id != up2.id &&
                                                                right5.id != right1.id &&
                                                                right5.id != _down1)
                                                            {
                                                                var cluster = new ClusterModel(
                                                                    new List<int> { right1.id, left2.id, right3.id, left4.id, right5.id },
                                                                    new List<int> { _down1, up2.id },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                    words, end, len);

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


    private static List<ShapeModel> C2x5_RLRLR_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var right1Words = letterIndex.find(end[_up1][4]);

                foreach (var right1 in right1Words)
                {
                    if (right1.start == 0 && //words[right1.id][0] == end[_up1][4] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {
                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 && //words[down2.id][0] == words[right1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {
                                    if (left2.end == 0 && //end[left2.id][0] == words[down2.id][1] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == end[_up1][3] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {
                                        var right3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var right3 in right3Words)
                                        {
                                            if (right3.start == 1 && //words[right3.id][1] == words[down2.id][2] &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == end[_up1][2] &&
                                                right3.id != left2.id &&
                                                right3.id != down2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _up1)
                                            {
                                                var left4Words = letterIndex.find(words[down2.id][3]);

                                                foreach (var left4 in left4Words)
                                                {
                                                    if (left4.end == 0 && //end[left4.id][0] == words[down2.id][3] &&
                                                        len[left4.id] >= interlockWidth &&
                                                        end[left4.id][1] == end[_up1][1] &&
                                                        left4.id != right3.id &&
                                                        left4.id != left2.id &&
                                                        left4.id != down2.id &&
                                                        left4.id != right1.id &&
                                                        left4.id != _up1)
                                                    {
                                                        var right5Words = letterIndex.find(words[down2.id][4]);

                                                        foreach (var right5 in right5Words)
                                                        {
                                                            if (right5.start == 1 && //words[right5.id][1] == words[down2.id][4] &&
                                                                len[right5.id] >= interlockWidth &&
                                                                words[right5.id][0] == end[_up1][0] &&
                                                                right5.id != left4.id &&
                                                                right5.id != right3.id &&
                                                                right5.id != left2.id &&
                                                                right5.id != down2.id &&
                                                                right5.id != right1.id &&
                                                                right5.id != _up1)
                                                            {
                                                                var cluster = new ClusterModel(
                                                                    new List<int> { right1.id, left2.id, right3.id, left4.id, right5.id },
                                                                    new List<int> { _up1, down2.id },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                                    words, end, len);

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


    private static List<ShapeModel> C2x6_LRLRLR_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 6;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {
            if (len[_down1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(words[_down1][0]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 && //end[left1.id][1] == words[_down1][0] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _down1)
                    {
                        var up2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var up2 in up2Words)
                        {
                            if (up2.id != left1.id &&
                                len[up2.id] >= interlockHeight &&
                                up2.end == 5 && //end[up2.id][5] == end[left1.id][0] &&
                                up2.id != _down1)
                            {
                                var right2Words = letterIndex.find(end[up2.id][4]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 && //words[right2.id][1] == end[up2.id][4] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == words[_down1][1] &&
                                        right2.id != up2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _down1)
                                    {
                                        var left3Words = letterIndex.find(end[up2.id][3]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 0 && //end[left3.id][0] == end[up2.id][3] &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == words[_down1][2] &&
                                                left3.id != right2.id &&
                                                left3.id != up2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _down1)
                                            {
                                                var right4Words = letterIndex.find(end[up2.id][2]);

                                                foreach (var right4 in right4Words)
                                                {
                                                    if (right4.start == 1 && //words[right4.id][1] == end[up2.id][2] &&
                                                        len[right4.id] >= interlockWidth &&
                                                        words[right4.id][0] == words[_down1][3] &&
                                                        right4.id != left3.id &&
                                                        right4.id != right2.id &&
                                                        right4.id != up2.id &&
                                                        right4.id != left1.id &&
                                                        right4.id != _down1)
                                                    {
                                                        var left5Words = letterIndex.find(end[up2.id][1]);

                                                        foreach (var left5 in left5Words)
                                                        {
                                                            if (left5.end == 0 && //end[left5.id][0] == end[up2.id][1] &&
                                                                len[left5.id] >= interlockWidth &&
                                                                end[left5.id][1] == words[_down1][4] &&
                                                                left5.id != right4.id &&
                                                                left5.id != left3.id &&
                                                                left5.id != right2.id &&
                                                                left5.id != up2.id &&
                                                                left5.id != left1.id &&
                                                                left5.id != _down1)
                                                            {
                                                                var right6Words = letterIndex.find(end[up2.id][0]);

                                                                foreach (var right6 in right6Words)
                                                                {
                                                                    if (right6.start == 1 && //words[right6.id][1] == end[up2.id][0] &&
                                                                        len[right6.id] >= interlockWidth &&
                                                                        words[right6.id][0] == words[_down1][5] &&
                                                                        right6.id != left5.id &&
                                                                        right6.id != right4.id &&
                                                                        right6.id != left3.id &&
                                                                        right6.id != right2.id &&
                                                                        right6.id != up2.id &&
                                                                        right6.id != left1.id &&
                                                                        right6.id != _down1)
                                                                    {
                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { left1.id, right2.id, left3.id, right4.id, left5.id, right6.id },
                                                                            new List<int> { _down1, up2.id },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


    private static List<ShapeModel> C2x6_LRLRLR_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 6;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {
            if (len[_up1] >= interlockHeight)
            {
                var left1Words = letterIndex.find(end[_up1][5]);

                foreach (var left1 in left1Words)
                {
                    if (left1.end == 1 && //end[left1.id][1] == end[_up1][5] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _up1)
                    {
                        var down2Words = letterIndex.find(end[left1.id][0]);

                        foreach (var down2 in down2Words)
                        {
                            if (down2.start == 0 && //words[down2.id][0] == end[left1.id][0] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 && //words[right2.id][1] == words[down2.id][1] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][4] &&
                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {
                                        var left3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var left3 in left3Words)
                                        {
                                            if (left3.end == 0 && //end[left3.id][0] == words[down2.id][2] &&
                                                len[left3.id] >= interlockWidth &&
                                                end[left3.id][1] == end[_up1][3] &&
                                                left3.id != right2.id &&
                                                left3.id != down2.id &&
                                                left3.id != left1.id &&
                                                left3.id != _up1)
                                            {
                                                var right4Words = letterIndex.find(words[down2.id][3]);

                                                foreach (var right4 in right4Words)
                                                {
                                                    if (right4.start == 1 && //words[right4.id][1] == words[down2.id][3] &&
                                                        len[right4.id] >= interlockWidth &&
                                                        words[right4.id][0] == end[_up1][2] &&
                                                        right4.id != left3.id &&
                                                        right4.id != right2.id &&
                                                        right4.id != down2.id &&
                                                        right4.id != left1.id &&
                                                        right4.id != _up1)
                                                    {
                                                        var left5Words = letterIndex.find(words[down2.id][4]);

                                                        foreach (var left5 in left5Words)
                                                        {
                                                            if (left5.end == 0 && //end[left5.id][0] == words[down2.id][4] &&
                                                                len[left5.id] >= interlockWidth &&
                                                                end[left5.id][1] == end[_up1][1] &&
                                                                left5.id != right4.id &&
                                                                left5.id != left3.id &&
                                                                left5.id != right2.id &&
                                                                left5.id != down2.id &&
                                                                left5.id != left1.id &&
                                                                left5.id != _up1)
                                                            {
                                                                var right6Words = letterIndex.find(words[down2.id][5]);

                                                                foreach (var right6 in right6Words)
                                                                {
                                                                    if (right6.start == 1 && //words[right6.id][1] == words[down2.id][5] &&
                                                                        len[right6.id] >= interlockWidth &&
                                                                        words[right6.id][0] == end[_up1][0] &&
                                                                        right6.id != left5.id &&
                                                                        right6.id != right4.id &&
                                                                        right6.id != left3.id &&
                                                                        right6.id != right2.id &&
                                                                        right6.id != down2.id &&
                                                                        right6.id != left1.id &&
                                                                        right6.id != _up1)
                                                                    {
                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { left1.id, right2.id, left3.id, right4.id, left5.id, right6.id },
                                                                            new List<int> { _up1, down2.id },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


    private static List<ShapeModel> C2x6_RLRLRL_DU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 6;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {

            if (len[_down1] >= interlockHeight)
            {


                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == words[_down1][0] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _down1)
                    {


                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {

                            if (up2.id != right1.id &&
                                len[up2.id] >= interlockHeight &&
                                up2.end == 5 && //end[up2.id][5] == words[right1.id][1] &&
                                up2.id != _down1)
                            {


                                var left2Words = letterIndex.find(end[up2.id][4]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 0 && //end[left2.id][0] == end[up2.id][4] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {


                                        var right3Words = letterIndex.find(end[up2.id][3]);

                                        foreach (var right3 in right3Words)
                                        {

                                            if (right3.start == 1 && //words[right3.id][1] == end[up2.id][3] &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == words[_down1][2] &&
                                                right3.id != left2.id &&
                                                right3.id != up2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _down1)
                                            {

                                                //print("right3:\(words[right3.id]), interlock: \(end[up2.id][2])")
                                                var left4Words = letterIndex.find(end[up2.id][2]);

                                                foreach (var left4 in left4Words)
                                                {

                                                    if (left4.end == 0 && //end[left4.id][0] == end[up2.id][2] &&
                                                        len[left4.id] >= interlockWidth &&
                                                        end[left4.id][1] == words[_down1][3] &&
                                                        left4.id != right3.id &&
                                                        left4.id != left2.id &&
                                                        left4.id != up2.id &&
                                                        left4.id != right1.id &&
                                                        left4.id != _down1)
                                                    {

                                                        //print("left4:\(words[left4.id]), interlock: \(end[up2.id][1])")
                                                        var right5Words = letterIndex.find(end[up2.id][1]);

                                                        foreach (var right5 in right5Words)
                                                        {

                                                            if (right5.start == 1 && //words[right5.id][1] == end[up2.id][1] &&
                                                                len[right5.id] >= interlockWidth &&
                                                                words[right5.id][0] == words[_down1][4] &&
                                                                right5.id != left4.id &&
                                                                right5.id != right3.id &&
                                                                right5.id != left2.id &&
                                                                right5.id != up2.id &&
                                                                right5.id != right1.id &&
                                                                right5.id != _down1)
                                                            {

                                                                //print("right5:\(words[right5.id]), interlock: \(end[up2.id][0])")
                                                                var left6Words = letterIndex.find(end[up2.id][0]);

                                                                foreach (var left6 in left6Words)
                                                                {

                                                                    if (left6.end == 0 && //end[left6.id][0] == end[up2.id][0] &&
                                                                        len[left6.id] >= interlockWidth &&
                                                                        end[left6.id][1] == words[_down1][5] &&
                                                                        left6.id != right5.id &&
                                                                        left6.id != left4.id &&
                                                                        left6.id != right3.id &&
                                                                        left6.id != left2.id &&
                                                                        left6.id != up2.id &&
                                                                        left6.id != right1.id &&
                                                                        left6.id != _down1)
                                                                    {

                                                                        //print("left6:\(words[left6.id])")

                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { right1.id, left2.id, right3.id, left4.id, right5.id, left6.id },
                                                                            new List<int> { _down1, up2.id },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


    private static List<ShapeModel> C2x6_RLRLRL_UD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 2;
        int interlockHeight = 6;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {

            if (len[_up1] >= interlockHeight)
            {

                //print("up1:\(words[_up1]), interlock: \(end[_up1][5])")
                var right1Words = letterIndex.find(end[_up1][5]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == end[_up1][5] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {


                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 && //words[down2.id][0] == words[right1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {

                                //print("down2:\(words[down2.id]), interlock: \(words[down2.id][1])")
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 0 && //end[left2.id][0] == words[down2.id][1] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][1] == end[_up1][4] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {

                                        //print("left2:\(words[left2.id]), interlock: \(words[down2.id][2])")
                                        var right3Words = letterIndex.find(words[down2.id][2]);

                                        foreach (var right3 in right3Words)
                                        {

                                            if (right3.start == 1 && //words[right3.id][1] == words[down2.id][2] &&
                                                len[right3.id] >= interlockWidth &&
                                                words[right3.id][0] == end[_up1][3] &&
                                                right3.id != left2.id &&
                                                right3.id != down2.id &&
                                                right3.id != right1.id &&
                                                right3.id != _up1)
                                            {

                                                //print("right3:\(words[right3.id]), interlock: \(words[down2.id][3])")
                                                var left4Words = letterIndex.find(words[down2.id][3]);

                                                foreach (var left4 in left4Words)
                                                {

                                                    if (left4.end == 0 && //end[left4.id][0] == words[down2.id][3] &&
                                                        len[left4.id] >= interlockWidth &&
                                                        end[left4.id][1] == end[_up1][2] &&
                                                        left4.id != right3.id &&
                                                        left4.id != left2.id &&
                                                        left4.id != down2.id &&
                                                        left4.id != right1.id &&
                                                        left4.id != _up1)
                                                    {

                                                        //print("left4:\(words[left4.id]), interlock: \(words[down2.id][4])")
                                                        var right5Words = letterIndex.find(words[down2.id][4]);

                                                        foreach (var right5 in right5Words)
                                                        {

                                                            if (right5.start == 1 && //words[right5.id][1] == words[down2.id][4] &&
                                                                len[right5.id] >= interlockWidth &&
                                                                words[right5.id][0] == end[_up1][1] &&
                                                                right5.id != left4.id &&
                                                                right5.id != right3.id &&
                                                                right5.id != left2.id &&
                                                                right5.id != down2.id &&
                                                                right5.id != right1.id &&
                                                                right5.id != _up1)
                                                            {

                                                                //print("right5:\(words[right5.id]), interlock: \(words[down2.id][5])")
                                                                var left6Words = letterIndex.find(words[down2.id][5]);

                                                                foreach (var left6 in left6Words)
                                                                {

                                                                    if (left6.end == 0 && //end[left6.id][0] == words[down2.id][5] &&
                                                                        len[left6.id] >= interlockWidth &&
                                                                        end[left6.id][1] == end[_up1][0] &&
                                                                        left6.id != right5.id &&
                                                                        left6.id != left4.id &&
                                                                        left6.id != right3.id &&
                                                                        left6.id != left2.id &&
                                                                        left6.id != down2.id &&
                                                                        left6.id != right1.id &&
                                                                        left6.id != _up1)
                                                                    {

                                                                        //print("left6:\(words[left6.id])")

                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { right1.id, left2.id, right3.id, left4.id, right5.id, left6.id },
                                                                            new List<int> { _up1, down2.id },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


    private static List<ShapeModel> C3x3_LRL_UDU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 3;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {

            if (len[_up1] >= interlockHeight)
            {

                //print("up1:\(words[_up1]), interlock: \(end[_up1][2])")
                var left1Words = letterIndex.find(end[_up1][2]);

                foreach (var left1 in left1Words)
                {

                    if (left1.end == 2 && //end[left1.id][2] == end[_up1][2] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id > _up1)
                    {

                        //print("left1:\(words[left1.id]), interlock: \(end[left1.id][1])")
                        var down2Words = letterIndex.find(end[left1.id][1]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 && //words[down2.id][0] == end[left1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {

                                //print("down2:\(words[down2.id]), interlock: \(words[down2.id][1])")
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {

                                    if (right2.start == 1 && //words[right2.id][1] == words[down2.id][1] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][1] &&
                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {

                                        //print("right2:\(words[right2.id]), interlock: \(words[right2.id][2])")
                                        var up3Words = letterIndex.find(words[right2.id][2]);

                                        foreach (var up3 in up3Words)
                                        {

                                            if (up3.end == 1 && //end[up3.id][1] == words[right2.id][2] &&
                                                len[up3.id] >= interlockHeight &&
                                                end[up3.id][2] == end[left1.id][0] &&
                                                up3.id != right2.id &&
                                                up3.id != down2.id &&
                                                up3.id != left1.id &&
                                                up3.id != _up1)
                                            {

                                                //print("up3:\(words[up3.id]), interlock: \(end[up3.id][0])")
                                                var left3Words = letterIndex.find(end[up3.id][0]);

                                                foreach (var left3 in left3Words)
                                                {

                                                    if (left3.end == 0 && //end[left3.id][0] == end[up3.id][0] &&
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][2] == end[_up1][0] &&
                                                        end[left3.id][1] == words[down2.id][2] &&
                                                        left3.id != up3.id &&
                                                        left3.id != right2.id &&
                                                        left3.id != down2.id &&
                                                        left3.id != left1.id &&
                                                        left3.id != _up1)
                                                    {

                                                        //print("left3:\(words[left3.id])")

                                                        var cluster = new ClusterModel(
                                                            new List<int> { left1.id, right2.id, left3.id },
                                                            new List<int> { _up1, down2.id, up3.id },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                            words, end, len);

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


    private static List<ShapeModel> C3x3_RLR_DUD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 3;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {

            if (len[_down1] >= interlockHeight)
            {


                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == words[_down1][0] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id > _down1)
                    {


                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {

                            if (up2.end == 2 && //end[up2.id][2] == words[right1.id][1] &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != right1.id &&
                                up2.id != _down1)
                            {

                                //print("up2:\(words[up2.id]), interlock: \(end[up2.id][1])")
                                var left2Words = letterIndex.find(end[up2.id][1]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 1 && //end[left2.id][1] == end[up2.id][1] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][2] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {

                                        //print("left2:\(words[left2.id]), interlock: \(end[left2.id][0])")
                                        var down3Words = letterIndex.find(end[left2.id][0]);

                                        foreach (var down3 in down3Words)
                                        {

                                            if (down3.start == 1 && //words[down3.id][1] == end[left2.id][0] &&
                                                len[down3.id] >= interlockHeight &&
                                                words[down3.id][0] == words[right1.id][2] &&
                                                down3.id != left2.id &&
                                                down3.id != up2.id &&
                                                down3.id != right1.id &&
                                                down3.id != _down1)
                                            {

                                                //print("down3:\(words[down3.id]), interlock: \(words[down3.id][2])")
                                                var right3Words = letterIndex.find(words[down3.id][2]);

                                                foreach (var right3 in right3Words)
                                                {

                                                    if (right3.start == 2 && //words[right3.id][2] == words[down3.id][2] &&
                                                        len[right3.id] >= interlockWidth &&
                                                        words[right3.id][0] == words[_down1][2] &&
                                                        words[right3.id][1] == end[up2.id][0] &&
                                                        right3.id != down3.id &&
                                                        right3.id != left2.id &&
                                                        right3.id != up2.id &&
                                                        right3.id != right1.id &&
                                                        right3.id != _down1)
                                                    {

                                                        //print("right3:\(words[right3.id])")

                                                        var cluster = new ClusterModel(
                                                            new List<int> { right1.id, left2.id, right3.id },
                                                            new List<int> { _down1, up2.id, down3.id },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                            words, end, len);

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


    // Does not require duplicate checking as it forms a different shape LRL_DUD so we also exclude LRL_DUD as this provides LRL_DUD also
    private static List<ShapeModel> C3x3_RLR_UDU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 3;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {

            if (len[_up1] >= interlockHeight)
            {

                //print("up1:\(words[_up1]), interlock: \(end[_up1][2])")
                var right1Words = letterIndex.find(end[_up1][2]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == end[_up1][2] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {


                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 && //words[down2.id][0] == words[right1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {

                                //print("down2:\(words[down2.id]), interlock: \(words[down2.id][1])")
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 1 && //end[left2.id][1] == words[down2.id][1] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][2] == end[_up1][1] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {

                                        //print("left2:\(words[left2.id]), interlock: \(end[left2.id][0])")
                                        var up3Words = letterIndex.find(end[left2.id][0]);

                                        foreach (var up3 in up3Words)
                                        {

                                            if (up3.end == 1 && //end[up3.id][1] == end[left2.id][0] &&
                                                len[up3.id] >= interlockHeight &&
                                                end[up3.id][2] == words[right1.id][2] &&
                                                up3.id != left2.id &&
                                                up3.id != down2.id &&
                                                up3.id != right1.id &&
                                                up3.id != _up1)
                                            {

                                                //print("up3:\(words[up3.id]), interlock: \(end[up3.id][0])")
                                                var right3Words = letterIndex.find(end[up3.id][0]);

                                                foreach (var right3 in right3Words)
                                                {

                                                    if (right3.start == 2 && //words[right3.id][2] == end[up3.id][0] &&
                                                        len[right3.id] >= interlockWidth &&
                                                        words[right3.id][0] == end[_up1][0] &&
                                                        words[right3.id][1] == words[down2.id][2] &&
                                                        right3.id != up3.id &&
                                                        right3.id != left2.id &&
                                                        right3.id != down2.id &&
                                                        right3.id != right1.id &&
                                                        right3.id != _up1)
                                                    {

                                                        //print("right3:\(words[right3.id])")

                                                        var cluster = new ClusterModel(
                                                            new List<int> { right1.id, left2.id, right3.id },
                                                            new List<int> { _up1, down2.id, up3.id },
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                            words, end, len);

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


    private static List<ShapeModel> C3x4_LRLR_DUD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {

            if (len[_down1] >= interlockHeight)
            {


                var left1Words = letterIndex.find(words[_down1][0]);

                foreach (var left1 in left1Words)
                {

                    if (left1.end == 2 && //end[left1.id][2] == words[_down1][0] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _down1)
                    {

                        //print("left1:\(words[left1.id]), interlock: \(end[left1.id][1])")
                        var up2Words = letterIndex.find(end[left1.id][1]);

                        foreach (var up2 in up2Words)
                        {

                            if (up2.end == 3 && //end[up2.id][3] == end[left1.id][1] &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != left1.id &&
                                up2.id != _down1)
                            {

                                //print("up2:\(words[up2.id]), interlock: \(end[up2.id][2])")
                                var right2Words = letterIndex.find(end[up2.id][2]);

                                foreach (var right2 in right2Words)
                                {

                                    if (right2.start == 1 && //words[right2.id][1] == end[up2.id][2] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == words[_down1][1] &&
                                        right2.id != up2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _down1)
                                    {

                                        //print("right2:\(words[right2.id]), interlock: \(words[right2.id][2])")
                                        var down3Words = letterIndex.find(words[right2.id][2]);

                                        foreach (var down3 in down3Words)
                                        {

                                            if (down3.start == 1 && //words[down3.id][1] == words[right2.id][2] &&
                                                len[down3.id] >= interlockHeight &&
                                                words[down3.id][0] == end[left1.id][0] &&
                                                down3.id != right2.id &&
                                                down3.id != up2.id &&
                                                down3.id != left1.id &&
                                                down3.id != _down1)
                                            {

                                                //print("down3:\(words[down3.id]), interlock: \(words[down3.id][2])")
                                                var left3Words = letterIndex.find(words[down3.id][2]);

                                                foreach (var left3 in left3Words)
                                                {

                                                    if (left3.end == 0 && //end[left3.id][0] == words[down3.id][2] &&
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][2] == words[_down1][2] &&
                                                        end[left3.id][1] == end[up2.id][1] &&
                                                        left3.id != down3.id &&
                                                        left3.id != right2.id &&
                                                        left3.id != up2.id &&
                                                        left3.id != left1.id &&
                                                        left3.id != _down1)
                                                    {

                                                        //print("left3:\(words[left3.id]), interlock: \(words[down3.id][3])")
                                                        var right4Words = letterIndex.find(words[down3.id][3]);

                                                        foreach (var right4 in right4Words)
                                                        {

                                                            if (right4.start == 2 && //words[right4.id][2] == words[down3.id][3] &&
                                                                len[right4.id] >= interlockWidth &&
                                                                words[right4.id][0] == words[_down1][3] &&
                                                                words[right4.id][1] == end[up2.id][0] &&
                                                                right4.id != left3.id &&
                                                                right4.id != down3.id &&
                                                                right4.id != right2.id &&
                                                                right4.id != up2.id &&
                                                                right4.id != left1.id &&
                                                                right4.id != _down1)
                                                            {

                                                                //print("right4:\(words[right4.id])")

                                                                var cluster = new ClusterModel(
                                                                    new List<int> { left1.id, right2.id, left3.id, right4.id },
                                                                    new List<int> { _down1, up2.id, down3.id },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                    words, end, len);

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


    private static List<ShapeModel> C3x4_RLRL_DUD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {

            if (len[_down1] >= interlockHeight)
            {


                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == words[_down1][0] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _down1)
                    {


                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {

                            if (up2.end == 3 && //end[up2.id][3] == words[right1.id][1] &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != right1.id &&
                                up2.id != _down1)
                            {

                                //print("up2:\(words[up2.id]), interlock: \(end[up2.id][2])")
                                var left2Words = letterIndex.find(end[up2.id][2]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 1 && //end[left2.id][1] == end[up2.id][2] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][2] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {

                                        //print("left2:\(words[left2.id]), interlock: \(end[left2.id][0])")
                                        var down3Words = letterIndex.find(end[left2.id][0]);

                                        foreach (var down3 in down3Words)
                                        {

                                            if (down3.start == 1 && //words[down3.id][1] == end[left2.id][0] &&
                                                len[down3.id] >= interlockHeight &&
                                                words[down3.id][0] == words[right1.id][2] &&
                                                down3.id != left2.id &&
                                                down3.id != up2.id &&
                                                down3.id != right1.id &&
                                                down3.id != _down1)
                                            {

                                                //print("down3:\(words[down3.id]), interlock: \(words[down3.id][2])")
                                                var right3Words = letterIndex.find(words[down3.id][2]);

                                                foreach (var right3 in right3Words)
                                                {

                                                    if (right3.start == 2 && //words[right3.id][2] == words[down3.id][2] &&
                                                        len[right3.id] >= interlockWidth &&
                                                        words[right3.id][0] == words[_down1][2] &&
                                                        words[right3.id][1] == end[up2.id][1] &&
                                                        right3.id != down3.id &&
                                                        right3.id != left2.id &&
                                                        right3.id != up2.id &&
                                                        right3.id != right1.id &&
                                                        right3.id != _down1)
                                                    {

                                                        //print("right3:\(words[right3.id])")
                                                        //print("down3:\(words[down3.id]), interlock: \(words[down3.id][3])")
                                                        var left4Words = letterIndex.find(words[down3.id][3]);

                                                        foreach (var left4 in left4Words)
                                                        {

                                                            if (left4.end == 0 && //end[left4.id][0] == words[down3.id][3] &&
                                                                len[left4.id] >= interlockWidth &&
                                                                end[left4.id][2] == words[_down1][3] &&
                                                                end[left4.id][1] == end[up2.id][0] &&
                                                                left4.id != right3.id &&
                                                                left4.id != down3.id &&
                                                                left4.id != left2.id &&
                                                                left4.id != up2.id &&
                                                                left4.id != right1.id &&
                                                                left4.id != _down1)
                                                            {

                                                                //print("left4:\(words[left4.id])")

                                                                var cluster = new ClusterModel(
                                                                    new List<int> { right1.id, left2.id, right3.id, left4.id },
                                                                    new List<int> { _down1, up2.id, down3.id },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                    words, end, len);

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


    private static List<ShapeModel> C3x4_LRLR_UDU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();


        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {

            if (len[_up1] >= interlockHeight)
            {

                //print("up1:\(words[_up1]), interlock: \(end[_up1][3])")
                var left1Words = letterIndex.find(end[_up1][3]);

                foreach (var left1 in left1Words)
                {

                    if (left1.end == 2 && //end[left1.id][2] == end[_up1][3] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _up1)
                    {

                        //print("left1:\(words[left1.id]), interlock: \(end[left1.id][1])")
                        var down2Words = letterIndex.find(end[left1.id][1]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 && //words[down2.id][0] == end[left1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {

                                //print("down2:\(words[down2.id]), interlock: \(words[down2.id][1])")
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {

                                    if (right2.start == 1 && //words[right2.id][1] == words[down2.id][1] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][2] &&
                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {

                                        //print("right2:\(words[right2.id]), interlock: \(words[right2.id][2])")
                                        var up3Words = letterIndex.find(words[right2.id][2]);

                                        foreach (var up3 in up3Words)
                                        {

                                            if (up3.end == 2 && //end[up3.id][2] == words[right2.id][2] &&
                                                len[up3.id] >= interlockHeight &&
                                                end[up3.id][3] == end[left1.id][0] &&
                                                up3.id != right2.id &&
                                                up3.id != down2.id &&
                                                up3.id != left1.id &&
                                                up3.id != _up1)
                                            {

                                                //print("up3:\(words[up3.id]), interlock: \(end[up3.id][1])")
                                                var left3Words = letterIndex.find(end[up3.id][1]);

                                                foreach (var left3 in left3Words)
                                                {

                                                    if (left3.end == 0 && //end[left3.id][0] == end[up3.id][1] &&
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][2] == end[_up1][1] &&
                                                        end[left3.id][1] == words[down2.id][2] &&
                                                        left3.id != up3.id &&
                                                        left3.id != right2.id &&
                                                        left3.id != down2.id &&
                                                        left3.id != left1.id &&
                                                        left3.id != _up1)
                                                    {

                                                        //print("left3:\(words[left3.id]), interlock: \(end[up3.id][0])")
                                                        var right4Words = letterIndex.find(end[up3.id][0]);

                                                        foreach (var right4 in right4Words)
                                                        {

                                                            if (right4.start == 2 && //words[right4.id][2] == end[up3.id][0] &&
                                                                len[right4.id] >= interlockWidth &&
                                                                words[right4.id][0] == end[_up1][0] &&
                                                                words[right4.id][1] == words[down2.id][3] &&
                                                                right4.id != left3.id &&
                                                                right4.id != up3.id &&
                                                                right4.id != right2.id &&
                                                                right4.id != down2.id &&
                                                                right4.id != left1.id &&
                                                                right4.id != _up1)
                                                            {

                                                                //print("right4:\(words[right4.id])")

                                                                var cluster = new ClusterModel(
                                                                    new List<int> { left1.id, right2.id, left3.id, right4.id },
                                                                    new List<int> { _up1, down2.id, up3.id },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                    words, end, len);

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


    private static List<ShapeModel> C3x4_RLRL_UDU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 4;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {

            if (len[_up1] >= interlockHeight)
            {

                //print("up1:\(words[_up1]), interlock: \(end[_up1][3])")
                var right1Words = letterIndex.find(end[_up1][3]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == end[_up1][3] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {


                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 && //words[down2.id][0] == words[right1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {

                                //print("down2:\(words[down2.id]), interlock: \(words[down2.id][1])")
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 1 && //end[left2.id][1] == words[down2.id][1] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][2] == end[_up1][2] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {

                                        //print("left2:\(words[left2.id]), interlock: \(end[left2.id][0])")
                                        var up3Words = letterIndex.find(end[left2.id][0]);

                                        foreach (var up3 in up3Words)
                                        {

                                            if (up3.end == 2 && //end[up3.id][2] == end[left2.id][0] &&
                                                len[up3.id] >= interlockHeight &&
                                                end[up3.id][3] == words[right1.id][2] &&
                                                up3.id != left2.id &&
                                                up3.id != down2.id &&
                                                up3.id != right1.id &&
                                                up3.id != _up1)
                                            {

                                                //print("up3:\(words[up3.id]), interlock: \(end[up3.id][1])")
                                                var right3Words = letterIndex.find(end[up3.id][1]);

                                                foreach (var right3 in right3Words)
                                                {

                                                    if (right3.start == 2 && //words[right3.id][2] == end[up3.id][1] &&
                                                        len[right3.id] >= interlockWidth &&
                                                        words[right3.id][0] == end[_up1][1] &&
                                                        words[right3.id][1] == words[down2.id][2] &&
                                                        right3.id != up3.id &&
                                                        right3.id != left2.id &&
                                                        right3.id != down2.id &&
                                                        right3.id != right1.id &&
                                                        right3.id != _up1)
                                                    {

                                                        //print("right3:\(words[right3.id]), interlock: \(end[up3.id][0])")
                                                        var left4Words = letterIndex.find(end[up3.id][0]);

                                                        foreach (var left4 in left4Words)
                                                        {

                                                            if (left4.end == 0 && //end[left4.id][0] == end[up3.id][0] &&
                                                                len[left4.id] >= interlockWidth &&
                                                                end[left4.id][2] == end[_up1][0] &&
                                                                end[left4.id][1] == words[down2.id][3] &&
                                                                left4.id != right3.id &&
                                                                left4.id != up3.id &&
                                                                left4.id != left2.id &&
                                                                left4.id != down2.id &&
                                                                left4.id != right1.id &&
                                                                left4.id != _up1)
                                                            {

                                                                //print("left4:\(words[left4.id])")

                                                                var cluster = new ClusterModel(
                                                                    new List<int> { right1.id, left2.id, right3.id, left4.id },
                                                                    new List<int> { _up1, down2.id, up3.id },
                                                                    new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                    new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                    words, end, len);

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


    private static List<ShapeModel> C3x5_LRLRL_DUD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {

            if (len[_down1] >= interlockHeight)
            {


                var left1Words = letterIndex.find(words[_down1][0]);

                foreach (var left1 in left1Words)
                {

                    if (left1.end == 2 && //end[left1.id][2] == words[_down1][0] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _down1)
                    {

                        //print("left1:\(words[left1.id]), interlock: \(end[left1.id][1])")
                        var up2Words = letterIndex.find(end[left1.id][1]);

                        foreach (var up2 in up2Words)
                        {

                            if (up2.end == 4 && //end[up2.id][4] == end[left1.id][1] &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != left1.id &&
                                up2.id != _down1)
                            {

                                //print("up2:\(words[up2.id]), interlock: \(end[up2.id][3])")
                                var right2Words = letterIndex.find(end[up2.id][3]);

                                foreach (var right2 in right2Words)
                                {

                                    if (right2.start == 1 && //words[right2.id][1] == end[up2.id][3] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == words[_down1][1] &&
                                        right2.id != up2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _down1)
                                    {

                                        //print("right2:\(words[right2.id]), interlock: \(words[right2.id][2])")
                                        var down3Words = letterIndex.find(words[right2.id][2]);

                                        foreach (var down3 in down3Words)
                                        {

                                            if (down3.start == 1 && //words[down3.id][1] == words[right2.id][2] &&
                                                len[down3.id] >= interlockHeight &&
                                                words[down3.id][0] == end[left1.id][0] &&
                                                down3.id != right2.id &&
                                                down3.id != up2.id &&
                                                down3.id != left1.id &&
                                                down3.id != _down1)
                                            {

                                                //print("down3:\(words[down3.id]), interlock: \(words[down3.id][2])")
                                                var left3Words = letterIndex.find(words[down3.id][2]);

                                                foreach (var left3 in left3Words)
                                                {

                                                    if (left3.end == 0 && //end[left3.id][0] == words[down3.id][2] &&
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][2] == words[_down1][2] &&
                                                        end[left3.id][1] == end[up2.id][2] &&
                                                        left3.id != down3.id &&
                                                        left3.id != right2.id &&
                                                        left3.id != up2.id &&
                                                        left3.id != left1.id &&
                                                        left3.id != _down1)
                                                    {

                                                        //print("left3:\(words[left3.id]), interlock: \(words[down3.id][3])")
                                                        var right4Words = letterIndex.find(words[down3.id][3]);

                                                        foreach (var right4 in right4Words)
                                                        {

                                                            if (right4.start == 2 && //words[right4.id][2] == words[down3.id][3] &&
                                                                len[right4.id] >= interlockWidth &&
                                                                words[right4.id][0] == words[_down1][3] &&
                                                                words[right4.id][1] == end[up2.id][1] &&
                                                                right4.id != left3.id &&
                                                                right4.id != down3.id &&
                                                                right4.id != right2.id &&
                                                                right4.id != up2.id &&
                                                                right4.id != left1.id &&
                                                                right4.id != _down1)
                                                            {

                                                                //print("right4:\(words[right4.id]), interlock: \(words[down3.id][4])")
                                                                var left5Words = letterIndex.find(words[down3.id][4]);

                                                                foreach (var left5 in left5Words)
                                                                {

                                                                    if (left5.end == 0 && //end[left5.id][0] == words[down3.id][4] &&
                                                                        len[left5.id] >= interlockWidth &&
                                                                        end[left5.id][2] == words[_down1][4] &&
                                                                        end[left5.id][1] == end[up2.id][0] &&
                                                                        left5.id != right4.id &&
                                                                        left5.id != left3.id &&
                                                                        left5.id != down3.id &&
                                                                        left5.id != right2.id &&
                                                                        left5.id != up2.id &&
                                                                        left5.id != left1.id &&
                                                                        left5.id != _down1)
                                                                    {

                                                                        //print("left5:\(words[left5.id])")

                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { left1.id, right2.id, left3.id, right4.id, left5.id },
                                                                            new List<int> { _down1, up2.id, down3.id },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


    private static List<ShapeModel> C3x5_LRLRL_UDU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {

            if (len[_up1] >= interlockHeight)
            {

                //print("up1:\(words[_up1]), interlock: \(end[_up1][4])")
                var left1Words = letterIndex.find(end[_up1][4]);

                foreach (var left1 in left1Words)
                {

                    if (left1.end == 2 && //end[left1.id][2] == end[_up1][4] &&
                        len[left1.id] >= interlockWidth &&
                        left1.id != _up1)
                    {

                        //print("left1:\(words[left1.id]), interlock: \(end[left1.id][1])")
                        var down2Words = letterIndex.find(end[left1.id][1]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 && //words[down2.id][0] == end[left1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != left1.id &&
                                down2.id != _up1)
                            {

                                //print("down2:\(words[down2.id]), interlock: \(words[down2.id][1])")
                                var right2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var right2 in right2Words)
                                {

                                    if (right2.start == 1 && //words[right2.id][1] == words[down2.id][1] &&
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == end[_up1][3] &&
                                        right2.id != down2.id &&
                                        right2.id != left1.id &&
                                        right2.id != _up1)
                                    {

                                        //print("right2:\(words[right2.id]), interlock: \(words[right2.id][2])")
                                        var up3Words = letterIndex.find(words[right2.id][2]);

                                        foreach (var up3 in up3Words)
                                        {

                                            if (up3.end == 3 && //end[up3.id][3] == words[right2.id][2] &&
                                                len[up3.id] >= interlockHeight &&
                                                end[up3.id][4] == end[left1.id][0] &&
                                                up3.id != right2.id &&
                                                up3.id != down2.id &&
                                                up3.id != left1.id &&
                                                up3.id != _up1)
                                            {

                                                //print("up3:\(words[up3.id]), interlock: \(end[up3.id][2])")
                                                var left3Words = letterIndex.find(end[up3.id][2]);

                                                foreach (var left3 in left3Words)
                                                {

                                                    if (left3.end == 0 && //end[left3.id][0] == end[up3.id][2] &&
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][2] == end[_up1][2] &&
                                                        end[left3.id][1] == words[down2.id][2] &&
                                                        left3.id != up3.id &&
                                                        left3.id != right2.id &&
                                                        left3.id != down2.id &&
                                                        left3.id != left1.id &&
                                                        left3.id != _up1)
                                                    {

                                                        //print("left3:\(words[left3.id]), interlock: \(end[up3.id][1])")
                                                        var right4Words = letterIndex.find(end[up3.id][1]);

                                                        foreach (var right4 in right4Words)
                                                        {

                                                            if (right4.start == 2 && //words[right4.id][2] == end[up3.id][1] &&
                                                                len[right4.id] >= interlockWidth &&
                                                                words[right4.id][0] == end[_up1][1] &&
                                                                words[right4.id][1] == words[down2.id][3] &&
                                                                right4.id != left3.id &&
                                                                right4.id != up3.id &&
                                                                right4.id != right2.id &&
                                                                right4.id != down2.id &&
                                                                right4.id != left1.id &&
                                                                right4.id != _up1)
                                                            {

                                                                //print("right4:\(words[right4.id]), interlock: \(end[up3.id][0])") ***
                                                                var left5Words = letterIndex.find(end[up3.id][0]);

                                                                foreach (var left5 in left5Words)
                                                                {

                                                                    if (left5.end == 0 && //end[left5.id][0] == end[up3.id][0] &&
                                                                        len[left5.id] >= interlockWidth &&
                                                                        end[left5.id][2] == end[_up1][0] &&
                                                                        end[left5.id][1] == words[down2.id][4] &&
                                                                        left5.id != right4.id &&
                                                                        left5.id != left3.id &&
                                                                        left5.id != up3.id &&
                                                                        left5.id != right2.id &&
                                                                        left5.id != down2.id &&
                                                                        left5.id != left1.id &&
                                                                        left5.id != _up1)
                                                                    {

                                                                        //print("left5:\(words[left5.id])")

                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { left1.id, right2.id, left3.id, right4.id, left5.id },
                                                                            new List<int> { _up1, down2.id, up3.id },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


    private static List<ShapeModel> C3x5_RLRLR_DUD(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {

        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _down1 = 0; _down1 < wordCount; _down1++)
        {

            if (len[_down1] >= interlockHeight)
            {


                var right1Words = letterIndex.find(words[_down1][0]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == words[_down1][0] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _down1)
                    {


                        var up2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var up2 in up2Words)
                        {

                            if (up2.end == 4 && //end[up2.id][4] == words[right1.id][1] &&
                                len[up2.id] >= interlockHeight &&
                                up2.id != right1.id &&
                                up2.id != _down1)
                            {

                                //print("up2:\(words[up2.id]), interlock: \(end[up2.id][3])")
                                var left2Words = letterIndex.find(end[up2.id][3]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 1 && //end[left2.id][1] == end[up2.id][3] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][2] == words[_down1][1] &&
                                        left2.id != up2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _down1)
                                    {

                                        //print("left2:\(words[left2.id]), interlock: \(end[left2.id][0])")
                                        var down3Words = letterIndex.find(end[left2.id][0]);

                                        foreach (var down3 in down3Words)
                                        {

                                            if (down3.start == 1 && //words[down3.id][1] == end[left2.id][0] &&
                                                len[down3.id] >= interlockHeight &&
                                                words[down3.id][0] == words[right1.id][2] &&
                                                down3.id != left2.id &&
                                                down3.id != up2.id &&
                                                down3.id != right1.id &&
                                                down3.id != _down1)
                                            {

                                                //print("down3:\(words[down3.id]), interlock: \(words[down3.id][2])")
                                                var right3Words = letterIndex.find(words[down3.id][2]);

                                                foreach (var right3 in right3Words)
                                                {

                                                    if (right3.start == 2 && //words[right3.id][2] == words[down3.id][2] &&
                                                        len[right3.id] >= interlockWidth &&
                                                        words[right3.id][0] == words[_down1][2] &&
                                                        words[right3.id][1] == end[up2.id][2] &&
                                                        right3.id != down3.id &&
                                                        right3.id != left2.id &&
                                                        right3.id != up2.id &&
                                                        right3.id != right1.id &&
                                                        right3.id != _down1)
                                                    {

                                                        //print("right3:\(words[right3.id]), interlock: \(words[down3.id][3])") ***
                                                        var left4Words = letterIndex.find(words[down3.id][3]);

                                                        foreach (var left4 in left4Words)
                                                        {

                                                            if (left4.end == 0 && //end[left4.id][0] == words[down3.id][3] &&
                                                                len[left4.id] >= interlockWidth &&
                                                                end[left4.id][2] == words[_down1][3] &&
                                                                end[left4.id][1] == end[up2.id][1] &&
                                                                left4.id != right3.id &&
                                                                left4.id != down3.id &&
                                                                left4.id != left2.id &&
                                                                left4.id != up2.id &&
                                                                left4.id != right1.id &&
                                                                left4.id != _down1)
                                                            {

                                                                //print("left4:\(words[left4.id]), interlock: \(words[down3.id][4])") ***
                                                                var right5Words = letterIndex.find(words[down3.id][4]);

                                                                foreach (var right5 in right5Words)
                                                                {

                                                                    if (right5.start == 2 && //words[right5.id][2] == words[down3.id][4] &&
                                                                        len[right5.id] >= interlockWidth &&
                                                                        words[right5.id][0] == words[_down1][4] &&
                                                                        words[right5.id][1] == end[up2.id][0] &&
                                                                        right5.id != left4.id &&
                                                                        right5.id != right3.id &&
                                                                        right5.id != down3.id &&
                                                                        right5.id != left2.id &&
                                                                        right5.id != up2.id &&
                                                                        right5.id != right1.id &&
                                                                        right5.id != _down1)
                                                                    {

                                                                        //print("right5:\(words[right5.id])")

                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { right1.id, left2.id, right3.id, left4.id, right5.id },
                                                                            new List<int> { _down1, up2.id, down3.id },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


    private static List<ShapeModel> C3x5_RLRLR_UDU(in LetterIndexModel letterIndex, in List<string> words, in List<string> end, in List<int> len, int scoreMin, int widthMax, int heightMax)
    {
        int wordCount = words.Count;
        int interlockWidth = 3;
        int interlockHeight = 5;
        var result = new List<ShapeModel>();

        for (int _up1 = 0; _up1 < wordCount; _up1++)
        {

            if (len[_up1] >= interlockHeight)
            {

                //print("up1:\(words[_up1]), interlock: \(end[_up1][4])")
                var right1Words = letterIndex.find(end[_up1][4]);

                foreach (var right1 in right1Words)
                {

                    if (right1.start == 0 && //words[right1.id][0] == end[_up1][4] &&
                        len[right1.id] >= interlockWidth &&
                        right1.id != _up1)
                    {


                        var down2Words = letterIndex.find(words[right1.id][1]);

                        foreach (var down2 in down2Words)
                        {

                            if (down2.start == 0 && //words[down2.id][0] == words[right1.id][1] &&
                                len[down2.id] >= interlockHeight &&
                                down2.id != right1.id &&
                                down2.id != _up1)
                            {

                                //print("down2:\(words[down2.id]), interlock: \(words[down2.id][1])")
                                var left2Words = letterIndex.find(words[down2.id][1]);

                                foreach (var left2 in left2Words)
                                {

                                    if (left2.end == 1 && //end[left2.id][1] == words[down2.id][1] &&
                                        len[left2.id] >= interlockWidth &&
                                        end[left2.id][2] == end[_up1][3] &&
                                        left2.id != down2.id &&
                                        left2.id != right1.id &&
                                        left2.id != _up1)
                                    {

                                        //print("left2:\(words[left2.id]), interlock: \(end[left2.id][0])")
                                        var up3Words = letterIndex.find(end[left2.id][0]);

                                        foreach (var up3 in up3Words)
                                        {

                                            if (up3.end == 3 && //end[up3.id][3] == end[left2.id][0] &&
                                                len[up3.id] >= interlockHeight &&
                                                end[up3.id][4] == words[right1.id][2] &&
                                                up3.id != left2.id &&
                                                up3.id != down2.id &&
                                                up3.id != right1.id &&
                                                up3.id != _up1)
                                            {

                                                //print("up3:\(words[up3.id]), interlock: \(end[up3.id][2])")
                                                var right3Words = letterIndex.find(end[up3.id][2]);

                                                foreach (var right3 in right3Words)
                                                {

                                                    if (right3.start == 2 && //words[right3.id][2] == end[up3.id][2] &&
                                                        len[right3.id] >= interlockWidth &&
                                                        words[right3.id][0] == end[_up1][2] &&
                                                        words[right3.id][1] == words[down2.id][2] &&
                                                        right3.id != up3.id &&
                                                        right3.id != left2.id &&
                                                        right3.id != down2.id &&
                                                        right3.id != right1.id &&
                                                        right3.id != _up1)
                                                    {

                                                        //print("right3:\(words[right3.id]), interlock: \(end[up3.id][1])") ***
                                                        var left4Words = letterIndex.find(end[up3.id][1]);

                                                        foreach (var left4 in left4Words)
                                                        {

                                                            if (left4.end == 0 && //end[left4.id][0] == end[up3.id][1] &&
                                                                len[left4.id] >= interlockWidth &&
                                                                end[left4.id][2] == end[_up1][1] &&
                                                                end[left4.id][1] == words[down2.id][3] &&
                                                                left4.id != right3.id &&
                                                                left4.id != up3.id &&
                                                                left4.id != left2.id &&
                                                                left4.id != down2.id &&
                                                                left4.id != right1.id &&
                                                                left4.id != _up1)
                                                            {

                                                                //print("left4:\(words[left4.id]), interlock: \(end[up3.id][0]") ***
                                                                var right5Words = letterIndex.find(end[up3.id][0]);

                                                                foreach (var right5 in right5Words)
                                                                {

                                                                    if (right5.start == 2 && //words[right5.id][2] == end[up3.id][0] &&
                                                                        len[right5.id] >= interlockWidth &&
                                                                        words[right5.id][0] == end[_up1][0] &&
                                                                        words[right5.id][1] == words[down2.id][4] &&
                                                                        right5.id != left4.id &&
                                                                        right5.id != right3.id &&
                                                                        right5.id != up3.id &&
                                                                        right5.id != left2.id &&
                                                                        right5.id != down2.id &&
                                                                        right5.id != right1.id &&
                                                                        right5.id != _up1)
                                                                    {

                                                                        //print("right5:\(words[right5.id])")

                                                                        var cluster = new ClusterModel(
                                                                            new List<int> { right1.id, left2.id, right3.id, left4.id, right5.id },
                                                                            new List<int> { _up1, down2.id, up3.id },
                                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing },
                                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading },
                                                                            words, end, len);

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
            }
        }
        return result;
    }


}