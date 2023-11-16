using System;
using System.Collections.Generic;

namespace CrozzleInterfaces
{
	public class WordIdList
    {
        public static HashSet<int> findExtraWords(HashSet<int> wordIds, HashSet<int> sibling) {
            return new HashSet<int>(sibling.Except(wordIds));
        }
    }
}