using System;
namespace CrozzleInterfaces
{

    public readonly record struct GameModel
    {
        public readonly int gameId;

        public readonly byte widthMax;
        public readonly byte heightMax;
        public readonly ushort winningScore;

        public readonly GridList winningGame;
        public readonly List<string> winningWords;
        public readonly List<string> words;


        public GameModel(
            int gameId,
            ushort winningScore,
            byte widthMax,
            byte heightMax,
            in List<string> winningWords,
            in List<string> words,
            in GridList winningGame)
        {
            this.gameId = gameId;
            this.winningScore = winningScore;
            this.widthMax = widthMax;
            this.heightMax = heightMax;
            this.winningWords = winningWords;
            this.words = words;
            this.winningGame = winningGame;
        }
    }
}

