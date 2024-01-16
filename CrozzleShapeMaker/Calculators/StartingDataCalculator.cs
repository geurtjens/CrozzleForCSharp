using CrozzleInterfaces;

namespace CrozzleShapeMaker;

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
        in List<string> words,
        int rootShape,
        int rootWidth,
        bool useGuidedScores) //async -> (Int,[[Int]],[ShapeModel], WordIndexModelV2, [TreeNodeModel], [Int], Int, Int)
    {
        int widthMax = CompetitionList.findWidth(gameId);
        int heightMax = CompetitionList.findHeight(gameId);

        int winningScore = WinningWordList.findHighScore(gameId);

        /// Returns `searchShapes` which have `mergeHistories`
        List<ShapeModel> searchShapes = WinningShapesCalculator.execute(gameId, words);

        List<ShapeModel> winningShapes = WinningGameCalculator.execute(gameId, words);
        

        ShapeList.SetMergeHistories(winningShapes, searchShapes);

        
        //let winningShapeIds = ShapeCalculator.getLastMergeHistoryShapeId(shapes: winningShapes)

        var startingShapes = new List<ShapeModel>();
    
        if (rootWidth == 1)
        {
            startingShapes.Add(winningShapes[rootShape]);
            for (int i=0; i<rootWidth; i++) {
                if (i<winningShapes.Count) {
                    startingShapes.Add(winningShapes[i]);
                }
            }
        }
        else if (rootWidth > 1) {
            for (int i=0; i< winningShapes.Count; i++) {
                if (i < rootWidth)
                {
                    startingShapes.Add(winningShapes[i]);
                }
            }
        }

 

        var scoresMin = MinScoreList.Execute(gameId);
        if (useGuidedScores == false) {
            scoresMin = MinScoreList.Execute(0);
        }

        
        // the starting data is different
        StartingDataModel result = new StartingDataModel(gameId, searchShapes, winningShapes, startingShapes, words, scoresMin, widthMax, heightMax, winningScore);



        return result;
    }
}

