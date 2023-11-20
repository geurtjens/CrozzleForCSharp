using System;
namespace CrozzleShapeMerger;

public readonly record struct MatchesModel
{
	public readonly List<int> matches;
	public readonly int firstSourcePos;
	public readonly int firstSearchPos;
	public readonly int matchingWordCount;
        public MatchesModel(in List<int> matches, int firstSourcePos, int firstSearchPos, int matchingWordCount)
	{
		this.matches = matches;
		this.firstSourcePos = firstSourcePos;
		this.firstSearchPos = firstSearchPos;
		this.matchingWordCount = matchingWordCount;
	}
	
}

