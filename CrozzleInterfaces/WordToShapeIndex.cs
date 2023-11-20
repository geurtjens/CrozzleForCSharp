using System;
namespace CrozzleInterfaces;

public readonly record struct WordToShapeIndex
{
    public readonly List<List<int>> index;
    public readonly int wordCount;
    public readonly int interlockability;
    public readonly int shapeCount;


    public WordToShapeIndex(in List<ShapeModel> shapes, int wordCount)
    {
        
        var indexTemp = new List<List<int>>();
        for (int wordId = 0; wordId < wordCount; wordId++)
        {
            indexTemp.Add(new List<int>());
        }

        for (int shapeId = 0; shapeId < shapes.Count; shapeId++)
        {
            for (int placementId = 0; placementId < shapes[shapeId].placements.Count; placementId++)
            {
                int w = (int)(shapes[shapeId].placements[placementId].w);
                indexTemp[w].Add(shapeId);
            }
        }
        

        int interlockabilityTemp = 0;
        for (int wordId = 0; wordId < wordCount; wordId++)
        {
            interlockabilityTemp += indexTemp[wordId].Count;
        }

        this.wordCount = wordCount;
        this.index = indexTemp;
        this.interlockability = interlockabilityTemp;
        this.shapeCount = shapes.Count;
    }


    public string WordToShapeCountStatisticsCsv()
    {
        string result = "";
        for (int wordId = 0; wordId < this.index.Count; wordId++)
        {
            if (result != "")
            {
                result += ",";
            }
            result += this.index[wordId].Count;
        }
        return result;
    }


    public string StatisticsToJson()
    { 
        string statisticsText = WordToShapeCountStatisticsCsv();
        var result = "{" + $"\"wordCount\": {this.wordCount}, \"shapeCount\": {this.shapeCount}, \"wordToShapeSum\": {this.interlockability}, \"wordToShapeCount\": \"{statisticsText}\"" + "}";

        return result;
    }
}

