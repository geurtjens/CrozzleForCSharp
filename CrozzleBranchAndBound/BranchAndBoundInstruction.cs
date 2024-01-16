using System;
namespace CrozzleBranchAndBound;

public struct BranchAndBoundInstruction
{
    public readonly int LookaheadDepth;
    public readonly int BeamWidth;
    public readonly List<int> Games;
    public readonly int RootShape;
    public readonly int RootWidth;
    public readonly bool UseGuidedScores;
    public readonly int MaxDepth;


    public BranchAndBoundInstruction(int lookaheadDepth, int beamWidth, List<int> games, int rootShape, int rootWidth, bool useGuidedScores, int maxDepth)
    {
        LookaheadDepth = lookaheadDepth;
        BeamWidth = beamWidth;
        Games = games;
        RootShape = rootShape;
        RootWidth = rootWidth;
        UseGuidedScores = useGuidedScores;
        MaxDepth = maxDepth;
    }
}

