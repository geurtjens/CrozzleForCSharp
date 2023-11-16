using System;
using CrozzleInterfaces;

namespace CrozzleInterfaces
{
	public record struct ShapeModel
	{
		public readonly byte width;
		public readonly byte height;
		public readonly ushort score;
		public readonly List<PlacementModel> placements;
        public readonly string wordSequence;

        public List<int> history;
        public bool isValid;

		public ShapeModel(ushort score, byte width, byte height, in List<PlacementModel> placements)
		{
            this.isValid = true;
            this.score = score;
            this.history = new List<int>();


            var sortedPlacements = PlacementList.SortByWord(placements);

            if (PlacementList.ShouldBeFlipped(sortedPlacements))
            {
                // We are flipping the shape as it makes GetWordSequence for all shapes same orientation
                var flippedPlacements = PlacementList.Flip(sortedPlacements);

                this.width = height;
                this.height = width;
                this.placements = flippedPlacements;
                this.wordSequence = PlacementList.GetWordSequence(flippedPlacements);
            }
            else {
                this.width = width;
                this.height = height;
                this.placements = sortedPlacements;
                this.wordSequence = PlacementList.GetWordSequence(sortedPlacements);
            }            
		}

        public void SetToInvalid()
        {
            isValid = false;
        }

        public static List<int> createMergeHistory(
            in List<int> sourceShapeHistory,
            in List<int> searchShapeHistory)
        {
            if (sourceShapeHistory.Count == 1 && searchShapeHistory.Count == 1)
            {
                var source = sourceShapeHistory[0];
                var search = searchShapeHistory[0];
                if (source < search)
                {
                    return new List<int> { source, search };
                }
                else
                {
                    return new List<int> { search, source };
                }
            }
            // I think we should add to the source shape history rather than adding the larger one to the smaller one.  See if this makes a difference.
            sourceShapeHistory.AddRange(searchShapeHistory);
            return sourceShapeHistory;
            //else if (sourceShapeHistory.Count > searchShapeHistory.Count)
            //{
            //    sourceShapeHistory.AddRange(searchShapeHistory);
            //    return sourceShapeHistory;
            //}
            //else
            //{
            //    searchShapeHistory.AddRange(sourceShapeHistory);
            //    return searchShapeHistory;
            //}
        }

        public string ToCSharpCode()
        {
            var code = "";

            code += PlacementsToCSharp(placements: placements) + "\n";

            code += $"var shape = new ShapeModel(score: {score}, width: {width}, height: {height}, placements: placements);";

            return code;
        }
        public static string PlacementsToCSharp(List<PlacementModel> placements)  {
            var code = "";
        
            foreach (var placement in placements) {
                if (code != "") {
                    code += ",\n";
                }
                code += "        " + PlacementToCSharp(placement: placement);
            }

            var result = "let placements = new List<PlacementModel> {\n" + code + "\n    };";
            return result;
        }
        public static String PlacementToCSharp(PlacementModel placement)
        {
            var horizontal = "true";
            if (placement.z == false)
            {
                horizontal = "false";
            }
            return $"new PlacementModel(w: {placement.w}, x: {placement.x}, y: {placement.y}, z: {horizontal}, l:{placement.l})";
        }


        public string ToSwiftCode()
        {
            var code = "";

            code += PlacementsToSwift(placements: placements) + "\n";

            code += $"let shape = ShapeModel(score: {score}, width: {width}, height: {height}, placements: placements)";

            return code;
        }
        public static string PlacementsToSwift(List<PlacementModel> placements)
        {
            var code = "";

            foreach (var placement in placements)
            {
                if (code != "")
                {
                    code += ",\n        ";
                }
                code += "" + PlacementToSwift(placement: placement);
            }

            var result = "let placements = [\n        " + code + "\n    ]";
            return result;
        }
        public static String PlacementToSwift(PlacementModel placement)
        {
            var horizontal = "true";
            if (placement.z == false)
            {
                horizontal = "false";
            }
            return $"PlacementModel(w: {placement.w}, x: {placement.x}, y: {placement.y}, z: {horizontal}, l:{placement.l})";
        }

        /// rotate a shape and return a rotated shape which means width becomes height and all placements are rearranged
        public ShapeModel Flip()
        {
            var placements = new List<PlacementModel>();

            foreach (var p in this.placements)
            {
                placements.Add(new PlacementModel(w: p.w, x: p.y, y: p.x, z: !p.z, l: p.l));
            }

            var result = new ShapeModel(score: this.score, width: this.height, height: this.width, placements: placements);
            return result;
        }

        

        public String ToTextDebug(in List<string> words)
        {
            int score = 0;

            int widthEOL = (int)this.width + 1;
            int height = (int)this.height;

            int gridSize = widthEOL * height;

            var grid = new List<char>();
            grid.Capacity = gridSize;
            for (int i = 0; i < gridSize; i++)
            {
                grid.Add(' ');
            }


            // Place all end of line characters into the space
            for (int i = 0; i < height; i++)
            {
                grid[i * widthEOL] = '\n';
            }

            foreach (var placement in this.placements)
            {

                // the word must include the blocking characters at either end of the shape
                var word = "." + words[(int)placement.w] + ".";

                int gridPos = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];

                    if (placement.z)
                    {
                        gridPos = (int)placement.x + i + (int)placement.y * widthEOL + 1;
                    }
                    else
                    {
                        gridPos = (int)placement.x + 1 + (int)(placement.y + i) * widthEOL;
                    }

                    if (grid[gridPos] != ' ' && grid[gridPos] != letter)
                    {
                        grid[gridPos] = '#';
                    }
                    else if (grid[gridPos] == ' ')
                    {
                        grid[gridPos] = letter;
                    }
                    else if (grid[gridPos] == letter)
                    {
                        // score += ScoreCalculator.score(letter);
                    }
                }
            }

            var result = "";
            for (int i = 1; i < gridSize; i++)
            {
                result += grid[i];
            }

            if (result.Contains('#'))
            {
                score = 0;
            }
            else
            {
                score += this.placements.Count * 10;
            }

            return result;
        }

        public List<int> GetWordIds()
        {
            return PlacementList.GetWords(this.placements);
        }

        public HashSet<int> GetHashSetWordIds()
        {
            return new HashSet<int>(PlacementList.GetWords(this.placements));
        }
    }
}

