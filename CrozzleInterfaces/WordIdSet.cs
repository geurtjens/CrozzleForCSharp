using System;
using System.Collections.Generic;

namespace CrozzleInterfaces
{
	public class WordIdSet : HashSet<int>
    {
        public WordIdSet findExtraWords(WordIdSet sibling) {
            var missingWords = (WordIdSet) sibling.Except(this);
            return missingWords;
        }
    }
}

