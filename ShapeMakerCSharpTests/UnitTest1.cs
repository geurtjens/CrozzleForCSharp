using CrozzleInterfaces;
using ShapeMakerCSharp;
using ShapeMakerCSharp.Calculators;
using static System.Net.Mime.MediaTypeNames;

namespace ShapeMakerCSharpTests;

public class UnitTest1
{

    



    [Fact]
    public void TestWinningGameCalculator()
    {
        WordList words = WinningWordList.findWinningWords(8612);
        var shapes = WinningGameCalculator.execute(8612, words);
        var result = "";
        foreach(var shape in shapes)
        {
            var text = shape.ToTextDebug(words);
            result += "\n" + text;
           
        }
        Assert.Equal(25, words.Count);
        Assert.Equal(15, shapes.Count);
    }



    [Fact]
    public void TestAll()
    {
        var games = GameList.Games();
        foreach (int gameId in games)
        {
            GameModel game = GameList.FindGame(gameId);
            var result = WinningShapesCalculator.execute(game.gameId, game.winningWords);
            Console.WriteLine($"{game.gameId}, {result.Count}");
            foreach(var item in result)
            {
                var text = item.ToTextDebug(words: game.winningWords);
                if (text.Contains("#"))
                {
                    Console.WriteLine($"{game.gameId}");

                }
                Assert.DoesNotContain("#",text);
            }
        }
    }

    [Fact]
    public void Test2()
    {
        var placements = new List<PlacementModel> {
            new PlacementModel(w: 23, x: 2, y: 2, z: true, l: 5),
            new PlacementModel(w: 9, x: 0, y: 3, z: true, l: 4),
            new PlacementModel(w: 8, x: 1, y: 4, z: true, l: 6),
            new PlacementModel(w: 13, x: 2, y: 2, z: false, l: 6),
            new PlacementModel(w: 22, x: 3, y: 0, z: false, l: 4),
            new PlacementModel(w: 2, x: 4, y: 1, z: false, l: 6)
        };

        var shape = new ShapeModel(score: 136, width: 9, height: 10, placements: placements);

        var game = GameList.FindGame(8803);

        var result = shape.ToTextDebug(words: game.winningWords);
        Assert.DoesNotContain("#", result);
        Console.WriteLine(result);
    }


    [Fact]
    public void Test_Pacman3x3_TopRight_8803()
    {
        var game = GameList.FindGame(8803);

        var words = game.winningWords;
        var letterIndex = new LetterIndexModel(words);
        var end = words.Reversed();
        var len = words.Lengths();

        var pacman3x3_TopRight = PacmanCalculator.TopRight3x3(
                letterIndex: letterIndex,
                words: words,
                end: end,
                len: len,
                scoreMin: 136,
                widthMax: 10,
                heightMax: 9);

        foreach (var shape in pacman3x3_TopRight)
        {
            var text = shape.ToTextDebug(words);
            if (text.Contains("#"))
            {
                var swiftCode = shape.ToSwiftCode();
                var csharpCode = shape.ToCSharpCode();
                Console.WriteLine();
            }
            Assert.True(text.Contains("#") == false);
            Console.WriteLine(text);
        }
    }
}
