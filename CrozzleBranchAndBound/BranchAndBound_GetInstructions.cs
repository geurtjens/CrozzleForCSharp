using System;
using CrozzleBranchAndBound;

namespace CrozzleBranchAndBound;

public class BranchAndBound_GetInstructions
{

    public static List<BranchAndBoundInstruction> AllWords_NoGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 8703 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 25, games: new List<int> { 8802, 9306 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 43, games: new List<int> { 9212 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 75, games: new List<int> { 8710 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 9002, 9109, 9312 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 50, games: new List<int> { 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 75, games: new List<int> { 8808, 9210 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 87, games: new List<int> { 9303 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8712, 9007, 9008 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 25, games: new List<int> { 8705, 8811, 9103, 9308 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 37, games: new List<int> { 8711 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        // 32 games full words so far

        // List<int> solvedgames: new List<int> { 8703, 8802, 9306, 9212, 8710, 9002, 9109, 9312, 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412, 8808, 9210, 9303, 8712, 9007, 9008, 8705, 8811, 9103, 9308, 8711 };

        return result;
    }

    public static List<BranchAndBoundInstruction> AllWords_UseGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 8703 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 25, games: new List<int> { 8802, 9306 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 43, games: new List<int> { 9212 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 75, games: new List<int> { 8710 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 9002, 9109, 9312 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 50, games: new List<int> { 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 75, games: new List<int> { 8808, 9210 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 87, games: new List<int> { 9303 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8712, 9007, 9008 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 25, games: new List<int> { 8705, 8811, 9103, 9308 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 37, games: new List<int> { 8711 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        // 32 games full words so far

        // List<int> solvedgames: new List<int> { 8703, 8802, 9306, 9212, 8710, 9002, 9109, 9312, 8612, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412, 8808, 9210, 9303, 8712, 9007, 9008, 8705, 8811, 9103, 9308, 8711 };

        return result;
    }


    public static List<BranchAndBoundInstruction> WinningWords_NoGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 8802, 8808, 9104, 9212, 9306, 9406 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 2, games: new List<int> { 8710, 9311 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 3, games: new List<int> { 9412 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 5, games: new List<int> { 8711 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 8, games: new List<int> { 9108 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 17, games: new List<int> { 9510 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 27, games: new List<int> { 9503 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 2, games: new List<int> { 8704, 8910, 9105, 9207, 9210 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 3, games: new List<int> { 8911, 9004, 9408 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 4, games: new List<int> { 8912 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 5, games: new List<int> { 9409 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 6, games: new List<int> { 9511 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 7, games: new List<int> { 9208 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 8, games: new List<int> { 9411 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 10, games: new List<int> { 9401 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 13, games: new List<int> { 9410 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 36, games: new List<int> { 8906 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 37, games: new List<int> { 9301 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302, 9308, 9309, 9404, 9502 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 2, games: new List<int> { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 3, games: new List<int> { 9009, 9407 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 4, games: new List<int> { 8810, 9003 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 5, games: new List<int> { 9005, 9512 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 6, games: new List<int> { 8907 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 7, games: new List<int> { 9106 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 9, games: new List<int> { 9307 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 10, games: new List<int> { 9506, 9604 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 11, games: new List<int> { 8807, 8902, 9202, 9501 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 18, games: new List<int> { 9001, 9011 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 19, games: new List<int> { 9601, 9605 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 21, games: new List<int> { 8908 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9012 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 36, games: new List<int> { 9102 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 66, games: new List<int> { 9403 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 98, games: new List<int> { 8909 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 107, games: new List<int> { 9203 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 124, games: new List<int> { 9603 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 153, games: new List<int> { 9010, 9209 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 193, games: new List<int> { 8905 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 454, games: new List<int> { 9507 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 7, games: new List<int> { 9101 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 8, games: new List<int> { 9509 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 23, games: new List<int> { 9107 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 35, games: new List<int> { 9112 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 68, games: new List<int> { 8805 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 82, games: new List<int> { 8904 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 140, games: new List<int> { 8904 }, rootShape: 0, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        // These are the stranger instructions that do not start with the highest scoring starting shape same as other winning word result
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 4, games: new List<int> { 8804 }, rootShape: 2, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9602 }, rootShape: 1, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 28, games: new List<int> { 8803 }, rootShape: 1, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 40, games: new List<int> { 9305 }, rootShape: 5, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 51, games: new List<int> { 9505 }, rootShape: 6, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 77, games: new List<int> { 8806 }, rootShape: 8, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9504 }, rootShape: 3, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9507 }, rootShape: 5, rootWidth: 1, useGuidedScores: false, maxDepth: 30));


        return result;
    }

    public static List<BranchAndBoundInstruction> WinningWords_UseGuidedScores()
    {
        List<BranchAndBoundInstruction> result = new List<BranchAndBoundInstruction>();

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 3, games: new List<int> { 8710 }, rootShape: 1, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 3, games: new List<int> { 8804 }, rootShape: 2, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> { 9212 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 1, games: new List<int> {
            8802, 8808, 9104, 9306, 9406 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 2, games: new List<int> { 9311 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 3, games: new List<int> { 9412 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 5, games: new List<int> { 8711 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 8, games: new List<int> { 9108 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 17, games: new List<int> { 9510 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        // This one doesnt work
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 1, beamWidth: 27, games: new List<int> { 9503 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 1, games: new List<int> { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 2, games: new List<int> { 8704, 8910, 9105, 9207, 9210 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 3, games: new List<int> { 8911, 9004, 9408 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 4, games: new List<int> { 8912 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 5, games: new List<int> { 9409 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 6, games: new List<int> { 9511 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 7, games: new List<int> { 9208 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 8, games: new List<int> { 9411 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 10, games: new List<int> { 9401 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 13, games: new List<int> { 9410 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 36, games: new List<int> { 8906 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 2, beamWidth: 37, games: new List<int> { 9301 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 1, games: new List<int> { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302, 9308, 9309, 9404, 9502 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 2, games: new List<int> { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 3, games: new List<int> { 9009, 9407 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 4, games: new List<int> { 8810, 9003 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 5, games: new List<int> { 9005, 9512 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 6, games: new List<int> { 8907 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 7, games: new List<int> { 9106 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 9, games: new List<int> { 9307 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 10, games: new List<int> { 9506, 9604 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 11, games: new List<int> { 8807, 8902, 9202, 9501 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 14, games: new List<int> { 9010 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 16, games: new List<int> { 9209 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 18, games: new List<int> { 9001, 9011 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 19, games: new List<int> { 9601, 9605 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 21, games: new List<int> { 8908 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9012 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 36, games: new List<int> { 9102 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 49, games: new List<int> { 9603 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 66, games: new List<int> { 9403 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 74, games: new List<int> { 9203 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 98, games: new List<int> { 8909 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 193, games: new List<int> { 8905 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 7, games: new List<int> { 9101 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 8, games: new List<int> { 9509 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 23, games: new List<int> { 9107 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 35, games: new List<int> { 9112 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 68, games: new List<int> { 8805 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 4, beamWidth: 82, games: new List<int> { 8904 }, rootShape: 0, rootWidth: 1, useGuidedScores: true, maxDepth: 30));

        // These are the stranger instructions that do not start with the highest scoring starting shape
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 22, games: new List<int> { 9602 }, rootShape: 1, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 28, games: new List<int> { 8803 }, rootShape: 1, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 40, games: new List<int> { 9305 }, rootShape: 5, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 51, games: new List<int> { 9505 }, rootShape: 6, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 77, games: new List<int> { 8806 }, rootShape: 8, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9504 }, rootShape: 3, rootWidth: 1, useGuidedScores: false, maxDepth: 30));
        result.Add(new BranchAndBoundInstruction(lookaheadDepth: 3, beamWidth: 87, games: new List<int> { 9507 }, rootShape: 5, rootWidth: 1, useGuidedScores: false, maxDepth: 30));

        return result;
    }
}