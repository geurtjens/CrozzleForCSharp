using System;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public class MergeSizeValidation
{

    public static Tuple<bool, int, int, bool> execute(
        in ShapeModel sourceShape, int sourcePos,
        in ShapeModel searchShape, int searchPos,
        int widthMax, int heightMax)
    {
        var sourcePlacement = sourceShape.placements[sourcePos];
        var searchPlacement = searchShape.placements[searchPos];

        var firstIsFlipped = (sourcePlacement.z != searchPlacement.z);

        var width = 0;
        var height = 0;

        if (firstIsFlipped == false)
        {
            width = getWidth(width1: sourceShape.width, x1: sourcePlacement.x, width2: searchShape.width, x2: searchPlacement.x);
            height = getHeight(height1: sourceShape.height, y1: sourcePlacement.y, height2: searchShape.height, y2: searchPlacement.y);
        }
        else
        {
            width = getWidth(width1: sourceShape.width, x1: sourcePlacement.x, width2: searchShape.height, x2: searchPlacement.y);
            height = getHeight(height1: sourceShape.height, y1: sourcePlacement.y, height2: searchShape.width, y2: searchPlacement.x);
        }

        var isValid = false;
        if ((width <= widthMax && height <= heightMax) || (width <= heightMax && height <= widthMax))
        {
            isValid = true;
        }
        return new Tuple<bool, int, int, bool>(isValid, width, height, firstIsFlipped);
    }

    private static int getWidth(int width1, int x1, int width2, int x2)
    {
        var extra1 = width1 - x1;
        var extra2 = width2 - x2;
        return Math.Max(extra1, extra2) + Math.Max(x1, x2);
    }


    private static int getHeight(int height1, int y1, int height2, int y2)
    {
        var extra1 = height1 - y1;
        var extra2 = height2 - y2;
        return Math.Max(extra1, extra2) + Math.Max(y1, y2);
    }


    
}











