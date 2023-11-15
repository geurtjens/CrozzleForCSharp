using System;
using System.Collections.Generic;

namespace CrozzleInterfaces
{
    public class TreeNodeList : List<TreeNodeModel>
    {

        public TreeNodeList sortByBestDescendant()
        {
            return (TreeNodeList) this.OrderBy(e => e.bestDescendant.score).ThenBy(e => e.bestDescendant.width * e.bestDescendant.height).ToList();
        }

        public TreeNodeList applyBeamWidth(int beamWidth)
        {
            var result = new TreeNodeList();
            for (int treeNodeId = 0; treeNodeId < beamWidth; treeNodeId++)
            {
                if (treeNodeId < this.Count)
                {
                    result.Add(this[treeNodeId]);
                }
            }
            return result;
        }

        public ShapeModel? getBestShape()
        {
            if (this.Count == 0) {
                return null;
            } else
            {
                return this[0].bestDescendant;
            }
        }


        public int getBestScore()
        {
            if (this.Count == 0) {
                return 0;
            } else
            {
                return (int)(this[0].bestDescendant.score);
            }
        }

        public int getBestParentNodeScore()
        {
            var result = 0;
            for (int treeNodeId = 0; treeNodeId < this.Count;treeNodeId ++)
            {
                if (this[treeNodeId].parentShape.score > result)
                {
                    result = this[treeNodeId].parentShape.score;
                }
            }
            return result;
        }


        public int countShapesCreated()
        {
            var result = this.Count;
            for (int treeNodeId=0; treeNodeId<this.Count; treeNodeId++)
            {
                result += this[treeNodeId].childShapes.Count;
            }
            return result;
        }


        public int countLeafs()
        {
            var count = 0;
            for (int treeNodeId = 0; treeNodeId < this.Count; treeNodeId++)
            {
                count += this[treeNodeId].childShapes.Count;
            }
            return count;
        }


        public TreeNodeList SortWithWordSequence()
        {
            return (TreeNodeList)this.OrderBy(e => e.parentShape.score).ThenBy(e => e.parentShape.placements.Count).ThenBy(e => e.parentShape.width * e.parentShape.height).ThenBy(e => e.parentShape.wordSequence).ToList();
        }

        public TreeNodeList RemoveDuplicates()
        {
            TreeNodeList sorted = SortWithWordSequence();

            int previous = 0;
            for (int current = 1; current < sorted.Count; current++)
            {
                previous = current - 1;
                if (sorted[current].parentShape.score == sorted[previous].parentShape.score &&
                    sorted[current].parentShape.wordSequence == sorted[previous].parentShape.wordSequence)
                {
                    sorted[current].SetToInvalid();
                }
            }

            return (TreeNodeList)sorted.Where(e => e.isValid == true).ToList();
        }


        /// When we have common shapes then maybe these long set of shapes can be merged together
        /// So if we have `[1,2,3,4,5]` and another called `[5,6,7,8,9]` then its possible to get `[1,2,3,4,5,6,7,8,9]`
        /// - Parameters:
        ///   - treeNodes: A list of tree nodes
        ///   - maxCommonShapes: Maximum number of common shapes
        /// - Returns: treeNodeId, mergeableTreeNodeId, commonShapesBetweenBothOfThem
        public List<Tuple<int,int,IntList>> identifySiblingMerges(
            
            int minCommonShapes,
            int maxCommonShapes) 
        {


            var result = new List<Tuple<int, int, IntList>>();


            if (this.Count < 2)
            {
                return result;
            }


    
            for (int sourceId = 0; sourceId < this.Count; sourceId++)
            {
                var sourceHistory = new HashSet<int>(this[sourceId].parentShape.history);

                for (int searchId = sourceId+1; searchId<this.Count; sourceId++)
                {
                    var searchHistory = new HashSet<int>(this[searchId].parentShape.history);


                    var commonShapes = (IntList)new List<int>(sourceHistory.Intersect(searchHistory));
                    commonShapes.Sort();
                int commonShapeCount = commonShapes.Count;
                if (commonShapeCount >= minCommonShapes &&
                    commonShapeCount <= maxCommonShapes)
                    {
                        result.Add(new Tuple<int,int,IntList>(sourceId, searchId, commonShapes));
                }
            }
        }
            return result;
    }



    }
}




