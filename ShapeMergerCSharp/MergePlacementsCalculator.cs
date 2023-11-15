using System;
using CrozzleInterfaces;
using System.Runtime.Intrinsics.X86;

namespace ShapeMergerCSharp
{
	public class MergePlacementsCalculator
	{
        /// <summary>
        /// We are taking the placements from the source shape and search shape and try to merge them together
        /// </summary>
        /// <param name="sourcePlacements"></param>
        /// <param name="searchPlacements"></param>
        /// <returns></returns>
        public static PlacementList Execute(
            in PlacementList sourcePlacements,
            in PlacementList searchPlacements)
        {
            // First we find the common placement
            Tuple<int, int> commonWordPositions = FindFirstCommonPosition(sourcePlacements, searchPlacements);

            if (commonWordPositions.Item1 == -1)
            {
                return new PlacementList();
            }

            int commonSourceId = commonWordPositions.Item1;
            int commonSearchId = commonWordPositions.Item2;

            bool flip = sourcePlacements[commonSourceId].z != searchPlacements[commonSearchId].z;

            

            // So we know the common word and we have flipped to same orientation
            return Execute(sourcePlacements, searchPlacements, commonSourceId, commonSearchId, flip);

        }

        /// <summary>
        /// Assume there has been pre-processing and we already know what we need to search for then we run this one
        /// </summary>
        /// <param name="sourcePlacements"></param>
        /// <param name="searchPlacements"></param>
        /// <param name="commonSourceId">Position in the sourcePlacements that has a common word</param>
        /// <param name="commonSearchId">Position in `searchPlacements` that has a common word</param>
        /// <param name="flip">Does this common word have an opposite orientation, like one is horizontal and other is vertical</param>
        /// <returns></returns>
        public static PlacementList Execute(
            PlacementList sourcePlacements,
            PlacementList searchPlacements,
            int commonSourceId,
            int commonSearchId,
            bool flip)
        {

    
            // The first thing we need to do is calculate the offset of the common word placement for both sides
            var (sourceOffsetX, sourceOffsetY, searchOffsetX, searchOffsetY) = CalculateOffsets(
                sourcePlacements[commonSourceId].x,
                sourcePlacements[commonSourceId].y,
                searchPlacements[commonSearchId].x,
                searchPlacements[commonSearchId].y,
                flip);

            sourcePlacements = ApplyOffsets(sourcePlacements, sourceOffsetX, sourceOffsetY);

            // Here we could apply offsets and flip at the same time if flipping was required
            // We could even remove duplicates in this one, so make it faster again.

            // We could go even faster if we are passed in the common words preprocessed
            var excludedWords = FindCommonWords(sourcePlacements, searchPlacements);

            if (flip == true)
            {
                // We are going to flip each placement and then apply the offset
                searchPlacements = ApplyOffsetsForSearchWithFlip(searchPlacements, searchOffsetX, searchOffsetY, excludedWords);
            } else
            {
                // Apply offset and at the same time remove any common words
                searchPlacements = ApplyOffsetsForSearch(searchPlacements, searchOffsetX, searchOffsetY, excludedWords);
            }
            var result = sourcePlacements;

            result.AddRange(searchPlacements);
            // We do not want to add the common one

            return result;
        }


        public static HashSet<int> FindCommonWords(in PlacementList sourcePlacements, in PlacementList searchPlacements)
        {
            var sourceWords = sourcePlacements.GetWords();
            var searchWords = searchPlacements.GetWords();
            var excludedWords = sourceWords.Intersect(searchWords).ToHashSet();
            return excludedWords;
        }
        

        private static Tuple<int,int> FindFirstCommonPosition(
            in PlacementList sourcePlacements,
            in PlacementList searchPlacements)
        {
            // First we find the common placement
            for (int i = 0; i < sourcePlacements.Count; i++)
            {
                for (int j = 0; j < searchPlacements.Count; j++)
                {
                    if (sourcePlacements[i].w == searchPlacements[j].w)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }
            return new Tuple<int, int>(-1, -1);
        }



        /// change where we are placing each word, adjusting them so two placements can fall together in the one grid
        private static PlacementList ApplyOffsets(
            in PlacementList placements,
            int xOffset,
            int yOffset)
        {
            var newPlacements = new PlacementList();
            foreach (var j in placements)
            {
                var newPlacement = new PlacementModel(
                w: j.w,
                x: (byte)(int)(j.x + xOffset),
                y: (byte)(int)(j.y + yOffset),
                z: j.z,
                l: j.l);
                newPlacements.Add(newPlacement);
            }
            return newPlacements;
        }

        private static PlacementList ApplyOffsetsForSearch(
            in PlacementList placements,
            int xOffset,
            int yOffset,
            in HashSet<int> excludedWords)
        {
            var newPlacements = new PlacementList();
            foreach (var j in placements)
            {
                if (excludedWords.Contains(j.w) == false)
                {
                    var newPlacement = new PlacementModel(
                    w: j.w,
                    x: (byte)(int)(j.x + xOffset),
                    y: (byte)(int)(j.y + yOffset),
                    z: j.z,
                    l: j.l);
                    newPlacements.Add(newPlacement);
                }
            }
            return newPlacements;
        }




        private static PlacementList ApplyOffsetsForSearchWithFlip(
            in PlacementList placements,
            int xOffset,
            int yOffset,
            HashSet<int> excludedWords)
        {
            var newPlacements = new PlacementList();
            foreach (var j in placements)
            {
                if (excludedWords.Contains(j.w) == false)
                {
                    var newPlacement = new PlacementModel(
                    w: j.w,
                    x: (byte)(int)(j.y + yOffset),
                    y: (byte)(int)(j.x + xOffset),
                    z: !j.z,
                    l: j.l);
                    newPlacements.Add(newPlacement);
                }
            }
            return newPlacements;
        }


        /// The offset depends on if the shape is flipped or will be merged in the same original direction.
        private static Tuple<byte, byte, byte, byte> CalculateOffsets(
            int xSource,
            int ySource,
            int xSearch,
            int ySearch,
            bool flip)
        {

            if (flip)
            {
                int xSearchTemp = xSearch;
                xSearch = ySearch;
                ySearch = xSearchTemp;
            }



            var xDiff = xSource - xSearch;
            var yDiff = ySource - ySearch;

            // When it is minus then we need to move the first one in that direction in the absolute amount
            // when its plus then we need to move the other one in that direction

            var sourceOffsetX = 0;
            var sourceOffsetY = 0;
            var searchOffsetX = 0;
            var searchOffsetY = 0;


            if (xDiff < 0)
            {
                sourceOffsetX += xDiff * -1;
            }
            else if (xDiff > 0)
            {
                searchOffsetX += xDiff;
            }
            if (yDiff < 0)
            {
                sourceOffsetY += yDiff * -1;
            }
            else if (yDiff > 0)
            {
                searchOffsetY += yDiff;
            }

            return new Tuple<byte, byte, byte, byte>((byte)sourceOffsetX, (byte)sourceOffsetY, (byte)searchOffsetX, (byte)searchOffsetY);
        }
   
	}
}

