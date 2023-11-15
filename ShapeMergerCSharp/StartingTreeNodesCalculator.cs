using System;
using CrozzleInterfaces;


namespace ShapeMergerCSharp
{
    public class StartingTreeNodeCalculator
    {
        public static TreeNodeList Execute(
            in List<ShapeModel> startingShapes,
            in List<ShapeModel> searchShapes,
            in WordList words,
            in MinScoreList scoresMin,
            int widthMax,
            int heightMax,
            in WordIndexModelV2 searchWordIndex)
        {

            var treeNodes = new TreeNodeList();


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

                childShapes = ShapeList.RemoveDuplicates(childShapes).OrderBy(e=> e.score).ToList();
                
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
}

