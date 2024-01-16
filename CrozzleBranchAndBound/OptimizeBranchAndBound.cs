using CrozzleInterfaces;
using CrozzleShapeMaker;

namespace CrozzleBranchAndBound;

public class OptimizeBranchAndBound
{

    public static void ExecuteFailuresUsingGuidedScores()
    {
        // cannot do 8803
        List<int> games = new List<int> { 8805 };
        ExecuteWinningGames(games, maxLookaheadDepth: 4, maxBeamWidth: 150, maxDepth: 30, useGuidedScores: true);
    }


    public static void ExecuteFailuresNoGuidedScores()
    {
        List<int> games = new List<int> { //8803,
            8804, 8805, 8807, 8811, 8902, 8904, 8904, 8905, 8911,
9001, 9003, 9106, 9207, 9210, 9212, 9303, 9305, 9307, 9404,
9410, 9501, 9502, 9504, 9506, 9507, 9508, 9509, 9602, 9604 };

        ExecuteWinningGames(games, maxLookaheadDepth: 4, maxBeamWidth: 100, maxDepth: 30, useGuidedScores: false);
    }


    public static void ExecuteWinningGames(
        List<int> games,
        int maxLookaheadDepth,
        int maxBeamWidth,
        int maxDepth,
        bool useGuidedScores)
    {
        List<string> result = new List<string>();

        foreach (int gameId in games)
        {
            List<string> results = ExecuteWinningGame(gameId, 1, maxLookaheadDepth, 1, maxBeamWidth, maxDepth, useGuidedScores);
            result.AddRange(results);
        }

        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }


    

    public static List<int> GetWinningShapesToTest(int gameId)
    {
        GameModel game = GameList.FindGame(gameId);
        List<ShapeModel> winningShapes = WinningGameCalculator.execute(gameId, game.WinningWords);
        


        // Let's work out the average scores among the winning games and only use the ones that have a score higher than average
        double averageScore = ShapeList.FindAverageScore(winningShapes);

        List<int> result = new List<int>();

        for (int i = 0; i < winningShapes.Count; i++)
        {
            if (winningShapes[i].Score > averageScore)
            {
                result.Add(i);
            }
        }
        return result;
    }

    public static List<string> ExecuteWinningGame(
        int gameId,
        int minLookaheadDepth,
        int maxLookaheadDepth,
        int minBeamWidth,
        int maxBeamWidth,
        int maxDepth,
        bool useGuidedScores)
    {
        List<string> result = new List<string>();

        // First, we find out how many starting shapes are going to be considered
        List<int> startingShapesToTest = GetWinningShapesToTest(gameId);

        Console.WriteLine($"game: {gameId}, numberOfStartingShapesToTest: {startingShapesToTest.Count}");

        for (int lookaheadDepth = minLookaheadDepth; lookaheadDepth <= maxLookaheadDepth; lookaheadDepth++)
        {
            for (int rootShapeId = 0; rootShapeId < startingShapesToTest.Count; rootShapeId++)
            {
                int rootShape = startingShapesToTest[rootShapeId];

                DateTime overallStart = DateTime.Now;

                int winningWidth = OptimizeBeamWidth(gameId, lookaheadDepth, maxDepth, minBeamWidth, maxBeamWidth, rootShape, rootWidth: 1, useGuidedScores);

                if (winningWidth != -1)
                {
                    result.Add($"game: {gameId}, rootShape: {rootShape}, lookaheadDepth: {lookaheadDepth}, beamWidth: {winningWidth}, timeToProcess: {DateTime.Now - overallStart}");
                }
            }
        }

        foreach (string item in result)
        {
            Console.WriteLine(item);
        }

        return result;
    }


    public static int OptimizeBeamWidth(
        int gameId,
        int lookaheadDepth,
        int maxDepth,
        int minimumBeamWidth,
        int maximumBeamWidth,
        int rootShape,
        int rootWidth,
        bool useGuidedScores)
    {
        string timeToProcessOneConfiguration = "";
        int lowerWidth = minimumBeamWidth;
        int upperWidth = maximumBeamWidth;
        int currentWidth = 0;

        DateTime overallStart = DateTime.Now;

        List<int> lowerWidthShouldFail = BranchAndBoundRunner.ExecuteGamesWinningWords(new List<int> { gameId }, lookaheadDepth, lowerWidth, maxDepth, rootShape, rootWidth, useGuidedScores);

        if (lowerWidthShouldFail.Count > 0)
        {
            Console.WriteLine($"game {gameId} lower width of {minimumBeamWidth} should not produce a winning game. Skipping this game.");
            return lowerWidth;
        }
        else
        {
            List<int> upperWidthShouldSucceed = BranchAndBoundRunner.ExecuteGamesWinningWords(new List<int> { gameId }, lookaheadDepth, upperWidth, maxDepth, rootShape, rootWidth, useGuidedScores);

            if (upperWidthShouldSucceed.Count == 0)
            {
                Console.WriteLine($"game {gameId} upper width of {maximumBeamWidth} should produce a winning game. Skipping this game.");
                return -1;
            }
            else
            {
                while (lowerWidth != upperWidth)
                {
                    currentWidth = (int)Math.Round((double)(lowerWidth + upperWidth) / 2.0);
                    Console.WriteLine($"Game: {gameId}, RootShape: {rootShape}, lower: {lowerWidth}, upper: {upperWidth}, currentWidth: {currentWidth}");

                    DateTime testOneConfigurationStart = DateTime.Now;

                    List<int> winnersForCurrent = BranchAndBoundRunner.ExecuteGamesWinningWords(new List<int> { gameId }, lookaheadDepth, currentWidth, maxDepth, rootShape, rootWidth, useGuidedScores);
                    timeToProcessOneConfiguration = (DateTime.Now - testOneConfigurationStart).ToString();

                    if (winnersForCurrent.Count == 0)
                    {
                        if (lowerWidth == currentWidth)
                        {
                            lowerWidth += 1;
                            currentWidth = lowerWidth;
                        }
                        else
                        {
                            lowerWidth = currentWidth;
                        }
                    }
                    else
                    {
                        upperWidth = currentWidth;
                        if (upperWidth == (lowerWidth + 1))
                        {
                            // We know the lower width does not work and the upper width does work so if its one place away then we have our solution
                            lowerWidth = upperWidth;
                        }
                    }
                }

                Console.WriteLine($"FINAL SIZE\nGame: {gameId}, RootShape: {rootWidth}, lookaheadDepth: {lookaheadDepth}, beamWidth: {currentWidth}, time: {timeToProcessOneConfiguration}, overallProcessTime: {(DateTime.Now - overallStart)}");
                return currentWidth;
            }
        }
    }

}