using System;
namespace CrozzleInterfaces
{
    public class ShapeList : List<ShapeModel>
    {

        public ShapeList()
        {

        }

        public ShapeList(List<ShapeList> listOfLists)
        {
            foreach(var item in listOfLists)
            {
                this.AddRange(item);
            }
        }


        /// Assuming that all shapes have at least one shapeId in their mergeHistory, lets get the last one from each shape
        /// - Parameter shapes: ShapeModel that definitely has their mergeHistory set
        /// - Returns: An array of shapeIds that was the last shapeId added to make up each shape
        public IntList getLastMergeHistoryShapeId() {
            var result = new IntList();
            for (int shapeId=0; shapeId< this.Count; shapeId++) {
                result.Add(this[shapeId].history.Last());
            }
            return result;
        }

        /// <summary>
        /// Gets the word differences between a list of child shapes and the parent shape
        /// So we are getting what words that the child shapes has added to the parent
        /// </summary>
        /// <param name="parentShape"></param>
        /// <returns></returns>
        public List<WordIdSet> getWordDifferences(in ShapeModel parentShape)

        {
            var result = new List<WordIdSet>();

            WordIdSet parentWords = parentShape.GetWordIds();
        
            for (int siblingId=0; siblingId <this.Count; siblingId++)
            {
                WordIdSet siblingWords = this[siblingId].GetWordIds();


                WordIdSet missingWords = parentWords.findExtraWords(siblingWords);
                result.Add(missingWords);
            }
            return result;
        }


        public int getShapeBySequence(string sequence)
        {
            for (int shapeId = 0; shapeId < this.Count; shapeId++)
            {
                if (this[shapeId].wordSequence == sequence)
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
        public void setMergeHistories(in List<ShapeModel> referenceShapes)
        {

            for (int shapeId = 0; shapeId < this.Count; shapeId++)
            {
                var referenceShapeId = getShapeBySequence(sequence: this[shapeId].wordSequence);


                if (referenceShapeId == -1)
                {
                    Console.WriteLine("Something wrong, winning shapes are not in searchShapes");
                }
                else
                {
                    this[shapeId].history.Add(referenceShapes[referenceShapeId].history[0]);
                }
            }
        }

        public ShapeList RemoveDuplicates()
        {
            var sorted = SortToFindDuplicates();
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

            return (ShapeList)sorted.Where(e => e.isValid == true).ToList();
        }


        public ShapeList SortToFindDuplicates()
        {
            return (ShapeList)this.OrderBy(e => e.score).ThenByDescending(e => e.placements.Count).ThenByDescending(e => e.width * e.height).ThenBy(e => e.wordSequence).ToList();

        }
        public ShapeList SortAndSetHistory()
        {
            var result = this.OrderBy(e => e.score).ThenByDescending(e => e.placements.Count).ThenByDescending(e => e.width * e.height).ThenBy(e => e.wordSequence).ToList();

            for (int i = 0; i < (int)this.Count; i++)
            {
                this[i].history.Add(i);
            }
            return (ShapeList) result;
        }
    }
}
