using System;
using CrozzleInterfaces;

namespace CrozzleInterfaces
{
	public class PlacementList
	{

		public static List<PlacementModel> Flip(in List<PlacementModel> placements)
		{
            var flippedPlacements = new List<PlacementModel>();
            foreach (var p in placements)
            {
                flippedPlacements.Add(new PlacementModel(p.w, p.y, p.x, !p.z, p.l));
            }
            return flippedPlacements;
        }


        public static List<int> GetWords(in List<PlacementModel> placements)
        {
            var result = new List<int>();
            foreach(var p in placements)
            {
                result.Add(p.w);
            }
            return result;
        }


        public static List<PlacementModel> SortByWord(in List<PlacementModel> placements)
        {
            return placements.OrderBy(o => o.w).ToList();
        }


        public static bool ShouldBeFlipped(in List<PlacementModel> placements)
        {
            return (placements[0].z == false);
        }


        public static string GetWordSequence(in List<PlacementModel> placements)
        {
            int wordCount = placements.Count;

            var result = "";
            for (int i = 0; i < wordCount; i++)
            {
                result += $"{placements[i].w},";
            }

            for (int i = 0; i < wordCount; i++)
            {
                result += $"{placements[i].x},";
            }

            for (int i = 0; i < wordCount; i++)
            {

                result += $"{placements[i].y},";
            }

            for (int i = 0; i < wordCount; i++)
            {
                
                if (placements[i].z == true)
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
        public static byte width(in List<PlacementModel> placements)
        {
            var maxWidth = 0;
            foreach (PlacementModel placement in placements)
            {
                if (placement.z)
                {
                    int end = (int)(placement.x + placement.l);
                    if (maxWidth < end)
                    {
                        maxWidth = end;
                    }
                }
                else
                {
                    int end = (int)(placement.x);
                    if (maxWidth < end)
                    {
                        maxWidth = end;
                    }
                }
            }
            return (byte)(maxWidth + 2);
        }


        public static byte height(in List<PlacementModel> placements)
        {
            var maxHeight = 0;
            foreach (PlacementModel placement in placements)
            {
                if (placement.z == false) {
                    var end = (int)(placement.y + placement.l);
                    if (maxHeight < end) {
                        maxHeight = end;
                    }
                }
                else
                {
                    int end = (int)(placement.y);
                    if (maxHeight < end) {
                        maxHeight = end;
                }
                }
            }
            return (byte)(maxHeight + 2);
        }
    }
}