using System;
using CrozzleInterfaces;
using ShapeMakerCSharp;

namespace ShapeMakerCSharp
{
	public class PacmanCalculator
	{
       

        public static int ExecuteAllSerial(
            in List<GameModel> games,
            int scoreMin,
            bool includeBreakdown)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (includeBreakdown)
            {
                Console.WriteLine("Pacman Shapes");
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

            Console.WriteLine($"PacmanCalculator produced {shapesFromWinningWordsCount} winning words records and {shapesFromWordsCount} words records in {watch.ElapsedMilliseconds} ms\n");

            return shapesFromWordsCount;
        }



        public static List<ShapeModel> Execute(
            in WordList words,
            int scoreMin,
            int widthMax,
            int heightMax) {

            var len = words.Lengths();

            var letterIndex = new LetterIndexModel(words);

            var end = words.Reversed();


            var topRight3x3 = TopRight3x3(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

            var bottomRight3s3 = BottomRight3x3(letterIndex, words, end, len, scoreMin, widthMax, heightMax);

            var topLeft3x3 = TopLeft3x3(letterIndex, words, end, len, scoreMin, widthMax, heightMax);


            var result = new List<ShapeModel>();

            result.AddRange(topRight3x3);
            result.AddRange(bottomRight3s3);
            result.AddRange(topLeft3x3);
    
        return result;
    }


    public static List<ShapeModel> TopRight3x3(
        in LetterIndexModel letterIndex,
        in List<string> words,
        in List<string> end,
        in List<int> len,
        int scoreMin,
        int widthMax,
        int heightMax)
    {
        int interlockWidth = 3;
        int interlockHeight = 3;
        /*
                 .
                 B
                 U
           .PARITY.
               .RESERVE.
         .DEBENTURE.
                S.L
                T L
                . .
         */

        var result = new List<ShapeModel>();
        int wordCount = words.Count;

        for (int _left1 = 0; _left1 < wordCount; _left1++)
        {
            if (len[_left1] >= interlockWidth)
            {
                var down1Words = letterIndex.find(end[_left1][1]);
                foreach (var down1 in down1Words)
                {
                    if (down1.start == 0 && //words[_down1][0] == end[_left1][1])
                        len[down1.id] >= interlockHeight &&
                        down1.id != _left1)
                    {
                        var up2Words = letterIndex.find(end[_left1][0]);
                        foreach (var up2 in up2Words)
                        {
                            if (up2.end == 2 && //end[_up2][2] == end[_left1][0])
                                len[up2.id] >= interlockHeight &&
                                up2.id != down1.id &&
                                up2.id != _left1)
                            {
                                var right2Words = letterIndex.find(end[up2.id][1]);
                                foreach (var right2 in right2Words)
                                {
                                    if (right2.start == 1 && //words[_right2][1] == end[_up2][1])
                                        len[right2.id] >= interlockWidth &&
                                        words[right2.id][0] == words[down1.id][1] &&
                                        right2.id != up2.id &&
                                        right2.id != down1.id &&
                                        right2.id != _left1)
                                    {
                                        var down3Words = letterIndex.find(words[right2.id][2]);
                                        foreach (var down3 in down3Words)
                                        {
                                            if (down3.start == 0 && //words[_down3][0] == words[_right2][2]
                                                len[down3.id] >= interlockHeight &&
                                                down3.id != right2.id &&
                                                down3.id != up2.id &&
                                                down3.id != down1.id &&
                                                down3.id != _left1)
                                            {
                                                var left3Words = letterIndex.find(words[down3.id][1]);
                                                foreach (var left3 in left3Words)
                                                {
                                                    if (left3.end == 0 && //end[_left3][0] == words[_down3][1]
                                                        len[left3.id] >= interlockWidth &&
                                                        end[left3.id][1] == end[up2.id][0] &&
                                                        end[left3.id][2] == words[down1.id][2] &&
                                                        left3.id != down3.id &&
                                                        left3.id != down1.id &&
                                                        left3.id != up2.id &&
                                                        left3.id != right2.id &&
                                                        left3.id != _left1)
                                                    {
                                                        var pacman = new PacmanModel(
                                                            PacmanType.topRight,
                                                            new List<int> { _left1, right2.id, left3.id},
                                                            new List<int> { down1.id, up2.id, down3.id},
                                                            new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading},
                                                            new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing},
                                                            words, end, len);

                                                        if (pacman.isValid(scoreMin, widthMax, heightMax))
                                                        {
                                                            result.Add(pacman.ToShape());
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

public static List<ShapeModel> BottomRight3x3(
    in LetterIndexModel letterIndex,
    in List<string> words,
    in List<string> end,
    in List<int> len,
    int scoreMin,
    int widthMax,
    int heightMax)
{ 
    int interlockWidth = 3;
    int interlockHeight = 3;
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

    var result = new List<ShapeModel>();
    int wordCount = words.Count;

    for (int _left1 = 0; _left1 < wordCount; _left1++)
    {
        if (len[_left1] >= interlockWidth)
        {
            var up1Words = letterIndex.find(end[_left1][2]);
            foreach (var up1 in up1Words)
            {

                if (up1.end == 2 && //end[_up1][2] == end[_left1][2])
                    len[up1.id] >= interlockHeight &&
                    up1.id > _left1) /// So we dont do duplicates
                {
                    var down2Words = letterIndex.find(end[_left1][1]);

                    foreach (var down2 in down2Words)
                    {
                        if (down2.start == 0 && //words[_down2][0] == end[_left1][1])
                            len[down2.id] >= interlockHeight &&
                            down2.id != up1.id &&
                            down2.id != _left1)
                        {
                            var right2Words = letterIndex.find(words[down2.id][1]);

                            foreach (var right2 in right2Words)
                            {
                                if (right2.start == 1 && //words[_right2][1] == words[_down2][1]
                                    len[right2.id] >= interlockWidth &&
                                    words[right2.id][0] == end[up1.id][1] &&
                                    right2.id != up1.id &&
                                    right2.id != down2.id &&
                                    right2.id != _left1)
                                {
                                    var up3Words = letterIndex.find(words[right2.id][2]);

                                    foreach (var up3 in up3Words)
                                    {
                                        if (up3.end == 0 && //end[_up3][0] == words[_right2][2]
                                            len[up3.id] >= interlockHeight &&
                                            end[up3.id][1] == end[_left1][0] &&
                                            up3.id != up1.id &&
                                            up3.id != down2.id &&
                                            up3.id != right2.id &&
                                            up3.id != _left1)
                                        {
                                            var left3Words = letterIndex.find(end[up1.id][0]);

                                            foreach (var left3 in left3Words)
                                            {
                                                if (left3.end == 1 && //end[_left3][1] == end[_up1][0] &&
                                                    len[left3.id] >= interlockWidth &&
                                                    end[left3.id][0] == words[down2.id][2] &&
                                                    left3.id != up1.id &&
                                                    left3.id != down2.id &&
                                                    left3.id != up3.id &&
                                                    left3.id != right2.id &&
                                                    left3.id != _left1)
                                                {
                                                    var pacman = new PacmanModel(
                                                        PacmanType.bottomRight,
                                                        new List<int> { _left1, right2.id, left3.id},
                                                        new List<int> { up1.id, down2.id, up3.id},
                                                        new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading},
                                                        new List<ClusterPosition> { ClusterPosition.leading, ClusterPosition.trailing, ClusterPosition.leading},
                                                        words, end, len);

                                                    if (pacman.isValid(scoreMin, widthMax, heightMax))
                                                    {
                                                        result.Add(pacman.ToShape());
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


// Flips to topLeft, visually verified
// This does not appear in any winning game
public static List<ShapeModel> TopLeft3x3(
    in LetterIndexModel letterIndex,
    in List<string> words,
    in List<string> end,
    in List<int> len,
    int scoreMin,
    int widthMax,
    int heightMax)
{

    int interlockWidth = 3;
    int interlockHeight = 3;

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
    int wordCount = words.Count;
    var result = new List<ShapeModel>();

    for (int _right1 = 0; _right1 < wordCount; _right1++)
    {
        if (len[_right1] >= interlockWidth)
        {
            var up2Words = letterIndex.find(words[_right1][0]);

            foreach (var up2 in up2Words)
            {
                if (up2.end == 2 && //end[_up2][2] == words[_right1][0])
                    len[up2.id] >= interlockHeight &&
                    up2.id != _right1)
                {
                    var left2Words = letterIndex.find(end[up2.id][1]);

                    foreach (var left2 in left2Words)
                    {
                        if (left2.end == 1 && //end[_left2][1] == end[_up2][1])
                            len[left2.id] >= interlockWidth &&
                            left2.id != up2.id &&
                            left2.id != _right1)
                        {
                            var down3Words = letterIndex.find(end[left2.id][0]);

                            foreach (var down3 in down3Words)
                            {
                                if (down3.start == 1 && //words[_down3][1] == end[_left2][0]
                                    len[down3.id] >= interlockHeight &&
                                    words[down3.id][0] == words[_right1][1] &&
                                    down3.id != up2.id &&
                                    down3.id != left2.id &&
                                    down3.id != _right1)
                                {
                                    var right3Words = letterIndex.find(words[down3.id][2]);

                                    foreach (var right3 in right3Words)
                                    {
                                        if (right3.start == 2 && //words[_right3][2] == words[_down3][2]
                                            len[right3.id] >= interlockWidth &&
                                            words[right3.id][1] == end[up2.id][0] &&
                                            right3.id != down3.id &&
                                            right3.id != left2.id &&
                                            right3.id != up2.id &&
                                            right3.id != _right1)
                                        {
                                            var down1Words = letterIndex.find(words[right3.id][0]);

                                            foreach (var down1 in down1Words)
                                            {
                                                if (down1.start == 1 && //words[_down1][1] == words[_right3][0])
                                                    len[down1.id] >= interlockHeight &&
                                                    words[down1.id][0] == end[left2.id][2] &&
                                                    down1.id != right3.id &&
                                                    down1.id != down3.id &&
                                                    down1.id != left2.id &&
                                                    down1.id != up2.id &&
                                                    down1.id > _right1)
                                                {
                                                    var pacman = new PacmanModel(
                                                        PacmanType.topLeft,
                                                        new List<int> { _right1, left2.id, right3.id},
                                                        new List<int> { down1.id, up2.id, down3.id},
                                                        new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing},
                                                        new List<ClusterPosition> { ClusterPosition.trailing, ClusterPosition.leading, ClusterPosition.trailing},
                                                        words, end, len);

                                                    if (pacman.isValid(scoreMin, widthMax, heightMax))
                                                    {
                                                        result.Add(pacman.ToShape());
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

