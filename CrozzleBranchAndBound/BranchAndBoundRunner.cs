using System;
using CrozzleInterfaces;
using System.Diagnostics;

namespace CrozzleBranchAndBound;

public class BranchAndBoundRunner
{
    public static void AllWords_NoGuidedScores()
    {
        var instructions = BranchAndBound_GetInstructions.AllWords_NoGuidedScores();
        UseAllWords(instructions);
    }

    public static void AllWords_UseGuidedScores()
    {
        var instructions = BranchAndBound_GetInstructions.AllWords_UseGuidedScores();
        UseAllWords(instructions);
    }

    public static void WinningWords_NoGuidedScores()
    {
        var instructions = BranchAndBound_GetInstructions.WinningWords_NoGuidedScores();
        UseWinningWords(instructions);
    }

    public static void WinningWords_UseGuidedScores()
    {
        var instructions = BranchAndBound_GetInstructions.WinningWords_UseGuidedScores();
        UseWinningWords(instructions);
    }


    public static void UseWinningWords(List<BranchAndBoundInstruction> instructions)
    {
        DateTime overallStart = DateTimeCalculator.Now();

        List<int> solved = new List<int>();
        List<int> failed = new List<int>();

        foreach (var instruction in instructions)
        {
            var solvedToAdd = BranchAndBoundRunner.ExecuteGamesWinningWords(
                gameIds: instruction.Games,
                lookaheadDepth: instruction.LookaheadDepth,
                beamWidth: instruction.BeamWidth,
                maxDepth: instruction.MaxDepth,
                rootWidth: instruction.RootWidth,
                useGuidedScores: instruction.UseGuidedScores);

            solved.AddRange(solvedToAdd);

            var missing = instruction.Games.Except(solvedToAdd).OrderBy(x => x).ToList();
            failed.AddRange(missing);
        }

        PrintResults(overallStart, solved, failed);
    }


    public static List<int> ExecuteGamesWinningWords(
        List<int> gameIds,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        bool useGuidedScores)
    {
        DateTime startTime = DateTime.Now;

        List<int> successfulGames = new List<int>();
        List<int> failedGames = new List<int>();

        Console.Write("[");


        foreach (int gameId in gameIds)
        {
            GameModel game = GameList.FindGame(gameId);

            ShapeModel bestShape = BranchAndBoundV3.Execute(
                game.GameId, game.WinningWords, lookaheadDepth, beamWidth,
                maxDepth, rootWidth, game.WinningScore, useGuidedScores);

            if (bestShape.Score >= game.WinningScore)
            {
                successfulGames.Add(game.GameId);
            } else
            {
                failedGames.Add(game.GameId);
            }

        }

        Console.WriteLine($"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"successes\": {successfulGames.Count}, \"time\": \"{DateTimeCalculator.Duration(startTime)}\"");
        if (successfulGames.Count == gameIds.Count)
        {
            Console.WriteLine("ALL GAMES SUCCEEDED");
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }
        else
        {
            var missing = gameIds.Except(successfulGames).OrderBy(x => x).ToList();
            Console.WriteLine("MISSING " + string.Join(", ", missing));
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }

        return successfulGames;
    }
    public static void UseAllWords(List<BranchAndBoundInstruction> instructions)
    {
        DateTime overallStart = DateTimeCalculator.Now();

        List<int> solved = new List<int>();
        List<int> failed = new List<int>();

        foreach (var instruction in instructions)
        {
            var solvedToAdd = ExecuteGamesAllWords(
                gameIds: instruction.Games,
                lookaheadDepth: instruction.LookaheadDepth,
                beamWidth: instruction.BeamWidth,
                maxDepth: instruction.MaxDepth,
                rootWidth: instruction.RootWidth,
                useGuidedScores: instruction.UseGuidedScores);

            solved.AddRange(solvedToAdd);

            var missing = instruction.Games.Except(solvedToAdd).OrderBy(x => x).ToList();
            failed.AddRange(missing);
        }

        PrintResults(overallStart, solved, failed);

    }

      
    public static List<int> ExecuteGamesAllWords(
        in List<int> gameIds,
        int lookaheadDepth,
        int beamWidth,
        int maxDepth,
        int rootWidth,
        bool useGuidedScores)
    {
        DateTime startTime = DateTime.Now;



        List<int> successfulGames = new List<int>();
        Console.WriteLine($"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"rootWidth\": {rootWidth}, \"maxDepth\": {maxDepth}, \"games\": {gameIds.Count}");
        Console.WriteLine(string.Join(", ", gameIds));
        foreach (int gameId in gameIds)
        {
            GameModel game = GameList.FindGame(gameId);

            ShapeModel bestShape = BranchAndBoundV3.Execute(
                game.GameId,
                game.Words,
                lookaheadDepth,
                beamWidth,
                maxDepth,
                rootWidth,
                game.WinningScore,
                useGuidedScores);

            if (bestShape.Score >= game.WinningScore)
            {
                successfulGames.Add(game.GameId);
            }

        }

        Console.WriteLine($"\"lookaheadDepth\": {lookaheadDepth}, \"beamWidth\": {beamWidth}, \"successes\": {successfulGames.Count}, \"time\": \"{DateTimeCalculator.Duration(startTime)}\"");
        if (successfulGames.Count == gameIds.Count)
        {
            Console.WriteLine("ALL GAMES SUCCEEDED");
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }
        else
        {
            var missingStuff = new HashSet<int>(gameIds).Except(new HashSet<int>(successfulGames)).OrderBy(x => x).ToList();
            List<int> missing = (List<int>)missingStuff;
            Console.WriteLine("MISSING " + string.Join(", ", missing));
            Console.WriteLine("FOUND " + string.Join(", ", successfulGames));
        }

        return successfulGames;
    }

    public static void PrintResults(DateTime overallStart, List<int> solved, List<int> missing)
    {
        solved.Sort();
        missing.Sort();

        Console.WriteLine($"Solved: {string.Join(", ", solved)}");
        Console.WriteLine($"Missing: {string.Join(", ", missing)}");
        Console.WriteLine($"Overall Duration: {DateTimeCalculator.Duration(overallStart)}");
    }

}

