using System;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public class MergeSizeValidation
{

    public static Tuple<bool, int, int, bool> Execute(
        in ShapeModel sourceShape,
        int sourcePos,
        in ShapeModel searchShape,
        int searchPos,
        int widthMax,
        int heightMax)
    {
        var sourcePlacement = sourceShape.Placements[sourcePos];
        var searchPlacement = searchShape.Placements[searchPos];

        var firstIsFlipped = (sourcePlacement.Z != searchPlacement.Z);

        var width = 0;
        var height = 0;

        if (firstIsFlipped == false)
        {
            width = GetWidth(width1: sourceShape.Width, x1: sourcePlacement.X, width2: searchShape.Width, x2: searchPlacement.X);
            height = GetHeight(height1: sourceShape.Height, y1: sourcePlacement.Y, height2: searchShape.Height, y2: searchPlacement.Y);
        }
        else
        {
            width = GetWidth(width1: sourceShape.Width, x1: sourcePlacement.X, width2: searchShape.Height, x2: searchPlacement.Y);
            height = GetHeight(height1: sourceShape.Height, y1: sourcePlacement.Y, height2: searchShape.Width, y2: searchPlacement.X);
        }

        var isValid = false;
        if ((width <= widthMax && height <= heightMax) || (width <= heightMax && height <= widthMax))
        {
            isValid = true;
        }
        return new Tuple<bool, int, int, bool>(isValid, width, height, firstIsFlipped);
    }

    private static int GetWidth(int width1, int x1, int width2, int x2)
    {
        var extra1 = width1 - x1;
        var extra2 = width2 - x2;
        return Math.Max(extra1, extra2) + Math.Max(x1, x2);
    }


    private static int GetHeight(int height1, int y1, int height2, int y2)
    {
        var extra1 = height1 - y1;
        var extra2 = height2 - y2;
        return Math.Max(extra1, extra2) + Math.Max(y1, y2);
    }
   
}