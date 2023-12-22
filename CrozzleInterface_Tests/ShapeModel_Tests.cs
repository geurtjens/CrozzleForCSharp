using CrozzleInterfaces;

namespace CrozzleInterface_Tests;

public class ShapeModel_Tests
{
    [Fact]
    public void test_ToTextDebug_ShouldFlipAndSort()
    {
        var game = GameList.FindGame(8803);
        List<string> words = game.WinningWords;
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
    public void test_ToTextDebug_NoNeedToFlipOrSort()
    {
        var game = GameList.FindGame(8803);
        List<string> words = game.WinningWords;
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

}
