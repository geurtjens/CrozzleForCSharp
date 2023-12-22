using System;
namespace CrozzleShapeMerger;

public readonly record struct MatchesModel
{
	public readonly List<int> Matches;
	public readonly int FirstSourcePos;
	public readonly int FirstSearchPos;
	public readonly int MatchingWordCount;

	public MatchesModel(in List<int> matches, int firstSourcePos, int firstSearchPos, int matchingWordCount)
	{
		Matches = matches;
		FirstSourcePos = firstSourcePos;
		FirstSearchPos = firstSearchPos;
		MatchingWordCount = matchingWordCount;
	}
}