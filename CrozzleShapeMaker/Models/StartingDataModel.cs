using System;
using CrozzleInterfaces;

namespace CrozzleShapeMaker;

public readonly record struct StartingDataModel
{
	public readonly int gameId;

	public readonly List<ShapeModel> searchShapes;

	public readonly List<ShapeModel> winningShapes;

    public readonly List<ShapeModel> startingShapes;

    public readonly List<string> words;

    public readonly List<int> scoresMin;

    public readonly int maxWidth;

	public readonly int maxHeight;

	public readonly int winningScore;

	public readonly WordToShapeIndex wordIndex;


	public StartingDataModel(
		int gameId,
		in List<ShapeModel> searchShapes,
		in List<ShapeModel> winningShapes,
		in List<ShapeModel> startingShapes,
		in List<string> words,
		in List<int> scoresMin,
		in WordToShapeIndex wordIndex,
		int maxWidth,
		int maxHeight,
		int winningScore
		)
	{
		this.gameId = gameId;
		this.searchShapes = searchShapes;
		this.winningShapes = winningShapes;
		this.startingShapes = startingShapes;
		this.words = words;
		this.wordIndex = wordIndex;
		this.maxWidth = maxWidth;
		this.maxHeight = maxHeight;
		this.winningScore = winningScore;
		this.scoresMin = scoresMin;
	}
}

