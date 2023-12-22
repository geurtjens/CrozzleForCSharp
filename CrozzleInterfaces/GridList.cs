using System;
namespace CrozzleInterfaces;

public class GridList
{

    public static ShapeModel ToShape(in List<string> grid, in List<string> words)
    {
        var placements = FromTextToPlacements(grid, words);

        int height = grid.Count;
        int width = grid[0].Length;
        int score = FindScore(grid) + placements.Count * 10;
        ShapeModel shape = new ShapeModel((ushort)score, (byte)width, (byte)height, placements);

        return shape;
    }

    public static int FindScore(in List<string> grid)
    {

        var height = grid.Count;

        if (height == 0)
        {
            return 0;
        }
        var width = grid[0].Length;
        var result = 0;



        for (int y = 1; y < (height - 1); y++)
        {
            for (int x = 1; x < (width - 1); x++)
            {

                if (IsAlphabet(grid[y][x]))
                {
                    var isHorizontal = (IsAlphabet(grid[y][x - 1]) || IsAlphabet(grid[y][x + 1]));
                    var isVertical = (IsAlphabet(grid[y - 1][x]) || IsAlphabet(grid[y + 1][x]));


                    if (isHorizontal && isVertical)
                    {
                        result += ScoreCalculator.Score(grid[y][x]);
                    }
                }
            }
        }

        return result;
    }

    private static bool IsAlphabet(char letter)
    {
        if (letter != ' ' && letter != '.' && letter != '#')
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    

    private static List<PlacementModel> FromTextToPlacements(in List<string> grid, in List<string> words)
    {
        var placements = FromTextToPlacementsHorizontal(grid, words);

        var verticalPlacements = FromTextToPlacementsVertical(grid, words);

        placements.AddRange(verticalPlacements);

        return placements;
    }



    private static List<PlacementModel> FromTextToPlacementsHorizontal(in List<string> grid, in List<string> words)
    {
        var result = new List<PlacementModel>();

        if (grid.Count == 0)
        {
            return result;
        }

        int height = grid.Count;
        int width = grid[0].Length;

        for (int y = 1; y < height - 1; y++)
        {
            string line = grid[y];

            string word = "";
            int xPos = 0;

            for (int x = 1; x < width; x++)
            {
                char current = line[x];

                if (word == "")
                {
                    if (line[x - 1] == '.' && IsAlphabet(current) && x != width - 1 && IsAlphabet(line[x + 1]))
                    {
                        word += current;
                        xPos = x - 1;
                    }
                }
                else
                {
                    if (IsAlphabet(current))
                    {
                        word += current;
                    }
                    else if (current == '.')
                    {
                        // We have finished the word
                        int wordId = WordList.ExtractWordId(words, word);
                        if (wordId == -1)
                        {
                            Console.WriteLine($"{word} not found in List<string>");
                            // It is invalid as we cannot find grid word
                            return new List<PlacementModel>();
                        }
                        else
                        {

                            result.Add(new PlacementModel(
                                w: (byte)wordId,
                                x: (byte)xPos,
                                y: (byte)y,
                                z: true,
                                l: (byte)word.Length));
                            word = "";
                        }
                    }
                    else if (current == '.')
                    {
                        // grid is invalid as a word cannot end in a space
                        return new List<PlacementModel>();
                    }
                }
            }


        }
        return result;
    }


    private static List<PlacementModel> FromTextToPlacementsVertical(in List<string> grid, List<string> words)
    {
        var result = new List<PlacementModel>();

        int height = grid.Count;
        if (height == 0)
        {
            return result;
        }

        
        int width = grid[0].Length;

        int yPos = 0;
        for (int x = 1; x < width - 1; x++)
        {

            string word = "";
            for (int y = 1; y < height; y++)
            {

                char current = grid[y][x];

                if (word == "")
                {
                    if (grid[y - 1][x] == '.' && IsAlphabet(current) && y != height - 1 && IsAlphabet(grid[y + 1][x]))
                    {
                        word += current;
                        yPos = y - 1;
                    }
                }
                else
                {

                    if (IsAlphabet(current))
                    {
                        word += current;
                    }
                    else if (current == '.')
                    {
                        // We have finished the word
                        int wordId = WordList.ExtractWordId(words, word);
                        if (wordId == -1)
                        {
                            Console.WriteLine($"{word} not found in List<string>");
                            // It is invalid as we cannot find grid word
                            return new List<PlacementModel>();
                        }
                        else
                        {

                            result.Add(new PlacementModel(
                                w: (byte)wordId,
                                x: (byte)x,
                                y: (byte)yPos,
                                z: false,
                                l: (byte)word.Length));

                            word = "";
                        }
                    }
                    else if (current == '.')
                    {
                        // grid is invalid as a word cannot end in a space
                        return new List<PlacementModel>();
                    }
                }
            }
        }
        return result;
    }

}

