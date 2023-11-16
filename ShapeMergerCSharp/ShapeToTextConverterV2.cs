using System;
using CrozzleInterfaces;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Metrics;
using System.Text;

namespace ShapeMergerCSharp
{
    public class ShapeToTextConverterV2
    {
        public static string ToString(List<byte> grid)
        {
            return Encoding.ASCII.GetString(grid.ToArray());
        }

        /// convert the shape to a valid shape or return null.  We might preprocess a shape but not yet know its valid so we use this to make sure
        public static ShapeModel? ToValidShape(
            in List<PlacementModel> placements,
            int width,
            int height,
            in List<string> words)
        {
            var (score, grid) = getScoreAndText(placements: placements, width: width, height: height, words: words);


            if (score == 0)
            {
                return null;
            }
            // We should also check that the text doesnt have text running in parallel and without the . at each end
            //        var textIsVerified = VerifyGrid(grid: grid, width: Int(shape.width), height: Int(shape.height))
            //
            //        if textIsVerified {

            var wordCount = getWordCount(grid: grid, width: width, height: height);


            if (wordCount != placements.Count)
            {
                return null;
            }

            var newShape = new ShapeModel(score: score, width: (byte)(width), height: (byte)(height), placements: placements);

            // our shapes must have first word as horizontal to help with removing duplicates
            if (newShape.placements[0].z == false)
            {
                var flipped = newShape.Flip();
                return flipped;
            }
            else
            {
                return newShape;
            }
            //        } else {
            //            return nil
            //        }
        }

        // Why not make the grid bytes

        public static Tuple<ushort, List<char>> getScoreAndText(
            in List<PlacementModel> placements,
            int width,
            int height,
            List<string> words)
        {

            const char SPACE = ' '; // 32;
            const char LF = '\n'; // 10;
            const char DOT = '.'; //46;
            const char BLOCK = '#'; // 35;


            var score = 0;


            int widthEOL = width + 1;



            int gridSize = widthEOL * height;
            var grid = new List<char>();

            for (int i = 0; i < gridSize; i++)
            {
                grid.Add(SPACE);
            }




            // Place all end of line characters into the space
            for (int i = 0; i < height; i++)
            {
                grid[i * widthEOL] = LF; // Means end of line
            }

            foreach (PlacementModel placement in placements)
            {

                // the word must include the blocking characters at either end of the shape
                var word = DOT + words[(int)(placement.w)] + DOT;


                var gridPos = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];


                    if (placement.z)
                    {
                        gridPos = placement.x + i + (placement.y * widthEOL + 1);
                    }
                    else
                    {
                        gridPos = placement.x + 1 + (placement.y + i) * widthEOL;
                    }

                    if (grid[gridPos] != SPACE && grid[gridPos] != letter)
                    {
                        grid[gridPos] = BLOCK;
                        return new Tuple<ushort, List<char>>((ushort)0, new List<char>());
                    }
                    else if (grid[gridPos] == SPACE)
                    {
                        grid[gridPos] = letter;
                    }
                    else if (grid[gridPos] == letter)
                    {
                        score += ScoreCalculator.score(letter);
                    }
                }
            }
            //var gridString = String(grid)

            // Remove the first character as it is a \n
            //var range = gridString.index(after: gridString.startIndex)..<gridString.endIndex
            //var result = String(gridString[range])

            //if result.contains("#") {
            //    score = 0
            //} else {
            score += placements.Count * 10;
            //}

            grid = grid.Skip(1).ToList();



            return new Tuple<ushort, List<char>>((ushort)(score), grid);
        }


        public static bool IsAlpha(char letter)
        {
            return (letter >= 'A' && letter <= 'Z');
        }

        public static char V(int y, int x, in List<char> grid, int widthEOL)
        {
            if (y == 0)
            {
                return grid[x];
            }
            else
            {

            }
            var gridPos = x + (y * widthEOL);
            return grid[gridPos];
        }





        public static bool VerifyGrid(
            in List<char> grid,
            int width,
            int height)
        {

            var SPACE = 32;

            var heightMinusOne = height - 1;
            var widthMinusOne = width - 1;
            var widthEOL = width + 1;
            // Horizontal verification
            char previous = ' ';
            char current = ' ';
            char next = ' ';
            for (int y = 1; y < heightMinusOne; y++)
            {
                previous = V(y, 0, grid, widthEOL);
                for (int x = 1; x < widthMinusOne; x++)
                {
                    current = V(y, x, grid, widthEOL);
                    next = V(y, x + 1, grid, widthEOL);
                    if (IsAlpha(current))
                    {
                        if (previous == SPACE && IsAlpha(next))
                        {
                            return false;
                        }
                        else if (x == 1 && IsAlpha(previous))
                        {
                            return false;
                        }
                        else if (IsAlpha(previous) && next == SPACE)
                        {
                            return false;
                        }
                        else if (x == widthMinusOne - 1 && IsAlpha(next))
                        {
                            return false;
                        }
                    }
                    previous = current;
                }
            }

            //var reversed = rotateGrid(grid: grid)

            for (int y = 1; y < widthMinusOne; y++)
            {
                previous = V(0, y, grid, widthEOL);
                for (int x = 1; x < heightMinusOne; x++)
                {
                    current = V(x, y, grid, widthEOL);
                    next = V(x + 1, y, grid, widthEOL);
                    if (IsAlpha(current))
                    {
                        if (previous == SPACE && IsAlpha(next))
                        {
                            return false;
                        }
                        else if (x == 1 && IsAlpha(previous))
                        {
                            return false;
                        }
                        else if (IsAlpha(previous) && next == SPACE)
                        {
                            return false;
                        }
                        else if (x == heightMinusOne - 1 && IsAlpha(next))
                        {
                            return false;
                        }
                    }
                    previous = current;
                }
            }

            return true;
        }


        public static int getWordCount(in List<char> grid, int width, int height)
        {

            // If we have 2 or more alpha in a row then this is a word
            var wordCount = 0;

            var heightMinusOne = height - 1;
            var widthMinusOne = width - 1;
            var widthEOL = width + 1;
            // Horizontal verification

            char current = ' ';
            int letterCount = 0;


            for (int y = 1; y < heightMinusOne; y++)
            {
                if (letterCount > 1)
                {
                    wordCount += 1;
                }
                letterCount = 0;
                for (int x = 1; x < widthMinusOne; x++)
                {
                    current = V(y, x, grid, widthEOL);


                    if (IsAlpha(current))
                    {
                        letterCount += 1;
                    }
                    else
                    {
                        if (letterCount > 1)
                        {
                            wordCount += 1;
                        }
                        letterCount = 0;
                    }
                }
            }

            for (int y = 1; y < widthMinusOne; y++)
            {
                if (letterCount > 1)
                {
                    wordCount += 1;
                }
                letterCount = 0;
                for (int x = 1; x < heightMinusOne; x++)
                {
                    current = V(x, y, grid, widthEOL);
                    if (IsAlpha(current))
                    {
                        letterCount += 1;
                    }
                    else
                    {
                        if (letterCount > 1)
                        {
                            wordCount += 1;
                        }
                        letterCount = 0;
                    }
                }
            }

            if (letterCount > 1)
            {
                wordCount += 1;
            }

            return wordCount;
        }

    }
}