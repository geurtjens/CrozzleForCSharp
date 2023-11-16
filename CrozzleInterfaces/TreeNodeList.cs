using System;
using System.Collections.Generic;

namespace CrozzleInterfaces
{
    public static class TreeNodeList
    {

        public static List<TreeNodeModel> sortByBestDescendant(in List<TreeNodeModel> treeNodes)
        {
            return treeNodes.OrderBy(e => e.bestDescendant.score).ThenBy(e => e.bestDescendant.width * e.bestDescendant.height).ToList();
        }

        public static List<TreeNodeModel> applyBeamWidth(in List<TreeNodeModel> treeNodes, int beamWidth)
        {
            var result = new List<TreeNodeModel>();
            for (int treeNodeId = 0; treeNodeId < beamWidth; treeNodeId++)
            {
                if (treeNodeId < treeNodes.Count)
                {
                    result.Add(treeNodes[treeNodeId]);
                }
            }
            return result;
        }

        public static ShapeModel? getBestShape(in List<TreeNodeModel> treeNodes)
        {
            if (treeNodes.Count == 0) {
                return null;
            } else
            {
                return treeNodes[0].bestDescendant;
            }
        }


        public static int getBestScore(in List<TreeNodeModel> treeNodes)
        {
            if (treeNodes.Count == 0) {
                return 0;
            } else
            {
                return (int)(treeNodes[0].bestDescendant.score);
            }
        }

        public static int getBestParentNodeScore(in List<TreeNodeModel> treeNodes)
        {
            var result = 0;
            for (int treeNodeId = 0; treeNodeId < treeNodes.Count;treeNodeId ++)
            {
                if (treeNodes[treeNodeId].parentShape.score > result)
                {
                    result = treeNodes[treeNodeId].parentShape.score;
                }
            }
            return result;
        }


        public static int countShapesCreated(in List<TreeNodeModel> treeNodes)
        {
            var result = treeNodes.Count;
            for (int treeNodeId=0; treeNodeId<treeNodes.Count; treeNodeId++)
            {
                result += treeNodes[treeNodeId].childShapes.Count;
            }
            return result;
        }


        public static int countLeafs(in List<TreeNodeModel> treeNodes)
        {
            var count = 0;
            for (int treeNodeId = 0; treeNodeId < treeNodes.Count; treeNodeId++)
            {
                count += treeNodes[treeNodeId].childShapes.Count;
            }
            return count;
        }


        public static List<TreeNodeModel> SortWithWordSequence(in List<TreeNodeModel> treeNodes)
        {
            return (List<TreeNodeModel>)treeNodes.OrderBy(e => e.parentShape.score).ThenBy(e => e.parentShape.placements.Count).ThenBy(e => e.parentShape.width * e.parentShape.height).ThenBy(e => e.parentShape.wordSequence).ToList();
        }

        public static List<TreeNodeModel> RemoveDuplicates(in List<TreeNodeModel> treeNodes)
        {
            List<TreeNodeModel> sorted = SortWithWordSequence(treeNodes);

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

            return sorted.Where(e => e.isValid == true).ToList();
        }


        /// When we have common shapes then maybe these long set of shapes can be merged together
        /// So if we have `[1,2,3,4,5]` and another called `[5,6,7,8,9]` then its possible to get `[1,2,3,4,5,6,7,8,9]`
        /// - Parameters:
        ///   - treeNodes: A list of tree nodes
        ///   - maxCommonShapes: Maximum number of common shapes
        /// - Returns: treeNodeId, mergeableTreeNodeId, commonShapesBetweenBothOfThem
        public static List<Tuple<int,int,List<int>>> identifySiblingMerges(
            in List<TreeNodeModel> treeNodes,
            int minCommonShapes,
            int maxCommonShapes) 
        {


            var result = new List<Tuple<int, int, List<int>>>();


            if (treeNodes.Count < 2)
            {
                return result;
            }


    
            for (int sourceId = 0; sourceId < treeNodes.Count; sourceId++)
            {
                var sourceHistory = new HashSet<int>(treeNodes[sourceId].parentShape.history);

                for (int searchId = sourceId+1; searchId<treeNodes.Count; sourceId++)
                {
                    var searchHistory = new HashSet<int>(treeNodes[searchId].parentShape.history);


                    var commonShapes = (List<int>)new List<int>(sourceHistory.Intersect(searchHistory));
                    commonShapes.Sort();
                int commonShapeCount = commonShapes.Count;
                if (commonShapeCount >= minCommonShapes &&
                    commonShapeCount <= maxCommonShapes)
                    {
                        result.Add(new Tuple<int,int,List<int>>(sourceId, searchId, commonShapes));
                }
            }
        }
            return result;
    }



    }
}




