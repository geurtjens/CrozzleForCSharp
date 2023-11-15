using System;
using CrozzleInterfaces;
using ShapeMakerCSharp;

namespace BranchAndBoundCSharp
{
    public class OptimizeBranchAndBound
    {

        public static Tuple<GameIdList, IntList> optimizeWithStartingWords(
        int gameId,
        in WordList words,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        bool useGuidedScores)
        {
            IntList beamWidthResults = new IntList();

            GameIdList startingWords = findValidStartingWords(
                gameId,
                words,
                lookaheadDepth,
                beamWidth,
                
                maxDepth,
                useGuidedScores);


            for (int i = 0; i < startingWords.Count; i++)
            {
                int startingWord = startingWords[i];

                int beamWidthResult = OptimizeBeamWidth(
                    gameId,
                    lookaheadDepth,
                    maxDepth,
                    1,
                    beamWidth,
                    startingWord * -1,
                    false);

                beamWidthResults.Add(beamWidthResult);
            }

            for (int i = 0; i < beamWidthResults.Count; i++)
            {
                Console.WriteLine($"Starting word {startingWords[i]} has beam width of {beamWidthResults[i]}");
            }

            return new Tuple<GameIdList, IntList>(startingWords, beamWidthResults);
        }


        public static int OptimizeBeamWidthAllWordsAsync(
        int gameId, int lookaheadDepth, int maxDepth,
        int minimumBeamWidth, int maximumBeamWidth, int rootWidth, bool useGuidedScores)
        {
            int currentWidth= 0;

            int lowerWidth = minimumBeamWidth;
            int upperWidth = maximumBeamWidth;

            GameIdList lowerWidthShouldFail = BranchAndBoundV3.ExecuteGamesAllWords(
                new GameIdList { gameId },
                lookaheadDepth, lowerWidth, maxDepth, rootWidth, useGuidedScores);

            if (lowerWidthShouldFail.Count > 0)
            {
                Console.WriteLine($"Game {gameId}: Lower width of {minimumBeamWidth} should not produce a winning game. Skipping this game.");
                return -1;
            }
            else
            {
                GameIdList upperWidthShouldSucceed = BranchAndBoundV3.ExecuteGamesAllWords(
                    new GameIdList { gameId },
                    lookaheadDepth, upperWidth, maxDepth, rootWidth, useGuidedScores);

                if (upperWidthShouldSucceed.Count == 0)
                {
                    Console.WriteLine($"Game {gameId}: Upper width of {maximumBeamWidth} should produce a winning game. Skipping this game.");
                    return -1;
                }
                else
                {
                    while (lowerWidth != upperWidth)
                    {
                        currentWidth = (int)((double)(lowerWidth + upperWidth + 0.5) / 2.0);
                        Console.WriteLine($"Game: {gameId}, Lower: {lowerWidth}, Upper: {upperWidth}, Current Width: {currentWidth}");

                        GameIdList winnersForCurrent = BranchAndBoundV3.ExecuteGamesAllWords(
                            new GameIdList { gameId },
                            lookaheadDepth, currentWidth, maxDepth, rootWidth, useGuidedScores);

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
                        }
                    }
                    Console.WriteLine($"Final size for Game {gameId} is {currentWidth}");
                    return currentWidth;
                }
            }
        }

        /// <summary>
        /// We are trying different starting words to see if we can get the human score
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="lookaheadDepth"></param>
        /// <param name="beamWidth"></param>
        /// <param name="maxDepth"></param>
        /// <returns></returns>
        public static GameIdList findValidStartingWords(
            int gameId,
            WordList words,
            int lookaheadDepth,
            int beamWidth,
            int maxDepth,
            bool useGuidedScores)
        {
            GameIdList result = new GameIdList();

            StartingDataModel startingDataModel = StartingDataCalculator.Execute(
                gameId :gameId,
                words: words,
                rootWidth: 0, // Meaning give us all of them
                useGuidedScores: false);

            List<ShapeModel> winningShapes = startingDataModel.startingShapes;

            for (int i = 0; i < winningShapes.Count; i++)
            {
                int startingShape = i * -1;

                GameIdList winning = BranchAndBoundV3.ExecuteGamesWinningWords(
                    new GameIdList { gameId },
                    lookaheadDepth,
                    beamWidth,
                    maxDepth,
                    startingShape,
                    false);

                if (winning.Count == 1)
                {
                    result.Add(startingShape);
                }
            }

            return result;
        }

        public static List<List<int>> OptimizeBeamWidthAsync(
                GameIdList games, int lookaheadDepth, int maxDepth,
                int minimumBeamWidth, int maximumBeamWidth, int rootWidth, bool useGuidedScores)
        {
            int lowerWidth = 0;
            int upperWidth = 0;
            int currentWidth= 0;

            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < maximumBeamWidth + 1; i++)
            {
                result.Add(new List<int>());
            }

            GameIdList failures = new GameIdList();

            foreach (int gameId in games)
            {
                lowerWidth = minimumBeamWidth;
                upperWidth = maximumBeamWidth;

                GameIdList lowerWidthShouldFail = BranchAndBoundV3.ExecuteGamesWinningWords(
                    new GameIdList { gameId },
                    lookaheadDepth, lowerWidth, maxDepth, rootWidth, useGuidedScores);

                if (lowerWidthShouldFail.Count > 0)
                {
                    failures.Add(gameId);
                    Console.WriteLine($"Game {gameId}: Lower width of {minimumBeamWidth} should not produce a winning game. Skipping this game.");
                }
                else
                {
                    GameIdList upperWidthShouldSucceed = BranchAndBoundV3.ExecuteGamesWinningWords(
                        new GameIdList { gameId },
                        lookaheadDepth, upperWidth, maxDepth, rootWidth, useGuidedScores);

                    if (upperWidthShouldSucceed.Count == 0)
                    {
                        failures.Add(gameId);
                        Console.WriteLine($"Game {gameId}: Upper width of {maximumBeamWidth} should produce a winning game. Skipping this game.");
                    }
                    else
                    {
                        while (lowerWidth != upperWidth)
                        {
                            currentWidth = (int)((double)(lowerWidth + upperWidth + 0.5) / 2.0);
                            Console.WriteLine($"Game: {gameId}, Lower: {lowerWidth}, Upper: {upperWidth}, Current Width: {currentWidth}");

                            GameIdList winnersForCurrent = BranchAndBoundV3.ExecuteGamesWinningWords(
                                new GameIdList { gameId },
                                lookaheadDepth, currentWidth, maxDepth, rootWidth, useGuidedScores);

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
                            }
                        }
                        Console.WriteLine($"Final size for Game {gameId} is {currentWidth}");
                        result[currentWidth].Add(gameId);
                    }
                }
            }

            if (failures.Count > 0)
            {
                Console.WriteLine($"Failures because they started out of range: {string.Join(", ", failures)}");
            }

            for (int beamWidth = 0; beamWidth < maximumBeamWidth + 1; beamWidth++)
            {
                if (result[beamWidth].Count > 0)
                {
                    Console.WriteLine($"depth{lookaheadDepth}_width{beamWidth} = {string.Join(", ", result[beamWidth])}");
                }
            }

            return result;
        }


        public static int OptimizeBeamWidth(
            int gameId,
            int lookaheadDepth,
            int maxDepth,
            int minimumBeamWidth,
            int maximumBeamWidth,
            int rootWidth,
            bool useGuidedScores)
        {
            
            int currentWidth = 0;
            int lowerWidth = minimumBeamWidth;
            int upperWidth = maximumBeamWidth;

            GameIdList lowerWidthShouldFail = BranchAndBoundV3.ExecuteGamesWinningWords(
                new GameIdList { gameId },
                lookaheadDepth, lowerWidth, maxDepth, rootWidth, useGuidedScores);

            if (lowerWidthShouldFail.Count > 0)
            {
                Console.WriteLine($"Game {gameId}: Lower width of {minimumBeamWidth} should not produce a winning game. Skipping this game.");
                return -1;
            }
            else
            {
                GameIdList upperWidthShouldSucceed = BranchAndBoundV3.ExecuteGamesWinningWords(
                    new GameIdList { gameId },
                    lookaheadDepth,
                    upperWidth,
                    maxDepth,
                    rootWidth,
                    useGuidedScores);

                if (upperWidthShouldSucceed.Count == 0)
                {
                    Console.WriteLine($"Game {gameId}: Upper width of {maximumBeamWidth} should produce a winning game. Skipping this game.");
                    return -1;
                }
                else
                {
                    while (lowerWidth != upperWidth)
                    {
                        currentWidth = (int)((double)(lowerWidth + upperWidth + 0.5) / 2.0);
                        Console.WriteLine($"Game: {gameId}, Lower: {lowerWidth}, Upper: {upperWidth}, Current Width: {currentWidth}");

                        GameIdList winnersForCurrent = BranchAndBoundV3.ExecuteGamesWinningWords(
                            new GameIdList { gameId },
                            lookaheadDepth, lowerWidth, maxDepth, rootWidth, useGuidedScores);

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
                        }
                        
                    }

                    Console.WriteLine($"Final size for Game {gameId} is {currentWidth}");
                    return currentWidth;
                }
            }
        }

    }
}

