using CrozzleInterfaces;

namespace ShapeMakerCSharp;

public class EdgeCalculator
{

    public static int ExecuteAllSerial(
        in List<GameModel> games,
        int scoreMin,
        bool includeBreakdown = false)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        int shapesFromWordsCount = 0;
        int shapesFromWinningWordsCount = 0;

        if (includeBreakdown)
        {
            Console.WriteLine("Edge Shapes");
            Console.WriteLine("GameId, WinningWordShapes, AllWordShapes");
        }
        
        foreach (GameModel game in games)
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

        Console.WriteLine($"EdgeCalculator produced {shapesFromWinningWordsCount} winning words records and {shapesFromWordsCount} words records in {watch.ElapsedMilliseconds} ms\n");

        return shapesFromWordsCount;
    }


    public static List<ShapeModel> Execute(in List<string> words, int scoreMin, int widthMax, int heightMax) {

        int wordCount = words.Count;

        var result = new List<ShapeModel>();
    
        for (int horizontalWordId=0; horizontalWordId<wordCount; horizontalWordId++)
        {
            string horizontalWord = words[horizontalWordId];

            for (int horizontalPosition=0; horizontalPosition<horizontalWord.Length; horizontalPosition++)
            {
                for (int verticalWordId=horizontalWordId + 1; verticalWordId<wordCount; verticalWordId++)
                {
                    string verticalWord = words[verticalWordId];
                
                    for (int verticalPosition=0; verticalPosition<verticalWord.Length; verticalPosition++)
                    {
                        if (verticalWord[verticalPosition] == horizontalWord[horizontalPosition])
                        {
                            int score = ScoreCalculator.score(horizontalWord[horizontalPosition]) + 20;
                        
                            if (score >= scoreMin)
                            {
                                int width = (int)horizontalWord.Length + 2;

                                int height = (int)verticalWord.Length + 2;
                        
                                if ((width <= widthMax && height <= heightMax) ||
                                    (width <= heightMax && height <= widthMax))
                                {
                                    EdgeModel edge = new EdgeModel(
                                        (byte) horizontalWordId,
                                        (byte) horizontalPosition,
                                        (byte) horizontalWord.Length,

                                        (byte) verticalWordId,
                                        (byte) verticalPosition,
                                        (byte) verticalWord.Length,
                                        (byte) width,
                                        (byte) height,
                                        (ushort) score);
                                    result.Add(edge.ToShape());
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

