using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleShapeMerger;

namespace CrozzleShapeMerger_Tests;

public class MergePlacementsCalculator_Tests
{


    [Fact]
    public void test_Execute()
    {
        int gameId = 8802;
        List<string> words = WinningWordList.findWinningWords(gameId);


        // Art is x,y of 2, 6
        List<string> a = new List<string> {
            "  . .  ",
            "  S B  ",
            "  P L  ",
            "  O A  ",
            ".PRIZE.",
            "  T E  ",
            "  .ART.",
            "    .  " };

        // Art is x,y of 2, 1
        List<string> b = new List<string> {
            "     .  ",
            "  .COPY.",
            "  A  L  ",
            "  R  A  ",
            ".STUDY. ",
            "  .  .  "};

        List<string> c = new List<string> {
            "    . ",
            "    S ",
            " .ART.",
            " C  U ",
            " O  D ",
            ".PLAY.",
            " Y  . ",
            " .    "};

        ShapeModel sourceShape = GridList.ToShape(a, words);

        Assert.Equal(7, sourceShape.Width);
        Assert.Equal(8, sourceShape.Height);


        ShapeModel searchShape = GridList.ToShape(b, words);

        Assert.Equal(8, searchShape.Width);
        Assert.Equal(6, searchShape.Height);

        
        int sourceId = 3;
        int searchId = 3;

        Assert.Equal(sourceShape.Placements[sourceId].W, searchShape.Placements[searchId].W);



        bool flip = (sourceShape.Placements[sourceId].Z != searchShape.Placements[searchId].Z);

        Assert.True(flip);

        PlacementModel sourcePlacement = sourceShape.Placements[sourceId];
        PlacementModel searchPlacement = searchShape.Placements[searchId];



        // The first thing we need to do is calculate the offset of the common word placement for both sides
        var (sourceOffsetX, sourceOffsetY, searchOffsetX, searchOffsetY) = MergePlacementsCalculator.CalculateOffsets(
            sourcePlacement.X,
            sourcePlacement.Y,
            searchPlacement.X,
            searchPlacement.Y,
            flip);

        Assert.Equal(0, sourceOffsetX);
        Assert.Equal(0, sourceOffsetY);
        Assert.Equal(1, searchOffsetX);
        Assert.Equal(4, searchOffsetY);

        


        List<PlacementModel> mergedPlacements = MergePlacementsCalculator.Execute(
            sourceShape.Placements,
            searchShape.Placements,
            sourceId,
            searchId,
            flip);

        Assert.Equal(4, sourceShape.Placements.Count);
        Assert.Equal(4, searchShape.Placements.Count);
        Assert.Equal(7, mergedPlacements.Count);

        var resultPlacements = new List<PlacementModel> {
            new PlacementModel ( w : 0, x : 0, y : 4, z : true, l : 5 ),  // PRIZE - CORRECT
            new PlacementModel ( w : 6, x : 4, y : 0, z : false, l : 6 ), // BLAZER - CORRECT
            new PlacementModel ( w : 10, x : 2, y : 0, z : false, l : 5), // SPORT - CORRECT
            new PlacementModel ( w : 16, x : 2, y : 6, z : true, l : 3 ), // ART - CORRECT 
            new PlacementModel ( w : 1, x : 8, y : 1, z : false, l : 5 ), // STUDY 5,4
            new PlacementModel ( w : 7, x : 5, y : 3, z : false, l : 4 ), // COPY 2,6
            new PlacementModel ( w : 9, x : 4, y : 6, z : true, l : 4 )   // PLAY 1, 9
        };

        string expectedText =
            "  . .  \n" +
            "  S B  \n" +
            "  P L  \n" +
            "  O A  \n" +
            ".PRIZ#.\n" +
            "  T ES \n" +
            "  .ART.\n" +
            "  C .U \n" +
            "  O  D \n" +
            " .PLAY.\n" +
            "  Y  . \n" +
            "  .    ";

        var badResult = new List<string>
            {
            ". .     ",
            "S B   . ",
            "P L   S ",
            "O A.  T ",
            ".PRIZ#. U ",
            "T EO  D ",
            ".A###AY.",
            "  .Y  . ",
            "   .    "
            };


        Assert.Equal("PRIZE", words[0]);
        Assert.Equal("BLAZER", words[6]);
        Assert.Equal("SPORT", words[10]);
        Assert.Equal("ART", words[16]);
        Assert.Equal("STUDY", words[1]);
        Assert.Equal("COPY", words[7]);
        Assert.Equal("PLAY", words[9]);

        

        ShapeModel mergedShape = new ShapeModel(width: PlacementList.GetWidth(mergedPlacements), height: PlacementList.GetHeight(mergedPlacements), score: 0, placements: mergedPlacements);

        string actualText = mergedShape.ToTextDebug(words);
        Assert.Equal(expectedText, actualText);






        ShapeModel searchShape2 = GridList.ToShape(c, words);
        Assert.Equal(4, searchShape2.Placements.Count);


        List<PlacementModel> mergedPlacementsWithoutFlip = MergePlacementsCalculator.Execute(
            sourceShape.Placements,
            searchShape2.Placements);

       


        ShapeModel mergedShapeWithoutFlip = new ShapeModel(width: PlacementList.GetWidth(mergedPlacementsWithoutFlip), height: PlacementList.GetHeight(mergedPlacementsWithoutFlip), score: 0, placements: mergedPlacementsWithoutFlip);

        string actualTextWithoutFlip = mergedShapeWithoutFlip.ToTextDebug(words);
        Assert.Equal(expectedText, actualTextWithoutFlip);

        
    }





    [Fact]
    public void test_FindCommonWords()
    {
        // GIVEN sourcePlacements has words 1,2
        List<PlacementModel> sourcePlacements = new List<PlacementModel>
        {
            new PlacementModel(1, 0, 0, true, 0),
            new PlacementModel(2, 0, 0, true, 0)
        };

        // AND searchPlacements has words 1,2,3
        List<PlacementModel> searchPlacements = new List<PlacementModel>
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
