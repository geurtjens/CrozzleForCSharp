using System;
using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleShapeMerger;

namespace CrozzleShapeMerger_Tests;

public class MergeCalculatorV2_Tests
{
	[Fact]
	public void test_MergeTwoShapes_8806()
	{
		List<string> words = WinningWordList.findWinningWords(8806);

		List<string> a = new List<string> {
			"    .   " ,
			"   .G   " ,
			"  .BUOY." ,
			".AHOY.  " ,
			"   W.   " ,
			"   .    "};

		ShapeModel shapeA = GridList.ToShape(a, words);

		Assert.Equal(4, shapeA.Placements.Count);


		List<string> b = new List<string> {
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

		ShapeModel shapeB = GridList.ToShape(b, words);
        Assert.Equal(5, shapeB.Placements.Count);

        List<int> scoresMin = MinScoreList.Execute(0);
		ShapeModel? shapeOrNull = MergeCalculatorV2.MergeTwoShapes(shapeA, shapeB, words, 17, 12, scoresMin);

		Assert.NotNull(shapeOrNull);

		ShapeModel shape = (ShapeModel)shapeOrNull;

		string expectedText =
			"   ..     \n" +
			".STAY.    \n" +
			"  .HAWSER.\n" +
			" .BOW.    \n" +
			".GUY.     \n" +
			"  O.      \n" +
			"  Y       \n" +
			"  .       ";

        string actualText = shape.ToTextDebug(words);

		Assert.Equal(expectedText, actualText);
    }
}

