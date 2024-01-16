using System;
using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleShapeMerger;

namespace CrozzleShapeMerger_Tests;

public class MatchCalculator_Tests
{




    [Fact]
	public void test_GetMatches()
	{
        /// GIVEN we have the grid HYMN_MERRY shapeanother shape made up of the same words as the search shape that is in the search index
        List<string> sourceGrid = new List<string> {
        "  .   ",
        "  M   ",
        "  E   ",
        "  R   ",
        "  R   ",
        ".HYMN.",
        "  .   " };

        /// AND another grid HYMN_STAR_WHITE that has the common word HYMN
        List<string> searchGrid = new List<string> {
        "  .    ",
        "  W    ",
        " .HYMN.",
        "  I    ",
        ".STAR. ",
        "  E    ",
        "  .    " };



        /// AND the common four words in these shapes are MERRY, HYMN, WHITE, STAR
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };

        // AND based on the order of the words in the words, the common word HYMN is wordId = 1
        const int hymnWordId = 1;


        // WHEN we convert these grids to shapes 
        ShapeModel sourceShape = GridList.ToShape(sourceGrid, words);
        ShapeModel searchShape = GridList.ToShape(searchGrid, words);

        // THEN sourceShape has "HYMN" in position 1
        Assert.Equal(hymnWordId, sourceShape.Placements[1].W);

        // AND searchShape has "HYMN in position 0
        Assert.Equal(hymnWordId, searchShape.Placements[0].W);


        // WHEN we calculate GetMatches with sourceShape and searchShape
        MatchesModel result = ValidateMergeCalculator.GetMatches(sourceShape, searchShape);

        // THEN we find only 1 matching word
        Assert.Equal(1, result.MatchingWordCount);

        // AND the common word for firstSourcePos is position 1 just like the placement position for the sourceShape
        Assert.Equal(1, result.FirstSourcePos);
        // AND the common word searchShape is found in position 0 like the word position that hymn was found
        Assert.Equal(0, result.FirstSearchPos);
        
        // AND we will have a match or -1 for each word in the sourceShape
        Assert.Equal(sourceShape.Placements.Count, result.Matches.Count);
        // AND first word of `MERRY` isnt matching so it will be -1
        Assert.Equal(-1, result.Matches[0]);
        // AND second word within sourceShape, being `HYMN`, matches with first word in searchShape which is also `HYMN`.
        Assert.Equal(0, result.Matches[1]);
    }

    [Fact]
    public void test_ProcessMatches_UsingSingleMatch()
    {

        /// GIVEN we have the grid HYMN_MERRY shapeanother shape made up of the same words as the search shape that is in the search index
        List<string> sourceGrid = new List<string> {
        "  .   ",
        "  M   ",
        "  E   ",
        "  R   ",
        "  R   ",
        ".HYMN.",
        "  .   " };

        /// AND another grid HYMN_STAR_WHITE that has the common word HYMN
        List<string> searchGrid = new List<string> {
        "  .    ",
        "  W    ",
        " .HYMN.",
        "  I    ",
        ".STAR. ",
        "  E    ",
        "  .    " };



        /// AND the common four words in these shapes are MERRY, HYMN, WHITE, STAR
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };


        // WHEN we convert these grids to shapes 
        ShapeModel sourceShape = GridList.ToShape(sourceGrid, words);
        ShapeModel searchShape = GridList.ToShape(searchGrid, words);




        MergeInstructionModel? resultOrNull = ValidateMergeCalculator.Execute(
            matchCount: 1,
            sourceShape: sourceShape,
            sourceShapeId: 0,
            searchShape: searchShape,
            searchShapeId: 1
            );
        Assert.NotNull(resultOrNull);

        MergeInstructionModel result = (MergeInstructionModel)resultOrNull;

        // THEN we find only 1 matching word
        Assert.Equal(1, result.MatchingWordCount);

        // AND the common word for firstSourcePos is position 1 just like the placement position for the sourceShape
        Assert.Equal(1, result.FirstSourcePos);
        // AND the common word searchShape is found in position 0 like the word position that hymn was found
        Assert.Equal(0, result.FirstSearchPos);


        // AND search word must be flipped in order to match `HYMN` in the right direction
        Assert.True(result.Flipped);
        // AND the sourceShapeId we passed in is now put into the structure
        Assert.Equal(0, result.SourceShapeId);
        // AND the searchShapeId we passed in is now put into the structure
        Assert.Equal(1, result.SearchShapeId);

    }

    [Fact]
    public void test_SingleMatch()
    {

        /// GIVEN we have the grid HYMN_MERRY shapeanother shape made up of the same words as the search shape that is in the search index
        List<string> sourceGrid = new List<string> {
        "  .   ",
        "  M   ",
        "  E   ",
        "  R   ",
        "  R   ",
        ".HYMN.",
        "  .   " };

        /// AND another grid HYMN_STAR_WHITE that has the common word HYMN
        List<string> searchGrid = new List<string> {
        "  .    ",
        "  W    ",
        " .HYMN.",
        "  I    ",
        ".STAR. ",
        "  E    ",
        "  .    " };



        /// AND the common four words in these shapes are MERRY, HYMN, WHITE, STAR
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };

        // WHEN we convert these grids to shapes 
        ShapeModel sourceShape = GridList.ToShape(sourceGrid, words);
        ShapeModel searchShape = GridList.ToShape(searchGrid, words);




        MergeInstructionModel? resultOrNull = ValidateMergeCalculator.SingleWordMatch(
            sourceShape: sourceShape,
            sourceShapeId: 0,
            searchShape: searchShape,
            searchShapeId: 1);
        Assert.NotNull(resultOrNull);

        MergeInstructionModel result = (MergeInstructionModel)resultOrNull;

        // THEN we find only 1 matching word
        Assert.Equal(1, result.MatchingWordCount);

        // AND the common word for firstSourcePos is position 1 just like the placement position for the sourceShape
        Assert.Equal(1, result.FirstSourcePos);
        // AND the common word searchShape is found in position 0 like the word position that hymn was found
        Assert.Equal(0, result.FirstSearchPos);


        // AND search word must be flipped in order to match `HYMN` in the right direction
        Assert.True(result.Flipped);
        // AND the sourceShapeId we passed in is now put into the structure
        Assert.Equal(0, result.SourceShapeId);
        // AND the searchShapeId we passed in is now put into the structure
        Assert.Equal(1, result.SearchShapeId);

    }

    [Fact]
    public void test_MatchingPlacementPosition()
    {

       

        /// GIVEN grid HYMN_STAR_WHITE 
        List<string> searchGrid = new List<string> {
        "  .    ",
        "  W    ",
        " .HYMN.",
        "  I    ",
        ".STAR. ",
        "  E    ",
        "  .    " };



        /// AND the common four words in these shapes are MERRY, HYMN, WHITE, STAR
        List<string> words = new List<string> { "MERRY", "HYMN", "WHITE", "STAR" };


        // WHEN we convert these grids to shapes 
        ShapeModel searchShape = GridList.ToShape(searchGrid, words);

        // AND MATCH on all four words remembering that MERRY is not in this shape but the others are
        int a0 = ValidateMergeCalculator.MatchingPlacementPosition(searchShape: searchShape, wordId: 0);
        int a1 = ValidateMergeCalculator.MatchingPlacementPosition(searchShape: searchShape, wordId: 1);
        int a2 = ValidateMergeCalculator.MatchingPlacementPosition(searchShape: searchShape, wordId: 2);
        int a3 = ValidateMergeCalculator.MatchingPlacementPosition(searchShape: searchShape, wordId: 3);


        // THEN wordId 0 is not found and it returns -1
        Assert.Equal(-1, a0);
        // AND wordId 1 is in position 0
        Assert.Equal(0, a1);
        // AND wordId=2 is in position 1
        Assert.Equal(1, a2);
        // AND wordId=3 is in position 2
        Assert.Equal(2, a3);
    }


    [Fact]
    public void test_MultiWordMatch_8806()
    {
        List<string> sourceGrid = new List<string> {
            "    .   " ,
            "   .G   " ,
            "  .BUOY." ,
            ".AHOY.  " ,
            "   W.   " ,
            "   .    "};

        List<string> searchGrid = new List<string> {
            " .    ",
            " S .  ",
            " T.B  ",
            ".AHOY.",
            ".YAW. ",
            " .W.  ",
            "  S   ",
            "  E   ",
            "  R   ",
            "  .   "};

        List<string> words = new List<string> { "BUOY", "AHOY", "BOW", "GUY", "YAW", "STAY", "HAWSER" };

        ShapeModel sourceShape = GridList.ToShape(sourceGrid, words);
        ShapeModel searchShape = GridList.ToShape(searchGrid, words);

        var result = ValidateMergeCalculator.MultiWordMatch(sourceShape: sourceShape, sourceShapeId: 0, searchShape: searchShape, searchShapeId: 1, matchingWordCount: 2);

        Assert.NotNull(result);
        Assert.Equal(1, result.FirstSourcePos);
        Assert.Equal(0, result.FirstSearchPos);
        Assert.False(result.Flipped);

        // AND the number we passed in as matchingWordCount is stored
        Assert.Equal(2, result.MatchingWordCount);
        // AND the sourceShapeId we passed is stored
        Assert.Equal(0, result.SourceShapeId);
        // AND the searchShapeId we passed is stored
        Assert.Equal(1, result.SearchShapeId);
    }



    [Fact]
    public void test_IsSameDistance_8806()
    {
        List<string> sourceGrid = new List<string> {
            "    .   " ,
            "   .G   " ,
            "  .BUOY." ,
            ".AHOY.  " ,
            "   W.   " ,
            "   .    "};

        List<string> searchGrid = new List<string> {
            " .    ",
            " S .  ",
            " T.B  ",
            ".AHOY.",
            ".YAW. ",
            " .W.  ",
            "  S   ",
            "  E   ",
            "  R   ",
            "  .   "};

        List<string> words = new List<string> { "BUOY", "AHOY", "BOW", "GUY", "YAW", "STAY", "HAWSER" };

        ShapeModel sourceShape = GridList.ToShape(sourceGrid, words);
        ShapeModel searchShape = GridList.ToShape(searchGrid, words);

        var matches = ValidateMergeCalculator.GetMatches(sourceShape: sourceShape, searchShape: searchShape);

        var firstIsFlipped = (sourceShape.Placements[matches.FirstSourcePos].Z != searchShape.Placements[matches.FirstSearchPos].Z);

        bool sameDirectionIsOk = ValidateMergeCalculator.IsSameDistance(
            firstSourcePos: matches.FirstSourcePos,
            firstSearchPos: matches.FirstSearchPos,
            matches: matches.Matches,
            isFlipped: firstIsFlipped,
            sourceShape: sourceShape,
            searchShape: searchShape);

        Assert.True(sameDirectionIsOk);
    }


    [Fact]
    public void test_IsSameDirection_8806()
    {
        List<string> sourceGrid = new List<string> {
            "    .   " ,
            "   .G   " ,
            "  .BUOY." ,
            ".AHOY.  " ,
            "   W.   " ,
            "   .    "};

        List<string> searchGrid = new List<string> {
            " .    ",
            " S .  ",
            " T.B  ",
            ".AHOY.",
            ".YAW. ",
            " .W.  ",
            "  S   ",
            "  E   ",
            "  R   ",
            "  .   "};

        List<string> words = new List<string> { "BUOY", "AHOY", "BOW", "GUY", "YAW", "STAY", "HAWSER" };

        ShapeModel sourceShape = GridList.ToShape(sourceGrid, words);
        ShapeModel searchShape = GridList.ToShape(searchGrid, words);

        var matches = ValidateMergeCalculator.GetMatches(sourceShape: sourceShape, searchShape: searchShape);

        var firstIsFlipped = (sourceShape.Placements[matches.FirstSourcePos].Z != searchShape.Placements[matches.FirstSearchPos].Z);

        bool sameDirectionIsOk = ValidateMergeCalculator.IsSameDirection(
            firstSourcePos: matches.FirstSourcePos,
            matches: matches.Matches,
            firstIsFlipped: firstIsFlipped,
            sourceShape: sourceShape,
            searchShape: searchShape);

        Assert.True(sameDirectionIsOk);
    }


}

