using System;
using CrozzleInterfaces;

namespace CrozzleInterfaces
{
	public class PlacementList : List<PlacementModel>
	{
		public PlacementList Flip()
		{
            var flippedPlacements = new PlacementList();
            foreach (var p in this)
            {
                flippedPlacements.Add(new PlacementModel(p.w, p.y, p.x, !p.z, p.l));
            }
            return flippedPlacements;
        }


        public HashSet<int> GetWords()
        {
            var result = new HashSet<int>();
            foreach(var p in this)
            {
                result.Add(p.w);
            }
            return result;
        }

        public PlacementList SortByWord()
        {
            return (PlacementList)this.OrderBy(o => o.w).ToList();
        }

        public bool ShouldBeFlipped()
        {
            return (this[0].z == false);
        }

        public string GetWordSequence()
        {
            int wordCount = this.Count;

            var result = "";
            for (int i = 0; i < wordCount; i++)
            {

                if (result != "")
                {
                    result += ",";
                }
                result += $"{this[i].w},";
            }

            for (int i = 0; i < wordCount; i++)
            {
                result += $"{this[i].x},";
            }

            for (int i = 0; i < wordCount; i++)
            {

                result += $"{this[i].y}";
            }

            for (int i = 0; i < wordCount; i++)
            {
                if (result != "")
                {
                    result += ",";
                }
                if (this[i].z == true)
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
        public int width()
        {
            var maxWidth = 0;
            foreach (PlacementModel placement in this)
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
            return (int)(maxWidth + 2);
        }


        /// calculates `height` from `placements`
        public int height()
        {
            var maxHeight = 0;
            foreach (PlacementModel placement in this)
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
            return (int)(maxHeight + 2);
        }
    }
}

