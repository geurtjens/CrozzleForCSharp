using System;
namespace ShapeMakerCSharp
{
	public readonly record struct GameModel
	{
        public readonly int gameId;
        
        public readonly byte widthMax;
        public readonly byte heightMax;
        public readonly ushort winningScore;
        
        public readonly List<string> winningGame;
        public readonly List<string> winningWords;
        public readonly List<string> words;
        public readonly List<string> tags;

        public GameModel(int gameId, ushort winningScore, byte widthMax, byte heightMax,
            in List<string> winningWords, in List<string> words,
            in List<string> tags, in List<string> winningGame)
        {
            this.gameId = gameId;
            this.winningScore = winningScore;
            this.widthMax = widthMax;
            this.heightMax = heightMax;
            this.winningWords = winningWords;
            this.words = words;
            this.tags = tags;
            this.winningGame = winningGame;
        }
    }
}