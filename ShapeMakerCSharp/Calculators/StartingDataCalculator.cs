﻿using System;
using CrozzleInterfaces;
using ShapeMakerCSharp.Calculators;


namespace ShapeMakerCSharp
{
	public class StartingDataCalculator
	{
        /// Get the starting shapes and parameters for the game
        /// - Parameters:
        ///   - gameId: game identifier which tells us the widthMax and heightMax etc
        ///   - words: words used in the puzzle
        ///   - rootWidth: when a positive number it gets the best `rootWidth` number of winning games.  But if its 0 or -1 then it is repurposed to be an exact winning shape so 0 is the same as rootWidth of 1 but -1 will start with a starting shape of winningShapes[1] for example
        ///   - useGuidedScores: guided scores can be turned off if you dont want to start with the highest scoring winning shape
        /// - Returns: lots of data used by the calculation
        public static StartingDataModel Execute(
            int gameId,
            in WordList words,
            int rootWidth,
            bool useGuidedScores) //async -> (Int,[[Int]],[ShapeModel], WordIndexModelV2, [TreeNodeModel], [Int], Int, Int)
        {
            int widthMax = CompetitionList.findWidth(gameId);
            int heightMax = CompetitionList.findHeight(gameId);

            int winningScore = WinningWordList.findHighScore(gameId);

            /// Returns `searchShapes` which have `mergeHistories`
            ShapeList searchShapes = WinningShapesCalculator.execute(gameId, words);

            ShapeList winningShapes = WinningGameCalculator.execute(gameId, words);


            winningShapes.setMergeHistories(searchShapes);

            
            //let winningShapeIds = ShapeCalculator.getLastMergeHistoryShapeId(shapes: winningShapes)

            var startingShapes = new ShapeList();
        
            if (rootWidth > 0)
            {
                for (int i=0; i<rootWidth; i++) {
                    if (i<winningShapes.Count) {
                        startingShapes.Add(winningShapes[i]);
                    }
                }
            }
            else if (rootWidth < 0) {
                int startingShapeIndex = rootWidth * -1;
                startingShapes.Add(winningShapes[startingShapeIndex]);
            }
            else {
                // If the root width is 0 then lets get all of the starting shapes
                // this is another improvement we are making when converting to c#



                
                // and we want to print all starting shapes so we can get the appropriate index
                for (int i=0; i< winningShapes.Count; i++) {
                    startingShapes.Add(winningShapes[i]);
                    Console.WriteLine(i);
                    Console.WriteLine(winningShapes[i].ToTextDebug(words));
                }
            }

     

            var scoresMin = new MinScoreList(gameId);
            if (useGuidedScores == false) {
                scoresMin = new MinScoreList();
            }

            StartingDataModel result = new StartingDataModel(searchShapes, winningShapes, startingShapes, words, scoresMin, widthMax, heightMax, winningScore);



            return result;
    }
	}
}
