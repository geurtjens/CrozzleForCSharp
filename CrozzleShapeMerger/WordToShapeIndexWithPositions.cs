using System;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public class WordToShapeIndexWithPositions : List<List<WordPositionModel>>
{
	public WordToShapeIndexWithPositions(in List<ShapeModel> shapes, int wordCount)
	{
		List<List<WordPositionModel>> result = new List<List<WordPositionModel>>();
		for (int wordId=0; wordId<wordCount; wordId++)
		{
			result.Add(new List<WordPositionModel>());
		}


		for (int shapeId=0; shapeId< shapes.Count; shapeId++)
		{
			for (int wordPos = 0; wordPos < shapes[shapeId].Placements.Count; wordPos++)
			{
				int wordId = shapes[shapeId].Placements[wordPos].W;

				result[wordId].Add(new WordPositionModel(shapeId, wordPos));
			}
		}

        this.AddRange(result);
	}



    // <summary>
    /// Use pre calculated index to identify all shapes that contain the same words
    /// </summary>
    /// <param name="sourceShape"></param>
    /// <returns></returns>
    public List<IGrouping<int, SourceSearchPositionModel>> FindMatchesForWordList(in List<int> sourceShapeWords)
    {
        var matches = new List<SourceSearchPositionModel>();


        int wordCount = sourceShapeWords.Count;

        for (int sourcePosition = 0; sourcePosition < sourceShapeWords.Count; sourcePosition++)
        {
            int w = sourceShapeWords[sourcePosition];

            if (w != -1)
            {
                int matchCount = this[w].Count;

                for (int matchId = 0; matchId < matchCount; matchId++)
                {
                    matches.Add(new SourceSearchPositionModel(sourcePosition: sourcePosition, searchPosition: this[w][matchId].Position, searchShapeId: this[w][matchId].ShapeId));
                }
            }
        }

        var x = matches.GroupBy(e => e.SearchShapeId).Where(e => (int)e.Count() != wordCount).ToList();

        // If we stored the number of words per shape we should also lookup that it cannot be all the words in the other shape


        // x is great to return if you start with all the words in the shape
        // but perhaps the words that you want are only the last two words in a five word shape
        // We need to improve the implementation if we want to add proper positionals of the source shape.

        return x;
    }

}