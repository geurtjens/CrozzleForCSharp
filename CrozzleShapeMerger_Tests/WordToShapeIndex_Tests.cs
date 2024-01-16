using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleShapeMerger;

namespace CrozzleShapeMerger_Tests;

public class WordToShapeIndex_Tests
{
    [Fact]
    public void test_Execute_8612_WinningWords()
    {
        // GIVEN we have chosen 8612 to be processed
        int gameId = 8612;

        // AND we are using `winning words` only
        List<string> words = WinningWordList.findWinningWords(gameId);

        // WHEN we Execute the StartingDataCalculator passing `winning words` only, only wanting one starting node and not trying for guided scores. 
        StartingDataModel result = StartingDataCalculator.Execute(
            gameId: gameId,
            words: words,
            rootShape: 0,
            rootWidth: 1,
            useGuidedScores: false);

        // THEN game 8612 has a maxWidth of 17, maxHeight of 12 and winning score of 694
        Assert.Equal(8612, result.gameId);
        Assert.Equal(17, result.maxWidth);
        Assert.Equal(12, result.maxHeight);
        Assert.Equal(694, result.winningScore);

        // AND 380 search shapes are found
        Assert.Equal(380, result.searchShapes.Count);

        // AND because we didnt use guided scores we get 45x 0 minimum score values to comply with
        Assert.Equal(45, result.scoresMin.Count);

        // AND there are 15 winning shapes that we had calculated using the manual machanisms
        Assert.Equal(15, result.winningShapes.Count);

        // AND because we asked for a root width of 1 we should get only 1 starting shape
        Assert.Single(result.startingShapes);

        // AND 25 words are returned and placed in the wordIndex
        Assert.Equal(25, words.Count);

        WordToShapeIndex wordIndex = new WordToShapeIndex(result.searchShapes, words.Count);


        Assert.Equal(25, wordIndex.Index.Count);

        
        
        Assert.Equal(380, wordIndex.ShapeCount);

        // AND summing up all possible interlocks there should be 982 interlocking shape points available
        Assert.Equal(982, wordIndex.Interlockability);

        // AND our json representation of this should look like as follows
        string expectedStatistics = "{\"wordCount\": 25, \"shapeCount\": 380, \"wordToShapeSum\": 982, \"wordToShapeCount\": \"27,53,35,15,35,44,28,44,59,30,57,63,53,33,50,27,38,26,47,18,71,33,20,39,37\"}";
        string actualStatistics = wordIndex.StatisticsToJson();
        Assert.Equal(expectedStatistics, actualStatistics);
        Console.WriteLine(actualStatistics);
    }


    [Fact]
    public void test_Execute_8612_AllWords()
    {
        // GIVEN we have chosen 8612 to be processed
        int gameId = 8612;

        // AND we are using all words
        List<string> words = CompetitionList.findWords(gameId);

        // WHEN we Execute the StartingDataCalculator passing `all words`, only wanting one starting node and not trying for guided scores. 
        StartingDataModel result = StartingDataCalculator.Execute(
            gameId: gameId,
            words: words,
            rootShape: 0,
            rootWidth: 1,
            useGuidedScores: false);

        // THEN game 8612 has a maxWidth of 17, maxHeight of 12 and winning score of 694
        Assert.Equal(8612, result.gameId);
        Assert.Equal(17, result.maxWidth);
        Assert.Equal(12, result.maxHeight);
        Assert.Equal(694, result.winningScore);
        Assert.Equal(11_371, result.searchShapes.Count);

        WordToShapeIndex wordIndex = new WordToShapeIndex(result.searchShapes, words.Count);



        // AND because we didnt use guided scores we get 45x 0 minimum score values to comply with
        Assert.Equal(45, result.scoresMin.Count);

        // AND there are 15 winning shapes that we had calculated using the manual machanisms
        Assert.Equal(15, result.winningShapes.Count);

        // AND because we asked for a root width of 1 we should get only 1 starting shape
        Assert.Single(result.startingShapes);

        // AND 91 words should have been returned and placed in the wordIndex
        Assert.Equal(91, words.Count);
        //Assert.Equal(91, result.wordIndex.index.Count);

        // AND 11,371 search shapes are found
        Assert.Equal(11_371, wordIndex.ShapeCount);

        // AND summing up all possible interlocks there should be 43,178 interlocking shape points available
        Assert.Equal(43_178, wordIndex.Interlockability);

        // AND our json representation of this should look like as follows
        string expectedStatistics = "{\"wordCount\": 91, \"shapeCount\": 11371, \"wordToShapeSum\": 43178, \"wordToShapeCount\": \"600,453,307,35,393,721,327,367,820,312,1074,773,892,373,554,444,905,645,575,328,1410,1177,654,618,638,638,185,0,733,489,577,809,942,308,253,371,510,0,447,487,565,1101,202,472,400,175,0,210,550,833,173,0,205,0,443,0,179,626,0,992,146,345,481,406,387,374,221,261,581,700,426,1016,252,206,162,694,184,178,954,359,658,546,218,1020,328,234,527,202,521,363,958\"}";
        string actualStatistics = wordIndex.StatisticsToJson();
        Console.WriteLine(actualStatistics);
        Assert.Equal(expectedStatistics, actualStatistics);




    }



    int scoreMin = 0;
    int widthMax = 17;
    int heightMax = 12;

    [Fact]
    public void test_WordIndexModelV2()
    {

        /*
         ..
      .STAY.
        .HAWSER.
       .BOW.
      .GUY.
        O.
        Y
        .
         */

        var words = new List<string> { "AHOY", "YAW", "STAY", "HAWSER", "BOW", "GUY", "BUOY" }; // WordData.words_8806()
        var end = WordList.Reversed(words: words);
        var len = WordList.Lengths(words: words);

        var letterIndex = new LetterIndexModel(words: words);

        List<ShapeModel> c2x2Shapes = ClusterCalculator.C2x2(
            letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: scoreMin,
            widthMax: widthMax,
            heightMax: heightMax);

        List<ShapeModel> c2x3Shapes = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: scoreMin,
            widthMax: widthMax,
            heightMax: heightMax);




        //let(C2x2Text, C2x2Score) = ShapeCalculator.ToText(shape:c2x2Shapes[0], words: words)
        //print("Shape A score: \(C2x2Score)")
        //print(C2x2Text)



        //let(C2x3Text, C2x3Score) = ShapeCalculator.ToText(shape:c2x3Shapes[0], words: words)
        //print("Shape B score: \(C2x3Score)")
        //print(C2x3Text)



        var sourceShape = c2x2Shapes[0];
        var searchShapes = c2x3Shapes;


        WordToShapeIndex wordIndex = new WordToShapeIndex(searchShapes, words.Count);
        Assert.Equal(7, wordIndex.Index.Count);
        Assert.Single(wordIndex.Index[0]);
        Assert.Single(wordIndex.Index[1]);
        Assert.Single(wordIndex.Index[2]);
        Assert.Single(wordIndex.Index[3]);
        Assert.Single(wordIndex.Index[4]);


        Assert.Equal(0, wordIndex.Index[0][0]);
        Assert.Equal(0, wordIndex.Index[1][0]);
        Assert.Equal(0, wordIndex.Index[2][0]);
        Assert.Equal(0, wordIndex.Index[3][0]);
        Assert.Equal(0, wordIndex.Index[4][0]);



        var searchShapeIds = wordIndex.FindMatches(sourceShape: sourceShape);


        //Assert.Single(instructions);
        //var instruction = instructions[0];
        //Assert.Equal(0, instruction.sourceShapeId);
        //Assert.Equal(0, instruction.searchShapeId);
        //Assert.Equal(2, instruction.matchingWordCount);


        //Assert.Equal(0, instruction.firstSourcePos);
        //Assert.Equal(0, instruction.firstSearchPos);
        //Assert.False(instruction.flipped);

    }


    private ShapeModel get_Hymn_Merry()
    {

        /// GIVEN our game has four words
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };


        /// AND we have another shape made up of the same words as the search shape that is in the search index
        List<string> sourceGrid = new List<string> {
            "  .   ",
            "  M   ",
            "  E   ",
            "  R   ",
            "  R   ",
            ".HYMN.",
            "  .   " };
        ShapeModel sourceShape = GridList.ToShape(sourceGrid, words);
        return sourceShape;
    }


    private ShapeModel get_Hymn_Star_White_Merry()
    {
        //score:52, width:6, height:7, words:2

        /// GIVEN our game has four words
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };

        /// AND we have found a shape with those words
        List<string> grid = new List<string> {
            "  .    ",
            "  W .  ",
            " .HYMN.",
            "  I E  ",
            ".STAR. ",
            "  E R  ",
            "  . Y  ",
            "    .  " };
        ShapeModel shape = GridList.ToShape(grid, words);

        return shape;

    }


    [Fact]
    public void test_WordIndexModelV2_2() {


        ShapeModel searchShape = get_Hymn_Star_White_Merry();

        /// WHEN we create an index based only on the single shapethe words
        var wordIndex = new WordToShapeIndex(shapes: new List<ShapeModel> { searchShape }, wordCount: 4);

        /// THEN there will be four positions in the index, one for each word
        Assert.Equal(4, wordIndex.Index.Count);

        /// AND each index points to only one shape (because we only had one shape)
        Assert.Single(wordIndex.Index[0]);
        Assert.Single(wordIndex.Index[1]);
        Assert.Single(wordIndex.Index[2]);
        Assert.Single(wordIndex.Index[3]);

        /// AND the shape that each index item is pointing to is our only shape, shape 0
        Assert.Equal(0, wordIndex.Index[0][0]);
        Assert.Equal(0, wordIndex.Index[1][0]);
        Assert.Equal(0, wordIndex.Index[2][0]);
        Assert.Equal(0, wordIndex.Index[3][0]);

    }

    [Fact]
    public void test_SubsetShapesShouldNotBeFound() {

        /// GIVEN our game has four words
        ShapeModel searchShape = get_Hymn_Star_White_Merry();


        /// AND we have created an index with that one shape
        WordToShapeIndex searchIndex = new WordToShapeIndex(shapes: new List<ShapeModel> { searchShape }, wordCount: 4);

        ShapeModel sourceShape = get_Hymn_Merry();

        /// WHEN we search for this shape which is really a subset of the shape we are searching
        var matchingShapes = searchIndex.FindMatches(sourceShape);

        /// THEN we find there are no results because we do not return subsets
        Assert.Single(matchingShapes);
    }


    [Fact]
    public void test_FindMatchesForWordList_TwoShapesReturned()
    {

        /// AND we have another shape made up of the same words as the search shape that is in the search index
        List<string> grid0 = new List<string> {
            "  .   ",
            "  M   ",
            "  E   ",
            "  R   ",
            "  R   ",
            ".HYMN.",
            "  .   " };

        /// AND we have found a shape with those words
        List<string> grid1 = new List<string> {
            "  .    ",
            "  W    ",
            " .HYMN.",
            "  I    ",
            ".STAR. ",
            "  E    ",
            "  .    " };



        /// GIVEN our game has four words
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };

        ShapeModel shape0 = GridList.ToShape(grid0, words);
        ShapeModel shape1 = GridList.ToShape(grid1, words);

        List<ShapeModel> shapes = new List<ShapeModel> { shape0, shape1 };

        WordToShapeIndex index = new WordToShapeIndex(shapes, words.Count);

        // HYMN is in both shapes
        List<int> wordListWithTwoShapes = new List<int> { 1 };

        List<int> matchingPositions = index.FindMatchesForWordList(wordListWithTwoShapes);

        Assert.Equal(2, matchingPositions.Count);
    }

    [Fact]
    public void test_FindMatchesForWordList_OneShapeReturned()
    {

        /// AND we have another shape made up of the same words as the search shape that is in the search index
        List<string> grid0 = new List<string> {
            "  .   ",
            "  M   ",
            "  E   ",
            "  R   ",
            "  R   ",
            ".HYMN.",
            "  .   " };

        /// AND we have found a shape with those words
        List<string> grid1 = new List<string> {
            "  .    ",
            "  W    ",
            " .HYMN.",
            "  I    ",
            ".STAR. ",
            "  E    ",
            "  .    " };



        /// GIVEN our game has four words
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };

        ShapeModel shape0 = GridList.ToShape(grid0, words);
        ShapeModel shape1 = GridList.ToShape(grid1, words);

        List<ShapeModel> shapes = new List<ShapeModel> { shape0, shape1 };

        WordToShapeIndex index = new WordToShapeIndex(shapes, words.Count);

        // MERRY is only in one of the shapes
        List<int> wordListWithTwoShapes = new List<int> { 0 };

        List<int> matchingPositions = index.FindMatchesForWordList(wordListWithTwoShapes);

        Assert.Single(matchingPositions);
    }

    [Fact]
    public void test_FindMatchesForWordList_NoShapeReturned()
    {

        /// AND we have another shape made up of the same words as the search shape that is in the search index
        List<string> grid0 = new List<string> {
            "  .   ",
            "  M   ",
            "  E   ",
            "  R   ",
            "  R   ",
            ".HYMN.",
            "  .   " };

        /// AND we have found a shape with those words
        List<string> grid1 = new List<string> {
            "  .    ",
            "  W    ",
            " .HYMN.",
            "  I    ",
            ".STAR. ",
            "  E    ",
            "  .    " };



        /// GIVEN our game has four words
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR", "EXTRA" };

        ShapeModel shape0 = GridList.ToShape(grid0, words);
        ShapeModel shape1 = GridList.ToShape(grid1, words);

        List<ShapeModel> shapes = new List<ShapeModel> { shape0, shape1 };

        WordToShapeIndex index = new WordToShapeIndex(shapes, words.Count);

        // MERRY is only in one of the shapes
        List<int> wordListWithTwoShapes = new List<int> { 4 };

        List<int> matchingPositions = index.FindMatchesForWordList(wordListWithTwoShapes);

        Assert.Empty(matchingPositions);
    }

}
