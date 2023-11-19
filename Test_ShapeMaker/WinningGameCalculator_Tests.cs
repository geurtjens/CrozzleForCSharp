using System;
using CrozzleInterfaces;
using ShapeMakerCSharp.Calculators;

namespace ShapeMaker_Tests;

public class WinningGameCalculator_Tests
{
    [Fact]
    public void test_WinningGameCalculator_8612()
    {
        int gameId = 8612;
        // WHEN we search for winning words for game 8612
        List<string> words = WinningWordList.findWinningWords(gameId);
        // THEN 25 words are returned
        Assert.Equal(25, words.Count);
        // WHEN we use those winning words to find out how many winning games there are for game 8612
        List<ShapeModel> shapes = WinningGameCalculator.execute(gameId, words);
        // THEN 15 winning shapes are found
        Assert.Equal(15, shapes.Count);
        // WHEN we concatinate the text of all those winning shapes
        var result = "";
        foreach (var shape in shapes)
        {
            var text = shape.ToTextDebug(words);
            result += "\n" + text;

        }
        // THEN 916 lines are returned
        Assert.Equal(916, result.Length);
    }
}

