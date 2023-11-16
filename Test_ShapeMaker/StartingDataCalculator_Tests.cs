using System;
using CrozzleInterfaces;
using ShapeMakerCSharp;
using ShapeMakerCSharp.Calculators;

namespace Test_ShapeMaker;

public class StartingDataCalculator_Tests
{
    [Fact]
    public void Execute_Test()
    {
        int gameId = 8612;


        List<string> words = WinningWordList.findWinningWords(gameId);
        Assert.Equal(25, words.Count);


        StartingDataModel result = StartingDataCalculator.Execute(gameId, words, 1, false);


        Assert.Equal(17, result.maxWidth);
        Assert.Equal(12, result.maxHeight);
        Assert.Equal(45, result.scoresMin.Count);
        Assert.Equal(380, result.searchShapes.Count);
        Assert.Single(result.startingShapes);
        Assert.Equal(694, result.winningScore);
        Assert.Equal(15, result.winningShapes.Count);

    }
}


