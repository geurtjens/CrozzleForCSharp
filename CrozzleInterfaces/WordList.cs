using System;
namespace CrozzleInterfaces
{
	public class WordList : List<string>
	{
        public static List<int> Lengths(List<string> words)
        {
            var result = new List<int>();

            foreach (var word in words)
            {
                result.Add((int)word.Length);
            }
            return result;
        }

        // If we do this before other processing we can save all the time of making individual "." + word + "." 
        public WordList WordsWithBlocks()
        {
            var result = new WordList();
            foreach(string word in this)
            {
                result.Add("." + word + ".");
            }
            return result;
        }

        public List<byte> LengthsInBytes()
        {
            var result = new List<byte>();

            foreach (var word in this)
            {
                result.Add((byte)word.Length);
            }
            return result;
        }

        public List<int> Lengths()
        {
            var result = new List<int>();

            foreach (var word in this)
            {
                result.Add((int)word.Length);
            }
            return result;
        }

        public WordList Reversed()
        {
            var result = new WordList();

            foreach (var word in this)
            {
                var item = "";
                for (int letterPos = word.Length; letterPos > 0; letterPos--)
                {
                    item += word[letterPos - 1];
                }
                result.Add(item);
            }
            return result;
        }

        /// We have a list of words that we want the wordId for
        public int extractWordId(in string search)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i] == search)
                {
                    return i;
                }
            }
            return -1;
        }


        public List<byte> ExtractPositions(in List<string> ofWords)
        {
            var result = new List<byte>();
            var notFound = new List<String>();
            foreach (var word in ofWords)
            {
                var wordId = extractWordId(search: word);
                if (wordId >= 0)
                {
                    result.Add((byte)wordId);
                }
                else
                {
                    notFound.Add(word);
                }
            }

            if (notFound.Count > 0)
            {
                Console.WriteLine($"Words Not found in extractPositions are: {notFound}");
            }
            return result;
        }
    }
}

