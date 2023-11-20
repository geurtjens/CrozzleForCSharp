using System;
using CrozzleInterfaces;


namespace CrozzleShapeMerger;

public class StartingTreeNodeCalculator
{
    public static List<TreeNodeModel> Execute(
        in List<ShapeModel> startingShapes,
        in List<ShapeModel> searchShapes,
        in List<string> words,
        in List<int> scoresMin,
        int widthMax,
        int heightMax,
        in WordIndexModelV2 searchWordIndex)
    {

        var treeNodes = new List<TreeNodeModel>();


        for (int startingShapeId = 0; startingShapeId < startingShapes.Count; startingShapeId++)
        {

            var childShapes = MergeCalculatorV2.ExecuteDifferentShapesAsync(
                sourceShapes: new List<ShapeModel> { startingShapes[startingShapeId]},
                searchShapes: searchShapes,
                searchWordIndex: searchWordIndex,
                sourceMax: 1,
                searchMax: searchShapes.Count,
                words: words,
                scoresMin: scoresMin,
                widthMax: widthMax,
                heightMax: heightMax);

            childShapes = ShapeList.RemoveDuplicates(childShapes).OrderByDescending(e=> e.score).ToList();
            
            var treeNode = new TreeNodeModel(
                parentShape: startingShapes[startingShapeId],
                childShapes: childShapes,
                bestDescendant: childShapes[0],
                siblingCount: 0,
                shapesCreated: childShapes.Count);

            treeNodes.Add(treeNode);
        }
        return treeNodes;
    }
}

