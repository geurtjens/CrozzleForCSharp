using CrozzleInterfaces;
using CrozzleShapeMaker;

namespace CrozzleShapeMaker_Tests;

public class WinningShapesCalculator_Tests
{
    [Fact]
    public void test_execute_AllGames()
    {
        var games = GameList.Games();
        foreach (int gameId in games)
        {
            GameModel game = GameList.FindGame(gameId);

            List<string> words = game.winningWords;

            var result = WinningShapesCalculator.execute(gameId, words);
            Console.WriteLine($"{gameId}, {result.Count}");

            for (int shapeId = 0; shapeId < result.Count; shapeId++)
            {
                var text = result[shapeId].ToTextDebug(words: game.winningWords);
                if (text.Contains("#"))
                {
                    Console.WriteLine($"{game.gameId}");
                    Console.WriteLine(result[shapeId].ToCSharpCode());

                }
                Assert.DoesNotContain("#", text);
            }
        }
    }
}

