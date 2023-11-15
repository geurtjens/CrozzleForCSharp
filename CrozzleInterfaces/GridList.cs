using System;
namespace CrozzleInterfaces
{
	public class GridList : List<string>
	{

        public int findScore()
        {

            var height = this.Count;

            if (height == 0)
            {
                return 0;
            }
            var width = this[0].Length;
            var result = 0;



            for (int y = 1; y < (height - 1); y++)
            {
                for (int x = 1; x < (width - 1); x++)
                {

                    if (IsAlphabet(this[y][x]))
                    {
                        var isHorizontal = (IsAlphabet(this[y][x - 1]) || IsAlphabet(this[y][x + 1]));
                        var isVertical = (IsAlphabet(this[y - 1][x]) || IsAlphabet(this[y + 1][x]));


                        if (isHorizontal && isVertical)
                        {
                            result += ScoreCalculator.score(this[y][x]);
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


        public ShapeModel ToShape(WordList words)
        {
            var placements = fromTextToPlacements(words: words);

            int height = this.Count;
            int width = this[0].Length;
            int score = findScore() + placements.Count * 10;
            ShapeModel shape = new ShapeModel((ushort)score, (byte)width, (byte)height, placements);

            return shape;
        }

        private List<PlacementModel> fromTextToPlacements(WordList words)
        {
            var placements = fromTextToPlacementsHorizontal(words: words);

            var verticalPlacements = fromTextToPlacementsVertical(words: words);

            placements.AddRange(verticalPlacements);

            return placements;
        }



        private List<PlacementModel> fromTextToPlacementsHorizontal(WordList words)
        {
            var result = new List<PlacementModel>();

            if (this.Count == 0)
            {
                return result;
            }

            int height = this.Count;
            int width = this[0].Length;

            for (int y = 1; y < height - 1; y++)
            {
                string line = this[y];

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
                            int wordId = words.extractWordId(search: word);
                            if (wordId == -1)
                            {
                                Console.WriteLine($"{word} not found in wordlist");
                                // It is invalid as we cannot find this word
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
                            // this is invalid as a word cannot end in a space
                            return new List<PlacementModel>();
                        }
                    }
                }


            }
            return result;
        }


        private List<PlacementModel> fromTextToPlacementsVertical(WordList words)
        {
            var result = new List<PlacementModel>();

            int height = this.Count;
            if (height == 0)
            {
                return result;
            }

            
            int width = this[0].Length;

            int yPos = 0;
            for (int x = 1; x < width - 1; x++)
            {

                string word = "";
                for (int y = 1; y < height; y++)
                {

                    char current = this[y][x];

                    if (word == "")
                    {
                        if (this[y - 1][x] == '.' && IsAlphabet(current) && y != height - 1 && IsAlphabet(this[y + 1][x]))
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
                            int wordId = words.extractWordId(search: word);
                            if (wordId == -1)
                            {
                                Console.WriteLine($"{word} not found in wordlist");
                                // It is invalid as we cannot find this word
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
                            // this is invalid as a word cannot end in a space
                            return new List<PlacementModel>();
                        }
                    }
                }
            }
            return result;
        }

    }
}

