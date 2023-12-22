using CrozzleInterfaces;
using CrozzleShapeMerger;

namespace CrozzleBranchAndBound
{
    public class SiblingMergeCalculator
    {

        /// We have `expanded a shape` to get a lot of new shapes.  All these shapes come from the same `parent shape` and so are `sibling shapes`.
        /// We know that they all can expand the parent and in fact are `different choices for expanding the parent`.
        /// So can these different choices also `expand the sibling`
        /// Now if `sibling A can expand sibling B` then it follows that `sibling B will expand sibling A` and create a duplicate





        //        public static func GetStartingData(gameId: Int) -> (ShapeModel, [ShapeModel], [ShapeModel], [Int], [String], Int, Int, Int, WordIndexModelV2,[[Int]]) {
        //    let(winningShapes, words, widthMax, heightMax, winningScore, startingShapeId) = StandardSearchAlgorithms.winningsMore(gameId: gameId)

        //    let wordsInt = WordCalculator.WordsToInt(words: words)


        //    let searchShapes = winningShapes



        //    let wordIndex = WordIndexModelV2(shapes: searchShapes, wordCount: words.count)


        //    let parentShape = searchShapes[startingShapeId]



        //    let scoresMin = StrategyCalculator.GetScoreMins(gameId: gameId)


        //    var childShapes = MergeCalculatorV2.ExecuteDifferentShapesSync(
        //        sourceShapes: [parentShape],
        //        searchShapes: searchShapes,
        //        searchWordIndex: wordIndex,
        //        sourceMax: 1,
        //        searchMax: searchShapes.count,
        //        words: words,
        //        wordsInt: wordsInt,
        //        scoresMin: scoresMin,
        //        widthMax: widthMax, heightMax: heightMax)


        //    childShapes.sort { $0.score > $1.score
        //    }

        //    return (parentShape, childShapes, searchShapes, scoresMin, words, widthMax, heightMax, winningScore, wordIndex, wordsInt)
        //}


        public static List<ShapeModel> GetAllMatchingShapes(
            WordIndexModelV2 wordIndex,
            in ShapeModel sourceShape,
            int sourceShapeId,
            in List<ShapeModel> searchShapes,
            in List<string> words,
            in List<int> scoresMin,
            int widthMax,
            int heightMax)
        {
            var bestShape = sourceShape;
            var newShapes = MergeCalculatorV2.ExecuteDifferentShapesSync(
                sourceShapes: new List<ShapeModel> { sourceShape },
                searchShapes: searchShapes,
                searchWordIndex: wordIndex,
                sourceMax: 1,
                searchMax: searchShapes.Count,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);

            foreach (ShapeModel newShape in newShapes)
            {
                if (bestShape.Score < newShape.Score)
                {
                    bestShape = newShape;
                }
            }

            return newShapes;
        }
    }

}


