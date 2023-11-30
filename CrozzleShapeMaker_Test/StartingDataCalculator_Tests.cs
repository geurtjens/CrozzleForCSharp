using CrozzleShapeMaker;
namespace CrozzleShapeMaker_Tests;

public class StartingDataCalculator_Tests
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
            rootWidth: 1,
            useGuidedScores: false);

        // THEN game 8612 has a maxWidth of 17, maxHeight of 12 and winning score of 694
        Assert.Equal(8612, result.gameId);
        Assert.Equal(17, result.maxWidth);
        Assert.Equal(12, result.maxHeight);
        Assert.Equal(694, result.winningScore);

        // AND because we didnt use guided scores we get 45x 0 minimum score values to comply with
        Assert.Equal(45, result.scoresMin.Count);

        // AND there are 15 winning shapes that we had calculated using the manual machanisms
        Assert.Equal(15, result.winningShapes.Count);

        // AND because we asked for a root width of 1 we should get only 1 starting shape
        Assert.Single(result.startingShapes);

        // AND 25 words are returned and placed in the wordIndex
        Assert.Equal(25, words.Count);
        //Assert.Equal(25, result.wordIndex.index.Count);

        // AND 380 search shapes are found
        Assert.Equal(380, result.searchShapes.Count);
        //Assert.Equal(380, result.wordIndex.shapeCount);

        // AND summing up all possible interlocks there should be 982 interlocking shape points available
        //Assert.Equal(982, result.wordIndex.interlockability);

        // AND our json representation of this should look like as follows
        //string expectedStatistics = "{\"wordCount\": 25, \"shapeCount\": 380, \"wordToShapeSum\": 982, \"wordToShapeCount\": \"27,53,35,15,35,44,28,44,59,30,57,63,53,33,50,27,38,26,47,18,71,33,20,39,37\"}";
        //string actualStatistics = result.wordIndex.StatisticsToJson();
        //Assert.Equal(expectedStatistics, actualStatistics);
        //Console.WriteLine(actualStatistics);
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
            gameId:gameId,
            words: words,
            rootWidth:1,
            useGuidedScores: false);

        // THEN game 8612 has a maxWidth of 17, maxHeight of 12 and winning score of 694
        Assert.Equal(8612, result.gameId);
        Assert.Equal(17, result.maxWidth);
        Assert.Equal(12, result.maxHeight);
        Assert.Equal(694, result.winningScore);

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
        Assert.Equal(11_371, result.searchShapes.Count);
        //Assert.Equal(11_371, result.wordIndex.shapeCount);

        // AND summing up all possible interlocks there should be 43,178 interlocking shape points available
        //Assert.Equal(43_178, result.wordIndex.interlockability);

        // AND our json representation of this should look like as follows
        //string expectedStatistics = "{\"wordCount\": 91, \"shapeCount\": 11371, \"wordToShapeSum\": 43178, \"wordToShapeCount\": \"600,453,307,35,393,721,327,367,820,312,1074,773,892,373,554,444,905,645,575,328,1410,1177,654,618,638,638,185,0,733,489,577,809,942,308,253,371,510,0,447,487,565,1101,202,472,400,175,0,210,550,833,173,0,205,0,443,0,179,626,0,992,146,345,481,406,387,374,221,261,581,700,426,1016,252,206,162,694,184,178,954,359,658,546,218,1020,328,234,527,202,521,363,958\"}";
        //string actualStatistics = result.wordIndex.StatisticsToJson();
        //Console.WriteLine(actualStatistics);
        //Assert.Equal(expectedStatistics, actualStatistics);

        


    }
}


