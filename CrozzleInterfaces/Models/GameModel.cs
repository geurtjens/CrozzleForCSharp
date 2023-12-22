using System;
namespace CrozzleInterfaces;


public readonly record struct GameModel
{
    public readonly int GameId;

    public readonly byte WidthMax;
    public readonly byte HeightMax;
    public readonly ushort WinningScore;

    public readonly List<string> WinningGame;
    public readonly List<string> WinningWords;
    public readonly List<string> Words;


    public GameModel(
        int gameId,
        ushort winningScore,
        byte widthMax,
        byte heightMax,
        in List<string> winningWords,
        in List<string> words,
        in List<string> winningGame)
    {
        GameId = gameId;
        WinningScore = winningScore;
        WidthMax = widthMax;
        HeightMax = heightMax;
        WinningWords = winningWords;
        Words = words;
        WinningGame = winningGame;
    }
}

