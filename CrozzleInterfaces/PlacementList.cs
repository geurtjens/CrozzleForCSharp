using System;
using CrozzleInterfaces;

namespace CrozzleInterfaces;

public class PlacementList
{

	public static List<PlacementModel> Flip(in List<PlacementModel> placements)
	{
        var flippedPlacements = new List<PlacementModel>();
        foreach (var p in placements)
        {
            flippedPlacements.Add(new PlacementModel(p.W, p.Y, p.X, !p.Z, p.L));
        }
        return flippedPlacements;
    }


    public static List<int> GetWords(in List<PlacementModel> placements)
    {
        var result = new List<int>();
        foreach(var p in placements)
        {
            result.Add(p.W);
        }
        return result;
    }


    public static List<PlacementModel> SortByWord(in List<PlacementModel> placements)
    {
        return placements.OrderBy(o => o.W).ToList();
    }


    public static bool ShouldBeFlipped(in List<PlacementModel> placements)
    {
        return (placements[0].Z == false);
    }


    public static string GetWordSequence(in List<PlacementModel> placements)
    {
        int wordCount = placements.Count;

        var result = "";
        for (int i = 0; i < wordCount; i++)
        {
            result += $"{placements[i].W},";
        }

        for (int i = 0; i < wordCount; i++)
        {
            result += $"{placements[i].X},";
        }

        for (int i = 0; i < wordCount; i++)
        {

            result += $"{placements[i].Y},";
        }

        for (int i = 0; i < wordCount; i++)
        {
            
            if (placements[i].Z == true)
            {
                result += "1";
            }
            else
            {
                result += "0";
            }
        }
        return result;
    }


    /// calculates `width` from `placements`
    public static byte GetWidth(in List<PlacementModel> placements)
    {
        var maxWidth = 0;
        foreach (PlacementModel placement in placements)
        {
            if (placement.Z)
            {
                int end = (int)(placement.X + placement.L);
                if (maxWidth < end)
                {
                    maxWidth = end;
                }
            }
            else
            {
                int end = (int)(placement.X);
                if (maxWidth < end)
                {
                    maxWidth = end;
                }
            }
        }
        return (byte)(maxWidth + 2);
    }


    public static byte GetHeight(in List<PlacementModel> placements)
    {
        var maxHeight = 0;
        foreach (PlacementModel placement in placements)
        {
            if (placement.Z == false) {
                var end = (int)(placement.Y + placement.L);
                if (maxHeight < end) {
                    maxHeight = end;
                }
            }
            else
            {
                int end = (int)(placement.Y);
                if (maxHeight < end) {
                    maxHeight = end;
            }
            }
        }
        return (byte)(maxHeight + 2);
    }
}