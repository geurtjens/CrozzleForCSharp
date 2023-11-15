using System;
using System.Linq;
using CrozzleInterfaces;

namespace ShapeMakerCSharp
{
    class ShapeCalculator
    {

        public static List<ShapeModel> CombineShapes(List<List<ShapeModel>> list)
        {
            var result = new List<ShapeModel>();
            foreach (var item in list)
            {
                result.AddRange(item);
            }
            return result;
        }

        public static String ToTextDebug(in ShapeModel shape, in List<String> words)
        {
            int score = 0;

            int widthEOL = (int)shape.width + 1;
            int height = (int)shape.height;

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

            foreach (var placement in shape.placements)
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
                        score += ScoreCalculator.score(letter);
                    }
                }
            }

            var result = "";
            for (int i = 1; i < gridSize; i++)
            {
                result += grid[i];
            }

            if (result.Contains('#')) {
                score = 0;
            }
            else
            {
                score += shape.placements.Count * 10;
            }

            return result;
        }


        /// rotate a shape and return a rotated shape which means width becomes height and all placements are rearranged
        public static ShapeModel Flip(in ShapeModel shape)
        {
            var placements = new List<PlacementModel>();
        
            foreach (var p in shape.placements)
            {
                placements.Add(new PlacementModel(w: p.w, x: p.y, y: p.x, z: !p.z, l: p.l));
            }

            var result = new ShapeModel(score: shape.score, width: shape.height, height: shape.width, placements: placements);
            return result;
        }


    }
}
