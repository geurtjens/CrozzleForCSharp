using System;
using System.Collections.Generic;

namespace CrozzleInterfaces;

public static class TreeNodeList
{

    public static List<TreeNodeModel> SortByBestDescendant(in List<TreeNodeModel> treeNodes)
    {
        return treeNodes.OrderByDescending(e => e.BestDescendant.Score).ThenBy(e => e.BestDescendant.Placements.Count).ThenBy(e => e.BestDescendant.Width * e.BestDescendant.Height).ToList();
    }

    public static List<TreeNodeModel> ApplyBeamWidth(in List<TreeNodeModel> treeNodes, int beamWidth)
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

    public static ShapeModel? GetBestShape(in List<TreeNodeModel> treeNodes)
    {
        if (treeNodes.Count == 0) {
            return null;
        } else
        {
            return treeNodes[0].BestDescendant;
        }
    }


    public static int GetBestScore(in List<TreeNodeModel> treeNodes)
    {
        if (treeNodes.Count == 0) {
            return 0;
        } else
        {
            return (int)(treeNodes[0].BestDescendant.Score);
        }
    }

    public static int GetBestParentNodeScore(in List<TreeNodeModel> treeNodes)
    {
        var result = 0;
        for (int treeNodeId = 0; treeNodeId < treeNodes.Count;treeNodeId ++)
        {
            if (treeNodes[treeNodeId].ParentShape.Score > result)
            {
                result = treeNodes[treeNodeId].ParentShape.Score;
            }
        }
        return result;
    }


    public static int CountShapesCreated(in List<TreeNodeModel> treeNodes)
    {
        var result = treeNodes.Count;
        for (int treeNodeId=0; treeNodeId<treeNodes.Count; treeNodeId++)
        {
            result += treeNodes[treeNodeId].ChildShapes.Count;
        }
        return result;
    }


    public static int CountLeafs(in List<TreeNodeModel> treeNodes)
    {
        var count = 0;
        for (int treeNodeId = 0; treeNodeId < treeNodes.Count; treeNodeId++)
        {
            count += treeNodes[treeNodeId].ChildShapes.Count;
        }
        return count;
    }


    public static List<TreeNodeModel> SortWithWordSequence(in List<TreeNodeModel> treeNodes)
    {
        return treeNodes.OrderByDescending(e => e.ParentShape.Score).ThenBy(e => e.ParentShape.Placements.Count).ThenBy(e => e.ParentShape.Width * e.ParentShape.Height).ThenBy(e => e.ParentShape.WordSequence).ToList();
    }

    public static List<TreeNodeModel> RemoveDuplicates(in List<TreeNodeModel> treeNodes)
    {
        List<TreeNodeModel> sorted = SortWithWordSequence(treeNodes);

        int previous = 0;
        for (int current = 1; current < sorted.Count; current++)
        {
            previous = current - 1;
            if (sorted[current].ParentShape.Score == sorted[previous].ParentShape.Score &&
                sorted[current].ParentShape.WordSequence == sorted[previous].ParentShape.WordSequence)
            {
                sorted[current].SetToInvalid();
            }
        }

        return sorted.Where(e => e.IsValid == true).ToList();
    }


    /// When we have common shapes then maybe these long set of shapes can be merged together
    /// So if we have `[1,2,3,4,5]` and another called `[5,6,7,8,9]` then its possible to get `[1,2,3,4,5,6,7,8,9]`
    /// - Parameters:
    ///   - treeNodes: A list of tree nodes
    ///   - maxCommonShapes: Maximum number of common shapes
    /// - Returns: treeNodeId, mergeableTreeNodeId, commonShapesBetweenBothOfThem
    public static List<Tuple<int,int,List<int>>> IdentifySiblingMerges(
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
            var sourceHistory = new HashSet<int>(treeNodes[sourceId].ParentShape.History);

            for (int searchId = sourceId+1; searchId<treeNodes.Count; sourceId++)
            {
                var searchHistory = new HashSet<int>(treeNodes[searchId].ParentShape.History);


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