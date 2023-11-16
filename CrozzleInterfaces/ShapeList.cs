using System;
namespace CrozzleInterfaces
{

    /// <summary>
    /// The first parameter will always be shapes and we are operating on that collection
    /// </summary>
    public class ShapeList
    {

        

        

        /// <summary>
        /// Gets the word differences between a list of child shapes and the parent shape
        /// So we are getting what words that the child shapes has added to the parent
        /// </summary>
        /// <param name="parentShape"></param>
        /// <returns></returns>
        public static List<HashSet<int>> getWordDifferences(in List<ShapeModel> shapes, in ShapeModel parentShape)

        {
            var result = new List<HashSet<int>>();

            HashSet<int> parentWords = parentShape.GetHashSetWordIds();
        
            for (int siblingId = 0; siblingId < shapes.Count; siblingId++)
            {
                HashSet<int> siblingWords = shapes[siblingId].GetHashSetWordIds();


                HashSet<int> missingWords = WordIdList.findExtraWords(parentWords, siblingWords);
                result.Add(missingWords);
            }
            return result;
        }


        public static int getShapeBySequence(in List<ShapeModel> shapes, string sequence)
        {
            for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
            {
                if (shapes[shapeId].wordSequence == sequence)
                {
                    return shapeId;
                }
            }
            return -1;
        }


        /// Set the mergeHistory for `shapes` based on the `referenceShapes` that already have mergeHistories
        /// We use this when we have `winningShapes` and want to give them the `mergeHistory` of `searchShapes`
        /// - Parameters:
        ///   - shapes: Array of shapes that have no `mergeHistory`
        ///   - referenceShapes: Array of shapes that have a `mergeHistory`
        public static void setMergeHistories(in List<ShapeModel> shapes, in List<ShapeModel> referenceShapes)
        {

            for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
            {
                var referenceShapeId = getShapeBySequence(shapes: shapes, sequence: shapes[shapeId].wordSequence);


                if (referenceShapeId == -1)
                {
                    Console.WriteLine("Something wrong, winning shapes are not in searchShapes");
                }
                else
                {
                    shapes[shapeId].history.Add(referenceShapes[referenceShapeId].history[0]);
                }
            }
        }

        public static List<ShapeModel> RemoveDuplicates(in List<ShapeModel> shapes)
        {
            var sorted = SortToFindDuplicates(shapes);
            int previous = 0;
            for (int current = 1; current < sorted.Count; current++)
            {
                previous = current - 1;
                if (sorted[current].score == sorted[previous].score &&
                    sorted[current].wordSequence == sorted[previous].wordSequence &&
                    sorted[current].width * sorted[current].height == sorted[previous].width * sorted[previous].height)
                {
                    sorted[current].SetToInvalid();
                }
            }

            return sorted.Where(e => e.isValid == true).ToList();
        }


        public static List<ShapeModel> SortToFindDuplicates(in List<ShapeModel> shapes)
        {
            return (shapes.OrderBy(e => e.score).ThenByDescending(e => e.placements.Count).ThenByDescending(e => e.width * e.height).ThenBy(e => e.wordSequence).ToList());

        }


        public static List<ShapeModel> SortAndSetHistory(in List<ShapeModel> shapes)
        {
            var result = shapes.OrderBy(e => e.score).ThenByDescending(e => e.placements.Count).ThenByDescending(e => e.width * e.height).ThenBy(e => e.wordSequence).ToList();

            for (int i = 0; i < (int)shapes.Count; i++)
            {
                result[i].history.Add(i);
            }
            return result;
        }


        


        /// Assuming that all shapes have at least one shapeId in their mergeHistory, lets get the last one from each shape
        /// - Parameter shapes: ShapeModel that definitely has their mergeHistory set
        /// - Returns: An array of shapeIds that was the last shapeId added to make up each shape
        public static List<int> getLastMergeHistoryShapeId(in List<ShapeModel> shapes)
        {
            var result = new List<int>();
            for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
            {
                result.Add(shapes[shapeId].history.Last());
            }
            return result;
        }
    }
}
