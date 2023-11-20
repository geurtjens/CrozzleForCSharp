namespace CrozzleShapeMaker;

public enum RectangleType
{
    /// rectangle with all sides connected
    rectangle,
    /// rectangle with all sides except for `topLeft` connected
    topLeft,
    /// rectangle with all sides except for `topRight` connected
    topRight,
    /// rectangle with all sides except for `bottomLeft` connected
    bottomLeft,
    /// rectangle with all sides except for `bottomRight` connected
    bottomRight
}

