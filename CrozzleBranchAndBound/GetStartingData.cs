using System;
using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleShapeMerger;

namespace CrozzleBranchAndBound;

public class GetStartingData
{
    public static Tuple<int, List<ShapeModel>, WordIndexModelV2, List<TreeNodeModel>, List<int>, int, int>
        Execute(int gameId, List<string> words, int rootWidth, bool useGuidedScores)
    {
        GameModel game = GameList.FindGame(gameId);
        int widthMax = game.WidthMax;
        int heightMax = game.HeightMax;
        int winningScore = game.WinningScore;

        StartingDataModel startingDataModel = StartingDataCalculator.Execute(gameId, words, rootWidth, useGuidedScores);

        WordIndexModelV2 searchWordIndex = new WordIndexModelV2(shapes: startingDataModel.searchShapes, wordCount: startingDataModel.words.Count);

        List<TreeNodeModel> startingTreeNodes = StartingTreeNodeCalculator.Execute(
            startingDataModel.startingShapes,
            startingDataModel.searchShapes,
            startingDataModel.words,
            startingDataModel.scoresMin,
            startingDataModel.maxWidth,
            startingDataModel.maxHeight,
            searchWordIndex);

        WordIndexModelV2 wordIndex = new WordIndexModelV2(startingDataModel.searchShapes, words.Count);

        return new Tuple<int, List<ShapeModel>, WordIndexModelV2, List<TreeNodeModel>, List<int>, int, int>(
            winningScore, startingDataModel.searchShapes, wordIndex, startingTreeNodes, startingDataModel.scoresMin, widthMax, heightMax);
    }
}

