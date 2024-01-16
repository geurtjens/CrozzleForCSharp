using System;
using CrozzleBranchAndBound;
using CrozzleInterfaces;
using CrozzleShapeMerger;

namespace CrozzleBranchAndBound_Tests;

public class GetStartingData_Tests
{
    [Fact]
    public void test_Execute()
    {
        int gameId = 8808;
        List<string> words = new List<string> { "STUTZ", "SUZUKI", "BENZ", "VW", "MAZDA", "VORTEX", "ROCKY", "CAMRY", "SUPRA", "TURBO", "TELSTAR", "ASTRA", "BMW", "RENAULT", "ROLLS", "COLT", "ROMEO", "TARAGO", "AUDI", "MG", "SEDAN", "NOMAD", "SAAB", "GOLF", "ALFA", "LADA" };
        int rootWidth = 1;
        bool useGuidedScores = false;


        var (_, searchShapes, wordIndex, rootTreeNodes, scoresMin, widthMax, heightMax) = GetStartingData.Execute(
            gameId: gameId,
            words: words,
            rootShape: 0,
            rootWidth: rootWidth,
            useGuidedScores: useGuidedScores);


        Assert.Single(rootTreeNodes);
        //Assert.Equal(31, rootTreeNodes[0].ChildShapes.Count);


        foreach (var shape in rootTreeNodes[0].ChildShapes) {
            Console.WriteLine($"score: {shape.Score}, width: {shape.Width}, height: {shape.Height}");
            Console.WriteLine(shape.ToTextDebug(words: words));
        }
    }
}

