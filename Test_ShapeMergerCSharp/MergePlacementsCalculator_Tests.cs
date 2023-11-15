using CrozzleInterfaces;
using ShapeMergerCSharp;

namespace Test_ShapeMergerCSharp;

public class MergePlacementsCalculator_Tests
{
    [Fact]
    public void FindCommonWords_Test()
    {
        // GIVEN sourcePlacements has words 1,2
        PlacementList sourcePlacements = new PlacementList
        {
            new PlacementModel(1, 0, 0, true, 0),
            new PlacementModel(2, 0, 0, true, 0)
        };

        // AND searchPlacements has words 1,2,3
        PlacementList searchPlacements = new PlacementList
        {
            new PlacementModel(1, 0, 0, true, 0),
            new PlacementModel(2, 0, 0, true, 0),
            new PlacementModel(3, 0, 0, true, 0)
        };

        // When we check for common words
        HashSet<int> result = MergePlacementsCalculator.FindCommonWords(sourcePlacements, searchPlacements);

        // THEN we find 1,2 are common words
        Assert.Equal(2, result.Count);
        Assert.Contains(1,result);
        Assert.Contains(2, result);

        
    }
}
