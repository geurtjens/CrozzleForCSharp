using System;
namespace CrozzleInterfaces;


/// <summary>
/// The first parameter will always be shapes and we are operating on that collection
/// </summary>
public class ShapeList
{
    public static List<int> CreateMergeHistory(
        List<int> sourceShapeHistory,
        in List<int> searchShapeHistory)
    {
        if (sourceShapeHistory.Count == 1 && searchShapeHistory.Count == 1)
        {
            var source = sourceShapeHistory[0];
            var search = searchShapeHistory[0];
            if (source < search)
            {
                return new List<int> { source, search };
            }
            else
            {
                return new List<int> { search, source };
            }
        }

        var history = new List<int>();
        history.AddRange(sourceShapeHistory);
        history.AddRange(searchShapeHistory);

        return history;
    }


    /// <summary>
    /// Gets the word differences between a list of child shapes and the parent shape
    /// So we are getting what words that the child shapes has added to the parent
    /// </summary>
    /// <param name="parentShape"></param>
    /// <returns></returns>
    public static List<HashSet<int>> GetWordDifferences(in List<ShapeModel> shapes, in ShapeModel parentShape)

    {
        var result = new List<HashSet<int>>();

        HashSet<int> parentWords = parentShape.GetHashSetWordIds();
    
        for (int siblingId = 0; siblingId < shapes.Count; siblingId++)
        {
            HashSet<int> siblingWords = shapes[siblingId].GetHashSetWordIds();


            HashSet<int> missingWords = WordIdList.FindExtraWords(parentWords, siblingWords);
            result.Add(missingWords);
        }
        return result;
    }


    public static int GetShapeBySequence(in List<ShapeModel> shapes, string sequence)
    {
        for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
        {
            if (shapes[shapeId].WordSequence == sequence)
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
    public static void SetMergeHistories(in List<ShapeModel> shapes, in List<ShapeModel> referenceShapes)
    {

        for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
        {
            var referenceShapeId = GetShapeBySequence(shapes: referenceShapes, sequence: shapes[shapeId].WordSequence);


            if (referenceShapeId == -1)
            {
                Console.WriteLine("Something wrong, winning shapes are not in searchShapes");
            }
            else
            {
                shapes[shapeId].History.Add(referenceShapes[referenceShapeId].History[0]);
            }
        }
    }


    /// <summary>
    /// We want a deterministic way such that it always returns the same duplicate.
    /// To do this we need a special way of sorting that is always the same result.
    /// If it has the same wordSequence then score will always be same as will the area.
    /// Really we dont have to sort on those to remove duplicates.
    /// But what duplicate do we remove?
    /// </summary>
    /// <param name="shapes"></param>
    /// <returns></returns>
    public static List<ShapeModel> RemoveDuplicates(List<ShapeModel> shapes)
    {
        List<ShapeModel> sorted = shapes.OrderBy(e => e.WordSequence).ToList();
        int previous = 0;
        for (int current = 1; current < sorted.Count; current++)
        {
            previous = current - 1;
            if (sorted[current].WordSequence == sorted[previous].WordSequence)
            {
                sorted[current].IsValid = false;
            }
        }

        sorted = sorted.Where(e => e.IsValid == true).OrderByDescending(e => e.Score).ThenBy(e => e.Width * e.Height).ThenBy(e => e.WordSequence).ToList();
        return sorted;
    }


    public static List<ShapeModel> SortToFindDuplicates(in List<ShapeModel> shapes)
    {
        return (shapes.OrderBy(e => e.WordSequence).ToList());
    }


    public static List<ShapeModel> SortAndSetHistory(in List<ShapeModel> shapes)
    {
        //var result = shapes.OrderByDescending(e => e.Score).ThenBy(e => e.Placements.Count).ThenBy(e => e.Width * e.Height).ToList();

        var result = shapes.OrderByDescending(e => e.Score).ThenBy(e => e.WordSequence).ToList();


        for (int i = 0; i < (int)shapes.Count; i++)
        {
            result[i].History.Add(i);
        }
        return result;
    }


    


    /// Assuming that all shapes have at least one shapeId in their mergeHistory, lets get the last one from each shape
    /// - Parameter shapes: ShapeModel that definitely has their mergeHistory set
    /// - Returns: An array of shapeIds that was the last shapeId added to make up each shape
    public static List<int> GetLastMergeHistoryShapeId(in List<ShapeModel> shapes)
    {
        var result = new List<int>();
        for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
        {
            result.Add(shapes[shapeId].History.Last());
        }
        return result;
    }
}
