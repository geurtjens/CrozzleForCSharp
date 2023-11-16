using CrozzleInterfaces;
using ShapeMakerCSharp;
using ShapeMakerCSharp.Calculators;

namespace Test_ShapeMaker;

public class UnitTest1
{



    [Fact]
    public void TestWinningGameCalculator()
    {
        List<string> words = WinningWordList.findWinningWords(8612);
        var shapes = WinningGameCalculator.execute(8612, words);
        var result = "";
        foreach (var shape in shapes)
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

            List<string> words = game.winningWords;

            var result = WinningShapesCalculator.execute(gameId, words);
            Console.WriteLine($"{gameId}, {result.Count}");

            for (int shapeId=0; shapeId <result.Count; shapeId++)
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

    [Fact]
    public void ShouldFlipAndSort()
    {
        var game = GameList.FindGame(8803);
        List<string> words = game.winningWords;
        Console.WriteLine($"{words[2]}, {words[8]}, {words[9]}, {words[13]}, {words[22]}, {words[23]}");

        var placements = new List<PlacementModel> {
            new PlacementModel(w: 8, x: 0, y: 4, z: true, l: 6),
            new PlacementModel(w: 23, x: 0, y: 2, z: true, l: 5),
            new PlacementModel(w: 9, x: 3, y: 3, z: true, l: 4),
            new PlacementModel(w: 13, x: 4, y: 1, z: false, l: 6),
            new PlacementModel(w: 22, x: 5, y: 0, z: false, l: 4),
            new PlacementModel(w: 2, x: 6, y: 2, z: false, l: 6),
        };

        var shape = new ShapeModel(score: 136, width: 9, height: 10, placements: placements);

        
        var result = shape.ToTextDebug(words: words);
        Assert.DoesNotContain("#", result);

        string expectedText =
            "  . .     \n" +
            "  D B     \n" +
            "  E O     \n" +
            "  L.M     \n" +
            " .HOBART. \n" +
            ".LIMA.    \n" +
            "  .SYDNEY.\n" +
            "   K.     \n" +
            "   .      ";



        Assert.Equal(result, expectedText);
        Console.WriteLine(result);
    }


    [Fact]
    public void NoNeedToFlipOrSort()
    {
        var game = GameList.FindGame(8803);
        List<string> words = game.winningWords;
        Console.WriteLine($"{words[2]}, {words[8]}, {words[9]}, {words[13]}, {words[22]}, {words[23]}");


        var placements = new List<PlacementModel> {
            new PlacementModel(w: 2, x: 2, y: 6, z: true, l: 6),
            new PlacementModel(w: 8, x: 4, y: 0, z: false, l: 6),
            new PlacementModel(w: 9, x: 3, y: 3, z: false, l: 4),
            new PlacementModel(w: 13, x: 1, y: 4, z: true, l: 6),
            new PlacementModel(w: 22, x: 0, y: 5, z: true, l: 4),
            new PlacementModel(w: 23, x: 2, y: 0, z: false, l: 5),
        };

        var shape = new ShapeModel(score: 136, width: 10, height: 9, placements: placements);

        string expectedText =
            "  . .     \n" +
            "  D B     \n" +
            "  E O     \n" +
            "  L.M     \n" +
            " .HOBART. \n" +
            ".LIMA.    \n" +
            "  .SYDNEY.\n" +
            "   K.     \n" +
            "   .      ";



        var result = shape.ToTextDebug(words: words);
        Assert.DoesNotContain("#", result);
        Assert.Equal(result, expectedText);
        Console.WriteLine(result);
    }

    [Fact]
    public void Test_Pacman3x3_TopRight_8803()
    {
        var game = GameList.FindGame(8803);

        var words = game.winningWords;
        var letterIndex = new LetterIndexModel(words);
        var end = WordList.Reversed(words);
        var len = WordList.Lengths(words);

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