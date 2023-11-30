using System;
using CrozzleInterfaces;
using CrozzleShapeMerger;

namespace CrozzleShapeMerger_Tests
{
	public class WordToShapeIndexWithPositions_Tests
	{
        [Fact]
        public void test_FindMatchesForWordList_Hymn_Merry()
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

            WordToShapeIndexWithPositions index = new WordToShapeIndexWithPositions(shapes, words.Count);

            // HYMN is in both shapes
            List<int> wordListWithTwoShapes = new List<int> { 0, 1 };

            var matchingPositions = index.FindMatchesForWordList(wordListWithTwoShapes);

            Assert.Single(matchingPositions);
            Assert.Equal(1, matchingPositions[0].Key);

            var listOfAnswers = matchingPositions[0].ToList();
            Assert.Single(listOfAnswers);

            Assert.Equal(1, listOfAnswers[0].SourcePosition);
            Assert.Equal(0, listOfAnswers[0].SearchPosition);
        }


        [Fact]
        public void test_FindMatchesForWordList_Hynm_Star_White()
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

            WordToShapeIndexWithPositions index = new WordToShapeIndexWithPositions(shapes, words.Count);

            // HYMN is in both shapes
            List<int> wordListWithTwoShapes = new List<int> { 1, 2, 3 };

            var matchingPositions = index.FindMatchesForWordList(wordListWithTwoShapes);

            Assert.Single(matchingPositions);
            Assert.Equal(0, matchingPositions[0].Key);

            var listOfAnswers = matchingPositions[0].ToList();
            Assert.Single(listOfAnswers);

            Assert.Equal(0, listOfAnswers[0].SourcePosition);
            Assert.Equal(1, listOfAnswers[0].SearchPosition);

            // The structure is difficult to work with so hopefully its fast to execute
        }



    }
}

