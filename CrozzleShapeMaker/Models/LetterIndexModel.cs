
namespace CrozzleShapeMaker;

public class LetterIndexModel
{
    public List<List<LetterIndexItemModel>> index;

    public LetterIndexModel(in List<string> words)
    {
        index = new List<List<LetterIndexItemModel>>();

        /// Create a vector of 26 items for the 26 letters of the alphabet
        for (int i = 0; i < 26; i++)
        {
            this.index.Add(new List<LetterIndexItemModel>());
        }

        for (int wordId = 0; wordId < words.Count; wordId++)
        {
            int wordLength = (int)words[wordId].Length;

            for (int fromStart = 0; fromStart < wordLength; fromStart++)
            {
                int letter = words[wordId][fromStart];
                int arrayPosition = letter - 65;

                int fromEnd = wordLength - fromStart - 1;


                this.index[arrayPosition].Add(new LetterIndexItemModel(wordId, fromStart, fromEnd));
            }
        }
    }

    public List<LetterIndexItemModel> find(char letter)
    {
        int letterPos = letter - 65;
        return this.index[letterPos];
    }

    public List<LetterIndexItemModel> findInt(int letter)
    {
        int letterPos = letter - 65;
        return this.index[letterPos];
    }
}