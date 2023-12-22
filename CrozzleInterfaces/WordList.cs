using System;
namespace CrozzleInterfaces;

public class WordList
{

    public static List<int> Lengths(in List<string> words)
    {
        var result = new List<int>();

        foreach (var word in words)
        {
            result.Add((int)word.Length);
        }
        return result;
    }

    // If we do words before other processing we can save all the time of making individual "." + word + "." 
    public static List<string> WordsWithBlocks(in List<string> words)
    {
        var result = new List<string>();
        foreach(string word in words)
        {
            result.Add("." + word + ".");
        }
        return result;
    }

    public static List<byte> LengthsInBytes(in List<string> words)
    {
        var result = new List<byte>();

        foreach (var word in words)
        {
            result.Add((byte)word.Length);
        }
        return result;
    }

    

    public static List<string> Reversed(in List<string> words)
    {
        var result = new List<string>();

        foreach (var word in words)
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
    public static int ExtractWordId(in List<string> words,in string search)
    {
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i] == search)
            {
                return i;
            }
        }
        return -1;
    }


    public static List<byte> ExtractPositions(in List<string> words, in List<string> searchFor)
    {
        var result = new List<byte>();
        var notFound = new List<String>();
        foreach (var searchWord in searchFor)
        {
            var wordId = ExtractWordId(words, searchWord);
            if (wordId >= 0)
            {
                result.Add((byte)wordId);
            }
            else
            {
                notFound.Add(searchWord);
            }
        }

        if (notFound.Count > 0)
        {
            Console.WriteLine($"Words Not found in extractPositions are: {notFound}");
        }
        return result;
    }
}

