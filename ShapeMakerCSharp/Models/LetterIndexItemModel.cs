using System;
namespace ShapeMakerCSharp
{
	public readonly record struct LetterIndexItemModel
	{
        /// The position of the word in the sequence
        public readonly int id;
        /// The position of the letter from the start of the word
        public readonly int start;
        /// The position of the letter from the end of the word
        public readonly int end;

        public LetterIndexItemModel(int id, int start, int end)
        {
            this.id = id;
            this.start = start;
            this.end = end;
        }
	}
}

