using System;
using CrozzleInterfaces;

namespace ShapeMakerCSharp
{
	public readonly record struct StartingDataModel
	{
		public readonly List<ShapeModel> searchShapes;

		public readonly List<ShapeModel> winningShapes;

        public readonly List<ShapeModel> startingShapes;

        public readonly List<string> words;

        public readonly List<int> scoresMin;

        public readonly int maxWidth;

		public readonly int maxHeight;

		public readonly int winningScore;


		public StartingDataModel(
			in List<ShapeModel> searchShapes,
			in List<ShapeModel> winningShapes,
			in List<ShapeModel> startingShapes,
			in List<string> words,
			in List<int> scoresMin,
			int maxWidth,
			int maxHeight,
			int winningScore
			)
		{
			this.searchShapes = searchShapes;
			this.winningShapes = winningShapes;
			this.startingShapes = startingShapes;
			this.words = words;
			this.maxWidth = maxWidth;
			this.maxHeight = maxHeight;
			this.winningScore = winningScore;
			this.scoresMin = scoresMin;
		}
	}
}

