using System;
namespace CrozzleBranchAndBound;

public struct BranchAndBoundInstruction
{
    public readonly int LookaheadDepth;
    public readonly int BeamWidth;
    public readonly List<int> Games;
    public readonly int RootWidth;
    public readonly bool UseGuidedScores;
    public readonly int MaxDepth;


    public BranchAndBoundInstruction(int lookaheadDepth, int beamWidth, List<int> games, int rootWidth, bool useGuidedScores, int maxDepth)
    {
        LookaheadDepth = lookaheadDepth;
        BeamWidth = beamWidth;
        Games = games;
        RootWidth = rootWidth;
        UseGuidedScores = useGuidedScores;
        MaxDepth = maxDepth;
    }
}

