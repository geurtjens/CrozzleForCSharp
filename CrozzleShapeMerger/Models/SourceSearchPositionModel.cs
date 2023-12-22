namespace CrozzleShapeMerger;

public readonly struct SourceSearchPositionModel
{
    public readonly int SourcePosition;
    public readonly int SearchShapeId;
    public readonly int SearchPosition;

    public SourceSearchPositionModel(int sourcePosition, int searchShapeId, int searchPosition)
    {
        SourcePosition = sourcePosition;
        SearchShapeId = searchShapeId;
        SearchPosition = searchPosition;
    }
}