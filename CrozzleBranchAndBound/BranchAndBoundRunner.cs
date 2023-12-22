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

        foreach (var instruction in instructions)
        {
            solved.AddRange(BranchAndBoundV3.ExecuteGamesWinningWords(
                gameIds: instruction.Games,
                lookaheadDepth: instruction.LookaheadDepth,
                beamWidth: instruction.BeamWidth,
                maxDepth: instruction.MaxDepth,
                rootWidth: instruction.RootWidth,
                useGuidedScores: instruction.UseGuidedScores));
        }

        PrintResults(overallStart, solved);
    }

    public static void UseAllWords(List<BranchAndBoundInstruction> instructions)
    {
        DateTime overallStart = DateTimeCalculator.Now();

        List<int> solved = new List<int>();

        foreach (var instruction in instructions)
        {
            solved.AddRange(BranchAndBoundV3.ExecuteGamesAllWords(
                gameIds: instruction.Games,
                lookaheadDepth: instruction.LookaheadDepth,
                beamWidth: instruction.BeamWidth,
                maxDepth: instruction.MaxDepth,
                rootWidth: instruction.RootWidth,
                useGuidedScores: instruction.UseGuidedScores));
        }

        PrintResults(overallStart, solved);
    }


    public static void PrintResults(DateTime overallStart, List<int> solved)
    {
        var gameList = new GameList();
        var missing = new List<int>();
        var games = GameList.Games();

        foreach (int gameId in games)
        {
            GameModel game = GameList.FindGame(gameId: gameId);
            if (!solved.Contains(game.GameId))
            {
                missing.Add(game.GameId);
            }
        }

        solved.Sort();
        missing.Sort();

        Console.WriteLine($"Solved: {string.Join(", ", solved)}");
        Console.WriteLine($"Missing: {string.Join(", ", missing)}");
        Console.WriteLine($"Overall Duration: {DateTimeCalculator.Duration(overallStart)}");
    }

}

