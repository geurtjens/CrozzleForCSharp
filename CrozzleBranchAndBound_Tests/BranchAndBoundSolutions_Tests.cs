using CrozzleBranchAndBound;

namespace BranchAndBound_Tests;

public class BranchAndBoundSolutions_Tests
{
    [Fact]
    public void Test_allShapesThatCanBeSolvedWithoutGuides()
    {
        BranchAndBoundSolutions.AllShapesThatCanBeSolved();
    }

    [Fact]
    public void test_executeGamesWinningWords_depth1_width1()
    {

        List<int> depth1_width1 = new List<int> { 8802, 8808, 9104, 9212, 9306, 9406 };
        List<int> result = BranchAndBoundSolutions.ExecuteGamesWinningWords(gameIds: depth1_width1, lookaheadDepth: 1, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: true);
        Assert.Equal(6, result.Count);
    }
}
