using System;
namespace ShapeMakerCSharp
{
	public class WordCalculator
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

        public static List<byte> LengthsInBytes(List<string> words)
        {
            var result = new List<byte>();

            foreach (var word in words)
            {
                result.Add((byte)word.Length);
            }

            return result;
        }

        public static List<string> Reverse(List<string> words)
        {
            var result = new List<string>();

            foreach (var word in words)
            {
				var item = "";
				for (int letterPos = word.Length; letterPos > 0; letterPos--)
				{
					item += word[letterPos-1];
				}
				result.Add(item);
            }

            return result;
        }

        /// We have a list of words that we want the wordId for
        public static int extractWordId(in string search, in List<string> words ) {
            for (int i=0; i<words.Count; i++) {
                if (words[i] == search) {
                    return i;
                }
            }
            return -1;
        }

		public static List<byte> ExtractPositions(in List<string> ofWords, in List<string> from)
		{
            var result = new List<byte>();
            var notFound = new List<String>();
            foreach (var word in ofWords) {
                var wordId = extractWordId(search: word, words: from);
                if (wordId >= 0) {
                        result.Add((byte)wordId);
                }
                else
                {
                    notFound.Add(word);
                }
            }

            if (notFound.Count > 0) {
                Console.WriteLine($"Words Not found in extractPositions are: {notFound}");
            }
            return result;

        }
    }
}

