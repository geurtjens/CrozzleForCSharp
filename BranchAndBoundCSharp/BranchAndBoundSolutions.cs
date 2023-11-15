using System;
using System.Linq;
using System.Reflection;
using CrozzleInterfaces;

namespace BranchAndBoundCSharp
{
    public class BranchAndBoundSolutions
    {
        public static GameIdList executeGamesWinningWords(
            GameIdList gameIds,
            int lookaheadDepth,
            int beamWidth,
            int maxDepth,
            int rootWidth,
            bool useGuidedScores)
        {
            return BranchAndBoundV3.ExecuteGamesWinningWords(gameIds, lookaheadDepth, beamWidth, maxDepth, rootWidth, useGuidedScores);
        }


        public static GameIdList executeGamesAllWords(
            GameIdList gameIds,
            int lookaheadDepth,
            int beamWidth,
            int maxDepth,
            int rootWidth,
            bool useGuidedScores)
        {
            return BranchAndBoundV3.ExecuteGamesAllWords(gameIds, lookaheadDepth, beamWidth, maxDepth, rootWidth, useGuidedScores);
        }


        // It cannot translate this so i will do it myself
        public void allShapesThatCanBeSolvedWithoutGuides()
        {

            GameIdList depth1_width1 = new GameIdList { 8802, 8808, 9104, 9212, 9306, 9406 };
            GameIdList depth2_width1 = new GameIdList { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 };
            GameIdList depth3_width1 = new GameIdList { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302,
                                                        9308, 9309, 9404, 9502 };
            GameIdList depth1_width2 = new GameIdList { 8710, 9311 };
            GameIdList depth2_width2 = new GameIdList { 8702, 8704, 8910, 9105, 9207, 9210 };
            GameIdList depth3_width2 = new GameIdList { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 };
            GameIdList depth1_width3 = new GameIdList { 9412 };
            GameIdList depth2_width3 = new GameIdList { 8911, 9004, 9408 };
            GameIdList depth3_width3 = new GameIdList { 9009, 9407 };
            GameIdList depth2_width4 = new GameIdList { 8912 };
            GameIdList depth3_width4 = new GameIdList { 8810, 9003 };
            GameIdList depth1_width5 = new GameIdList { 8711 };
            GameIdList depth2_width5 = new GameIdList { 9409 };
            GameIdList depth3_width5 = new GameIdList { 9005, 9512 };
            GameIdList depth2_width6 = new GameIdList { 9511 };
            GameIdList depth3_width6 = new GameIdList { 8907 };
            GameIdList depth2_width7 = new GameIdList { 9208 };
            GameIdList depth3_width7 = new GameIdList { 9106 };
            GameIdList depth1_width8 = new GameIdList { 9108 };
            GameIdList depth2_width8 = new GameIdList { 9411 };
            GameIdList depth3_width9 = new GameIdList { 9307 };
            GameIdList depth2_width10 = new GameIdList { 9401 };
            GameIdList depth3_width10 = new GameIdList { 9506, 9604 };
            GameIdList depth3_width11 = new GameIdList { 8807, 8902, 9202, 9501 };
            GameIdList depth2_width13 = new GameIdList { 9410 };



            GameIdList depth1_width17 = new GameIdList { 9510 };
            GameIdList depth3_width18 = new GameIdList { 9001, 9011 };
            GameIdList depth3_width19 = new GameIdList { 9601, 9605 };
            GameIdList depth3_width21 = new GameIdList { 8908 };
            GameIdList depth3_width22 = new GameIdList { 9012 };
            GameIdList depth1_width27 = new GameIdList { 9503 };
            GameIdList depth2_width36 = new GameIdList { 8906 };
            GameIdList depth3_width36 = new GameIdList { 9102 };
            GameIdList depth2_width37 = new GameIdList { 9301 };


            GameIdList depth3_width66 = new GameIdList { 9403 };


            GameIdList depth3_width98 = new GameIdList { 8909 };

            //GameIdList depth3_width74 = new GameIdList {9203 }; // only works with guided
            GameIdList depth3_width107 = new GameIdList { 9203 };


            //GameIdList depth3_width49 = new GameIdList {9603 }; // only works with guided
            GameIdList depth3_width124 = new GameIdList { 9603 };
            //GameIdList depth3_width14 = new GameIdList {9010 }; // only works with guided maxWidth of 100 failed
            //GameIdList depth3_width16 = new GameIdList {9209 }; // only works with guided
            GameIdList depth3_width153 = new GameIdList { 9010, 9209 };



            GameIdList depth3_width193 = new GameIdList { 8905 };
            GameIdList depth4_width7 = new GameIdList { 9101 };
            GameIdList depth4_width8 = new GameIdList { 9509 };
            GameIdList depth4_width23 = new GameIdList { 9107 };
            GameIdList depth4_width35 = new GameIdList { 9112 };
            GameIdList depth4_width68 = new GameIdList { 8805 };
            //GameIdList depth4_width82 = new GameIdList {8904] // only works with guided, last one to solve
            GameIdList depth4_width140 = new GameIdList { 8904 };

            //let depth3_width454 = new GameIdList {9507]

            //var overallStart = DateTimeCalculator.now();


            var solved = new GameIdList();

            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width1, lookaheadDepth: 1, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width1, lookaheadDepth: 2, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width1, lookaheadDepth: 3, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width2, lookaheadDepth: 1, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width2, lookaheadDepth: 2, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width2, lookaheadDepth: 3, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width3, lookaheadDepth: 1, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width3, lookaheadDepth: 2, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width3, lookaheadDepth: 3, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width4, lookaheadDepth: 2, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width4, lookaheadDepth: 3, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width5, lookaheadDepth: 1, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width5, lookaheadDepth: 2, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width5, lookaheadDepth: 3, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width6, lookaheadDepth: 2, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width6, lookaheadDepth: 3, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width7, lookaheadDepth: 2, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width7, lookaheadDepth: 3, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width8, lookaheadDepth: 1, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width8, lookaheadDepth: 2, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width9, lookaheadDepth: 3, beamWidth: 9, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width10, lookaheadDepth: 2, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width10, lookaheadDepth: 3, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width11, lookaheadDepth: 3, beamWidth: 11, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width13, lookaheadDepth: 2, beamWidth: 13, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            // changed this one with 9010 and 2909
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width153, lookaheadDepth: 3, beamWidth: 153, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width17, lookaheadDepth: 1, beamWidth: 17, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width18, lookaheadDepth: 3, beamWidth: 18, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width19, lookaheadDepth: 3, beamWidth: 19, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width21, lookaheadDepth: 3, beamWidth: 21, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width22, lookaheadDepth: 3, beamWidth: 22, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width27, lookaheadDepth: 1, beamWidth: 27, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width36, lookaheadDepth: 2, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width36, lookaheadDepth: 3, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width37, lookaheadDepth: 2, beamWidth: 37, maxDepth: 30, rootWidth: 1, useGuidedScores: false));


            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width66, lookaheadDepth: 3, beamWidth: 66, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width107, lookaheadDepth: 3, beamWidth: 107, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width124, lookaheadDepth: 3, beamWidth: 124, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width98, lookaheadDepth: 3, beamWidth: 98, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width193, lookaheadDepth: 3, beamWidth: 193, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width7, lookaheadDepth: 4, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width8, lookaheadDepth: 4, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width23, lookaheadDepth: 4, beamWidth: 23, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width35, lookaheadDepth: 4, beamWidth: 35, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width68, lookaheadDepth: 4, beamWidth: 68, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width140, lookaheadDepth: 4, beamWidth: 140, maxDepth: 30, rootWidth: 1, useGuidedScores: false));



            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 8803 },
                lookaheadDepth: 3,
                beamWidth: 28,
                maxDepth: 30,
                rootWidth: -1,
                useGuidedScores: false));

            // Start from winningWords[2]
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 8804 },
                lookaheadDepth: 3,
                beamWidth: 4,
                maxDepth: 30,
                rootWidth: -2,
                useGuidedScores: false)); ;

            // Start from winningWords[8]
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 8806 },
                lookaheadDepth: 3,
                beamWidth: 77,
                maxDepth: 30,
                rootWidth: -8,
                useGuidedScores: false)); ;

            // Start from winningWords[5]
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9305 },
                lookaheadDepth: 3,
                beamWidth: 40,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[3]
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9504 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -3,
                useGuidedScores: false));

            // Start from winningWords[6]
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9505 },
                lookaheadDepth: 3,
                beamWidth: 51,
                maxDepth: 30,
                rootWidth: -6,
                useGuidedScores: false));

            // Start from winningWords[6]
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9507 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[1]
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9602 },
                lookaheadDepth: 3,
                beamWidth: 22,
                maxDepth: 30,
                rootWidth: -1,
                useGuidedScores: false));


            solved.Sort();

            Console.WriteLine();
            for (int i = 0; i < solved.Count; i++)
            {
                Console.Write($"{solved[i]},");
            }
            Console.WriteLine();

            GameIdList gameList = GameList.Games();
            var missing = new GameIdList();

            for (int i = 0; i < gameList.Count; i++)
            {
                if (solved.Contains(gameList[i]) == false)
                {
                    missing.Add(gameList[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < missing.Count; i++)
            {
                Console.Write($"{solved[i]},");
            }
            Console.WriteLine();

        }





        // Console.WriteLine($"Overall Duration: {DateTimeCalculator.duration(start: overallStart)}");







        public static void allShapesThatCanBeSolved()
        {

            GameIdList depth1_width1 = new GameIdList { 8802, 8808, 9104, 9212, 9306, 9406 };
            GameIdList depth2_width1 = new GameIdList { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 };
            GameIdList depth3_width1 = new GameIdList { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302, 9308, 9309, 9404, 9502 };
            GameIdList depth1_width2 = new GameIdList { 8710, 9311 };
            GameIdList depth2_width2 = new GameIdList { 8702, 8704, 8910, 9105, 9207, 9210 };
            GameIdList depth3_width2 = new GameIdList { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 };
            GameIdList depth1_width3 = new GameIdList { 9412 };
            GameIdList depth2_width3 = new GameIdList { 8911, 9004, 9408 };
            GameIdList depth3_width3 = new GameIdList { 9009, 9407 };
            GameIdList depth2_width4 = new GameIdList { 8912 };
            GameIdList depth3_width4 = new GameIdList { 8810, 9003 };
            GameIdList depth1_width5 = new GameIdList { 8711 };
            GameIdList depth2_width5 = new GameIdList { 9409 };
            GameIdList depth3_width5 = new GameIdList { 9005, 9512 };
            GameIdList depth2_width6 = new GameIdList { 9511 };
            GameIdList depth3_width6 = new GameIdList { 8907 };
            GameIdList depth2_width7 = new GameIdList { 9208 };
            GameIdList depth3_width7 = new GameIdList { 9106 };
            GameIdList depth1_width8 = new GameIdList { 9108 };
            GameIdList depth2_width8 = new GameIdList { 9411 };
            GameIdList depth3_width9 = new GameIdList { 9307 };
            GameIdList depth2_width10 = new GameIdList { 9401 };
            GameIdList depth3_width10 = new GameIdList { 9506, 9604 };
            GameIdList depth3_width11 = new GameIdList { 8807, 8902, 9202, 9501 };
            GameIdList depth2_width13 = new GameIdList { 9410 };
            GameIdList depth3_width14 = new GameIdList { 9010 };
            GameIdList depth3_width16 = new GameIdList { 9209 };
            GameIdList depth1_width17 = new GameIdList { 9510 };
            GameIdList depth3_width18 = new GameIdList { 9001, 9011 };
            GameIdList depth3_width19 = new GameIdList { 9601, 9605 };
            GameIdList depth3_width21 = new GameIdList { 8908 };
            GameIdList depth3_width22 = new GameIdList { 9012 };
            GameIdList depth1_width27 = new GameIdList { 9503 };
            GameIdList depth2_width36 = new GameIdList { 8906 };
            GameIdList depth3_width36 = new GameIdList { 9102 };
            GameIdList depth2_width37 = new GameIdList { 9301 };
            GameIdList depth3_width49 = new GameIdList { 9603 };
            GameIdList depth3_width66 = new GameIdList { 9403 };
            GameIdList depth3_width74 = new GameIdList { 9203 };
            GameIdList depth3_width98 = new GameIdList { 8909 };
            GameIdList depth3_width193 = new GameIdList { 8905 };
            GameIdList depth4_width7 = new GameIdList { 9101 };
            GameIdList depth4_width8 = new GameIdList { 9509 };
            GameIdList depth4_width23 = new GameIdList { 9107 };
            GameIdList depth4_width35 = new GameIdList { 9112 };
            GameIdList depth4_width68 = new GameIdList { 8805 };
            GameIdList depth4_width82 = new GameIdList { 8904 };

            //GameIdList depth3_width454 = new GameIdList {9507 };

            // var  overallStart = DateTimeCalculator.now()


            GameIdList solved = new GameIdList();

            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width1, lookaheadDepth: 1, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width1, lookaheadDepth: 2, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width1, lookaheadDepth: 3, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width2, lookaheadDepth: 1, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width2, lookaheadDepth: 2, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width2, lookaheadDepth: 3, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width3, lookaheadDepth: 1, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width3, lookaheadDepth: 2, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width3, lookaheadDepth: 3, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width4, lookaheadDepth: 2, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width4, lookaheadDepth: 3, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width5, lookaheadDepth: 1, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width5, lookaheadDepth: 2, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width5, lookaheadDepth: 3, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width6, lookaheadDepth: 2, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width6, lookaheadDepth: 3, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width7, lookaheadDepth: 2, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width7, lookaheadDepth: 3, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width8, lookaheadDepth: 1, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width8, lookaheadDepth: 2, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width9, lookaheadDepth: 3, beamWidth: 9, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width10, lookaheadDepth: 2, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width10, lookaheadDepth: 3, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width11, lookaheadDepth: 3, beamWidth: 11, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width13, lookaheadDepth: 2, beamWidth: 13, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width14, lookaheadDepth: 3, beamWidth: 14, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width16, lookaheadDepth: 3, beamWidth: 16, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width17, lookaheadDepth: 1, beamWidth: 17, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width18, lookaheadDepth: 3, beamWidth: 18, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width19, lookaheadDepth: 3, beamWidth: 19, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width21, lookaheadDepth: 3, beamWidth: 21, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width22, lookaheadDepth: 3, beamWidth: 22, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth1_width27, lookaheadDepth: 1, beamWidth: 27, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width36, lookaheadDepth: 2, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width36, lookaheadDepth: 3, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth2_width37, lookaheadDepth: 2, beamWidth: 37, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width49, lookaheadDepth: 3, beamWidth: 49, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width66, lookaheadDepth: 3, beamWidth: 66, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width74, lookaheadDepth: 3, beamWidth: 74, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width98, lookaheadDepth: 3, beamWidth: 98, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth3_width193, lookaheadDepth: 3, beamWidth: 193, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width7, lookaheadDepth: 4, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width8, lookaheadDepth: 4, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width23, lookaheadDepth: 4, beamWidth: 23, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width35, lookaheadDepth: 4, beamWidth: 35, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width68, lookaheadDepth: 4, beamWidth: 68, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(executeGamesWinningWords(gameIds: depth4_width82, lookaheadDepth: 4, beamWidth: 82, maxDepth: 30, rootWidth: 1, useGuidedScores: true));



            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 8803 },
                lookaheadDepth: 3,
                beamWidth: 28,
                maxDepth: 30,
                rootWidth: -1,
                useGuidedScores: false));

            // Start from winningWords[2 };
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 8804 },
                lookaheadDepth: 3,
                beamWidth: 4,
                maxDepth: 30,
                rootWidth: -2,
                useGuidedScores: false));

            // Start from winningWords[8 };
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 8806 },
                lookaheadDepth: 3,
                beamWidth: 77,
                maxDepth: 30,
                rootWidth: -8,
                useGuidedScores: false));

            // Start from winningWords[5 };
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9305 },
                lookaheadDepth: 3,
                beamWidth: 40,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[3 };
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9504 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -3,
                useGuidedScores: false));

            // Start from winningWords[6 };
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9505 },
                lookaheadDepth: 3,
                beamWidth: 51,
                maxDepth: 30,
                rootWidth: -6,
                useGuidedScores: false));

            // Start from winningWords[6 };
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9507 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[1 };
            solved.AddRange(executeGamesWinningWords(
                gameIds: new GameIdList { 9602 },
                lookaheadDepth: 3,
                beamWidth: 22,
                maxDepth: 30,
                rootWidth: -1,
                useGuidedScores: false));

            solved.Sort();

            Console.WriteLine();
            for (int i = 0; i < solved.Count; i++)
            {
                Console.Write($"{solved[i]},");
            }
            Console.WriteLine();

            GameIdList gameList = GameList.Games();
            var missing = new GameIdList();

            for (int i = 0; i < gameList.Count; i++)
            {
                if (solved.Contains(gameList[i]) == false)
                {
                    missing.Add(gameList[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < missing.Count; i++)
            {
                Console.Write($"{solved[i]},");
            }
            Console.WriteLine();
        }



        public static void AllShapesThatCanBeSolvedWithAllWords()
        {
            GameIdList depth1_width1 = new GameIdList { 8703 };
            GameIdList depth1_width25 = new GameIdList { 8802, 9306 };
            GameIdList depth1_width43 = new GameIdList { 9212 };
            GameIdList depth1_width75 = new GameIdList { 8710 };

            GameIdList depth2_width1 = new GameIdList { 9002, 9109, 9312 };
            GameIdList depth2_width50 = new GameIdList { 8612, 8702, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412 };
            GameIdList depth2_width75 = new GameIdList { 8808, 9210 };
            GameIdList depth2_width87 = new GameIdList { 9303 };

            GameIdList depth3_width1 = new GameIdList { 8712, 9007, 9008 };
            GameIdList depth3_width25 = new GameIdList { 8705, 8811, 9103, 9308 };
            GameIdList depth3_width37 = new GameIdList { 8711 };

            GameIdList solvedGames = new GameIdList
                {
                    8703, 8802, 9306, 9212, 8710, 9002, 9109, 9312, 8612, 8702,
                    8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311,
                    9412, 8808, 9210, 9303, 8712, 9007, 9008, 8705, 8811, 9103,
                    9308, 8711
                };

            //var overallStart = DateTimeCalculator.Now();

            GameIdList solved = new GameIdList();

            solved.AddRange(executeGamesAllWords(depth1_width1, 1, 1, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth1_width25, 1, 25, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth1_width43, 1, 43, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth1_width75, 1, 75, 30, 1, false));

            solved.AddRange(executeGamesAllWords(depth2_width1, 2, 1, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth2_width50, 2, 50, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth2_width75, 2, 75, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth2_width87, 2, 87, 30, 1, false));

            solved.AddRange(executeGamesAllWords(depth3_width1, 3, 1, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth3_width25, 3, 25, 30, 1, false));
            solved.AddRange(executeGamesAllWords(depth3_width37, 3, 37, 30, 1, false));

            var gameIds = GameList.Games();
            var missing = new GameIdList();
            foreach (var gameId in gameIds)
            {
                if (!solved.Contains(gameId))
                {
                    missing.Add(gameId);
                }
            }
            solved.Sort();
            missing.Sort();
            Console.WriteLine($"Solved: {string.Join(", ", solved)}");
            Console.WriteLine($"Missing: {string.Join(", ", missing)}");

            //Console.WriteLine($"Overall Duration: {DateTimeCalculator.Duration(overallStart)}");
        }
    }
}