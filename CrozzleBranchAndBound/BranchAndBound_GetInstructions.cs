using System;
using CrozzleBranchAndBound;

namespace CrozzleBranchAndBound;

public class BranchAndBound_GetInstructions
{

    public static List<BranchAndBoundInstruction> AllWords_NoGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 8703 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 25, games: new List<int> { 8802, 9306 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 43, games: new List<int> { 9212 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 75, games: new List<int> { 8710 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 9002, 9109, 9312 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 50, games: new List<int> { 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 75, games: new List<int> { 8808, 9210 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 87, games: new List<int> { 9303 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8712, 9007, 9008 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 25, games: new List<int> { 8705, 8811, 9103, 9308 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 37, games: new List<int> { 8711 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        // 32 games full words so far

        // List<int> solvedgames: new List<int> { 8703, 8802, 9306, 9212, 8710, 9002, 9109, 9312, 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412, 8808, 9210, 9303, 8712, 9007, 9008, 8705, 8811, 9103, 9308, 8711 };

        return result;
    }

    public static List<BranchAndBoundInstruction> AllWords_UseGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 8703 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 25, games: new List<int> { 8802, 9306 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 43, games: new List<int> { 9212 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 75, games: new List<int> { 8710 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 9002, 9109, 9312 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 50, games: new List<int> { 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 75, games: new List<int> { 8808, 9210 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 87, games: new List<int> { 9303 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8712, 9007, 9008 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 25, games: new List<int> { 8705, 8811, 9103, 9308 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 37, games: new List<int> { 8711 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        // 32 games full words so far

        // List<int> solvedgames: new List<int> { 8703, 8802, 9306, 9212, 8710, 9002, 9109, 9312, 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412, 8808, 9210, 9303, 8712, 9007, 9008, 8705, 8811, 9103, 9308, 8711 };

        return result;
    }


    public static List<BranchAndBoundInstruction> WinningWords_NoGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 8802, 8808, 9104, 9212, 9306, 9406 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 2, games: new List<int> { 8710, 9311 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 3, games: new List<int> { 9412 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 5, games: new List<int> { 8711 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 8, games: new List<int> { 9108 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 17, games: new List<int> { 9510 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 27, games: new List<int> { 9503 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 2, games: new List<int> { 8704, 8910, 9105, 9207, 9210 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 3, games: new List<int> { 8911, 9004, 9408 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 4, games: new List<int> { 8912 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 5, games: new List<int> { 9409 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 6, games: new List<int> { 9511 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 7, games: new List<int> { 9208 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 8, games: new List<int> { 9411 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 10, games: new List<int> { 9401 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 13, games: new List<int> { 9410 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 36, games: new List<int> { 8906 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 37, games: new List<int> { 9301 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302, 9308, 9309, 9404, 9502 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 2, games: new List<int> { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 3, games: new List<int> { 9009, 9407 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 4, games: new List<int> { 8810, 9003 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 5, games: new List<int> { 9005, 9512 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 6, games: new List<int> { 8907 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 7, games: new List<int> { 9106 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 9, games: new List<int> { 9307 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 10, games: new List<int> { 9506, 9604 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 11, games: new List<int> { 8807, 8902, 9202, 9501 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 18, games: new List<int> { 9001, 9011 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 19, games: new List<int> { 9601, 9605 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 21, games: new List<int> { 8908 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9012 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 36, games: new List<int> { 9102 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 66, games: new List<int> { 9403 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 98, games: new List<int> { 8909 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 107, games: new List<int> { 9203 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 124, games: new List<int> { 9603 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 153, games: new List<int> { 9010, 9209 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 193, games: new List<int> { 8905 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 454, games: new List<int> { 9507 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 7, games: new List<int> { 9101 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 8, games: new List<int> { 9509 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 23, games: new List<int> { 9107 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 35, games: new List<int> { 9112 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 68, games: new List<int> { 8805 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 82, games: new List<int> { 8904 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 140, games: new List<int> { 8904 }, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        // These are the stranger instructions that do not start with the highest scoring starting shape same as other winning word result
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 4, games: new List<int> { 8804 }, rootWidth: -2, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9602 }, rootWidth: -1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 28, games: new List<int> { 8803 }, rootWidth: -1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 40, games: new List<int> { 9305 }, rootWidth: -5, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 51, games: new List<int> { 9505 }, rootWidth: -6, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 77, games: new List<int> { 8806 }, rootWidth: -8, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9504 }, rootWidth: -3, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9507 }, rootWidth: -5, useGuidedScores: false, maxDepth: 30));


        return result;
    }

    public static List<BranchAndBoundInstruction> WinningWords_UseGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 8802, 8808, 9104, 9212, 9306, 9406 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 2, games: new List<int> { 8710, 9311 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 3, games: new List<int> { 9412 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 5, games: new List<int> { 8711 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 8, games: new List<int> { 9108 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 17, games: new List<int> { 9510 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 27, games: new List<int> { 9503 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 2, games: new List<int> { 8704, 8910, 9105, 9207, 9210 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 3, games: new List<int> { 8911, 9004, 9408 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 4, games: new List<int> { 8912 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 5, games: new List<int> { 9409 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 6, games: new List<int> { 9511 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 7, games: new List<int> { 9208 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 8, games: new List<int> { 9411 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 10, games: new List<int> { 9401 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 13, games: new List<int> { 9410 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 36, games: new List<int> { 8906 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 37, games: new List<int> { 9301 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302, 9308, 9309, 9404, 9502 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 2, games: new List<int> { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 3, games: new List<int> { 9009, 9407 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 4, games: new List<int> { 8810, 9003 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 5, games: new List<int> { 9005, 9512 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 6, games: new List<int> { 8907 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 7, games: new List<int> { 9106 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 9, games: new List<int> { 9307 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 10, games: new List<int> { 9506, 9604 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 11, games: new List<int> { 8807, 8902, 9202, 9501 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 14, games: new List<int> { 9010 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 16, games: new List<int> { 9209 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 18, games: new List<int> { 9001, 9011 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 19, games: new List<int> { 9601, 9605 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 21, games: new List<int> { 8908 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9012 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 36, games: new List<int> { 9102 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 49, games: new List<int> { 9603 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 66, games: new List<int> { 9403 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 74, games: new List<int> { 9203 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 98, games: new List<int> { 8909 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 193, games: new List<int> { 8905 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 7, games: new List<int> { 9101 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 8, games: new List<int> { 9509 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 23, games: new List<int> { 9107 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 35, games: new List<int> { 9112 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 68, games: new List<int> { 8805 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 82, games: new List<int> { 8904 }, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        // These are the stranger instructions that do not start with the highest scoring starting shape
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 4, games: new List<int> { 8804 }, rootWidth: -2, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9602 }, rootWidth: -1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 28, games: new List<int> { 8803 }, rootWidth: -1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 40, games: new List<int> { 9305 }, rootWidth: -5, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 51, games: new List<int> { 9505 }, rootWidth: -6, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 77, games: new List<int> { 8806 }, rootWidth: -8, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9504 }, rootWidth: -3, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9507 }, rootWidth: -5, useGuidedScores: false, maxDepth: 30));

        return result;
    }
}