using CrozzleInterfaces;

namespace CrozzleBranchAndBound
{
    public class BranchAndBoundSolutions
    {
        public static List<int> ExecuteGamesWinningWords(
            List<int> gameIds,
            int lookaheadDepth,
            int beamWidth,
            int maxDepth,
            int rootWidth,
            bool useGuidedScores)
        {
            return BranchAndBoundRunner.ExecuteGamesWinningWords(gameIds, lookaheadDepth, beamWidth, maxDepth, rootWidth, useGuidedScores);
        }


        public static List<int> ExecuteGamesAllWords(
            List<int> gameIds,
            int lookaheadDepth,
            int beamWidth,
            int maxDepth,
            int rootWidth,
            bool useGuidedScores)
        {
            return BranchAndBoundRunner.ExecuteGamesAllWords(gameIds, lookaheadDepth, beamWidth, maxDepth, rootWidth, useGuidedScores);
        }


        // It cannot translate this so i will do it myself
        public void AllShapesThatCanBeSolvedWithoutGuides()
        {

            List<int> depth1_width1 = new List<int> { 8802, 8808, 9104, 9212, 9306, 9406 };
            List<int> depth2_width1 = new List<int> { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 };
            List<int> depth3_width1 = new List<int> { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302,
                                                        9308, 9309, 9404, 9502 };
            List<int> depth1_width2 = new List<int> { 8710, 9311 };
            List<int> depth2_width2 = new List<int> { 8702, 8704, 8910, 9105, 9207, 9210 };
            List<int> depth3_width2 = new List<int> { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 };
            List<int> depth1_width3 = new List<int> { 9412 };
            List<int> depth2_width3 = new List<int> { 8911, 9004, 9408 };
            List<int> depth3_width3 = new List<int> { 9009, 9407 };
            List<int> depth2_width4 = new List<int> { 8912 };
            List<int> depth3_width4 = new List<int> { 8810, 9003 };
            List<int> depth1_width5 = new List<int> { 8711 };
            List<int> depth2_width5 = new List<int> { 9409 };
            List<int> depth3_width5 = new List<int> { 9005, 9512 };
            List<int> depth2_width6 = new List<int> { 9511 };
            List<int> depth3_width6 = new List<int> { 8907 };
            List<int> depth2_width7 = new List<int> { 9208 };
            List<int> depth3_width7 = new List<int> { 9106 };
            List<int> depth1_width8 = new List<int> { 9108 };
            List<int> depth2_width8 = new List<int> { 9411 };
            List<int> depth3_width9 = new List<int> { 9307 };
            List<int> depth2_width10 = new List<int> { 9401 };
            List<int> depth3_width10 = new List<int> { 9506, 9604 };
            List<int> depth3_width11 = new List<int> { 8807, 8902, 9202, 9501 };
            List<int> depth2_width13 = new List<int> { 9410 };



            List<int> depth1_width17 = new List<int> { 9510 };
            List<int> depth3_width18 = new List<int> { 9001, 9011 };
            List<int> depth3_width19 = new List<int> { 9601, 9605 };
            List<int> depth3_width21 = new List<int> { 8908 };
            List<int> depth3_width22 = new List<int> { 9012 };
            List<int> depth1_width27 = new List<int> { 9503 };
            List<int> depth2_width36 = new List<int> { 8906 };
            List<int> depth3_width36 = new List<int> { 9102 };
            List<int> depth2_width37 = new List<int> { 9301 };


            List<int> depth3_width66 = new List<int> { 9403 };


            List<int> depth3_width98 = new List<int> { 8909 };

            //List<int> depth3_width74 = new List<int> {9203 }; // only works with guided
            List<int> depth3_width107 = new List<int> { 9203 };


            //List<int> depth3_width49 = new List<int> {9603 }; // only works with guided
            List<int> depth3_width124 = new List<int> { 9603 };
            //List<int> depth3_width14 = new List<int> {9010 }; // only works with guided maxWidth of 100 failed
            //List<int> depth3_width16 = new List<int> {9209 }; // only works with guided
            List<int> depth3_width153 = new List<int> { 9010, 9209 };



            List<int> depth3_width193 = new List<int> { 8905 };
            List<int> depth4_width7 = new List<int> { 9101 };
            List<int> depth4_width8 = new List<int> { 9509 };
            List<int> depth4_width23 = new List<int> { 9107 };
            List<int> depth4_width35 = new List<int> { 9112 };
            List<int> depth4_width68 = new List<int> { 8805 };
            //List<int> depth4_width82 = new List<int> {8904] // only works with guided, last one to solve
            List<int> depth4_width140 = new List<int> { 8904 };

            //let depth3_width454 = new List<int> {9507]

            //var overallStart = DateTimeCalculator.now();


            var solved = new List<int>();

            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width1, lookaheadDepth: 1, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width1, lookaheadDepth: 2, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width1, lookaheadDepth: 3, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width2, lookaheadDepth: 1, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width2, lookaheadDepth: 2, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width2, lookaheadDepth: 3, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width3, lookaheadDepth: 1, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width3, lookaheadDepth: 2, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width3, lookaheadDepth: 3, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width4, lookaheadDepth: 2, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width4, lookaheadDepth: 3, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width5, lookaheadDepth: 1, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width5, lookaheadDepth: 2, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width5, lookaheadDepth: 3, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width6, lookaheadDepth: 2, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width6, lookaheadDepth: 3, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width7, lookaheadDepth: 2, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width7, lookaheadDepth: 3, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width8, lookaheadDepth: 1, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width8, lookaheadDepth: 2, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width9, lookaheadDepth: 3, beamWidth: 9, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width10, lookaheadDepth: 2, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width10, lookaheadDepth: 3, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width11, lookaheadDepth: 3, beamWidth: 11, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width13, lookaheadDepth: 2, beamWidth: 13, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            // changed this one with 9010 and 2909
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width153, lookaheadDepth: 3, beamWidth: 153, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width17, lookaheadDepth: 1, beamWidth: 17, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width18, lookaheadDepth: 3, beamWidth: 18, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width19, lookaheadDepth: 3, beamWidth: 19, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width21, lookaheadDepth: 3, beamWidth: 21, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width22, lookaheadDepth: 3, beamWidth: 22, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width27, lookaheadDepth: 1, beamWidth: 27, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width36, lookaheadDepth: 2, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width36, lookaheadDepth: 3, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width37, lookaheadDepth: 2, beamWidth: 37, maxDepth: 30, rootWidth: 1, useGuidedScores: false));


            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width66, lookaheadDepth: 3, beamWidth: 66, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width107, lookaheadDepth: 3, beamWidth: 107, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width124, lookaheadDepth: 3, beamWidth: 124, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width98, lookaheadDepth: 3, beamWidth: 98, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width193, lookaheadDepth: 3, beamWidth: 193, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width7, lookaheadDepth: 4, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width8, lookaheadDepth: 4, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width23, lookaheadDepth: 4, beamWidth: 23, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width35, lookaheadDepth: 4, beamWidth: 35, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width68, lookaheadDepth: 4, beamWidth: 68, maxDepth: 30, rootWidth: 1, useGuidedScores: false));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width140, lookaheadDepth: 4, beamWidth: 140, maxDepth: 30, rootWidth: 1, useGuidedScores: false));



            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 8803 },
                lookaheadDepth: 3,
                beamWidth: 28,
                maxDepth: 30,
                rootWidth: -1,
                useGuidedScores: false));

            // Start from winningWords[2]
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 8804 },
                lookaheadDepth: 3,
                beamWidth: 4,
                maxDepth: 30,
                rootWidth: -2,
                useGuidedScores: false)); ;

            // Start from winningWords[8]
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 8806 },
                lookaheadDepth: 3,
                beamWidth: 77,
                maxDepth: 30,
                rootWidth: -8,
                useGuidedScores: false)); ;

            // Start from winningWords[5]
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9305 },
                lookaheadDepth: 3,
                beamWidth: 40,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[3]
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9504 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -3,
                useGuidedScores: false));

            // Start from winningWords[6]
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9505 },
                lookaheadDepth: 3,
                beamWidth: 51,
                maxDepth: 30,
                rootWidth: -6,
                useGuidedScores: false));

            // Start from winningWords[6]
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9507 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[1]
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9602 },
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

            List<int> gameList = GameList.Games();
            var missing = new List<int>();

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







        public static void AllShapesThatCanBeSolved()
        {

            List<int> depth1_width1 = new List<int> { 8802, 8808, 9104, 9212, 9306, 9406 };
            List<int> depth2_width1 = new List<int> { 8612, 8809, 9002, 9109, 9201, 9211, 9303, 9310, 9312 };
            List<int> depth3_width1 = new List<int> { 8705, 8712, 8811, 9007, 9008, 9103, 9110, 9111, 9206, 9302, 9308, 9309, 9404, 9502 };
            List<int> depth1_width2 = new List<int> { 8710, 9311 };
            List<int> depth2_width2 = new List<int> { 8702, 8704, 8910, 9105, 9207, 9210 };
            List<int> depth3_width2 = new List<int> { 8812, 8903, 8910, 9006, 9204, 9304, 9402, 9508 };
            List<int> depth1_width3 = new List<int> { 9412 };
            List<int> depth2_width3 = new List<int> { 8911, 9004, 9408 };
            List<int> depth3_width3 = new List<int> { 9009, 9407 };
            List<int> depth2_width4 = new List<int> { 8912 };
            List<int> depth3_width4 = new List<int> { 8810, 9003 };
            List<int> depth1_width5 = new List<int> { 8711 };
            List<int> depth2_width5 = new List<int> { 9409 };
            List<int> depth3_width5 = new List<int> { 9005, 9512 };
            List<int> depth2_width6 = new List<int> { 9511 };
            List<int> depth3_width6 = new List<int> { 8907 };
            List<int> depth2_width7 = new List<int> { 9208 };
            List<int> depth3_width7 = new List<int> { 9106 };
            List<int> depth1_width8 = new List<int> { 9108 };
            List<int> depth2_width8 = new List<int> { 9411 };
            List<int> depth3_width9 = new List<int> { 9307 };
            List<int> depth2_width10 = new List<int> { 9401 };
            List<int> depth3_width10 = new List<int> { 9506, 9604 };
            List<int> depth3_width11 = new List<int> { 8807, 8902, 9202, 9501 };
            List<int> depth2_width13 = new List<int> { 9410 };
            List<int> depth3_width14 = new List<int> { 9010 };
            List<int> depth3_width16 = new List<int> { 9209 };
            List<int> depth1_width17 = new List<int> { 9510 };
            List<int> depth3_width18 = new List<int> { 9001, 9011 };
            List<int> depth3_width19 = new List<int> { 9601, 9605 };
            List<int> depth3_width21 = new List<int> { 8908 };
            List<int> depth3_width22 = new List<int> { 9012 };
            List<int> depth1_width27 = new List<int> { 9503 };
            List<int> depth2_width36 = new List<int> { 8906 };
            List<int> depth3_width36 = new List<int> { 9102 };
            List<int> depth2_width37 = new List<int> { 9301 };
            List<int> depth3_width49 = new List<int> { 9603 };
            List<int> depth3_width66 = new List<int> { 9403 };
            List<int> depth3_width74 = new List<int> { 9203 };
            List<int> depth3_width98 = new List<int> { 8909 };
            List<int> depth3_width193 = new List<int> { 8905 };
            List<int> depth4_width7 = new List<int> { 9101 };
            List<int> depth4_width8 = new List<int> { 9509 };
            List<int> depth4_width23 = new List<int> { 9107 };
            List<int> depth4_width35 = new List<int> { 9112 };
            List<int> depth4_width68 = new List<int> { 8805 };
            List<int> depth4_width82 = new List<int> { 8904 };

            //List<int> depth3_width454 = new List<int> {9507 };

            // var  overallStart = DateTimeCalculator.now()


            List<int> solved = new List<int>();

            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width1, lookaheadDepth: 1, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width1, lookaheadDepth: 2, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width1, lookaheadDepth: 3, beamWidth: 1, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width2, lookaheadDepth: 1, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width2, lookaheadDepth: 2, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width2, lookaheadDepth: 3, beamWidth: 2, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width3, lookaheadDepth: 1, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width3, lookaheadDepth: 2, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width3, lookaheadDepth: 3, beamWidth: 3, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width4, lookaheadDepth: 2, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width4, lookaheadDepth: 3, beamWidth: 4, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width5, lookaheadDepth: 1, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width5, lookaheadDepth: 2, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width5, lookaheadDepth: 3, beamWidth: 5, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width6, lookaheadDepth: 2, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width6, lookaheadDepth: 3, beamWidth: 6, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width7, lookaheadDepth: 2, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width7, lookaheadDepth: 3, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width8, lookaheadDepth: 1, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width8, lookaheadDepth: 2, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width9, lookaheadDepth: 3, beamWidth: 9, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width10, lookaheadDepth: 2, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width10, lookaheadDepth: 3, beamWidth: 10, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width11, lookaheadDepth: 3, beamWidth: 11, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width13, lookaheadDepth: 2, beamWidth: 13, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width14, lookaheadDepth: 3, beamWidth: 14, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width16, lookaheadDepth: 3, beamWidth: 16, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width17, lookaheadDepth: 1, beamWidth: 17, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width18, lookaheadDepth: 3, beamWidth: 18, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width19, lookaheadDepth: 3, beamWidth: 19, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width21, lookaheadDepth: 3, beamWidth: 21, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width22, lookaheadDepth: 3, beamWidth: 22, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth1_width27, lookaheadDepth: 1, beamWidth: 27, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width36, lookaheadDepth: 2, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width36, lookaheadDepth: 3, beamWidth: 36, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth2_width37, lookaheadDepth: 2, beamWidth: 37, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width49, lookaheadDepth: 3, beamWidth: 49, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width66, lookaheadDepth: 3, beamWidth: 66, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width74, lookaheadDepth: 3, beamWidth: 74, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width98, lookaheadDepth: 3, beamWidth: 98, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth3_width193, lookaheadDepth: 3, beamWidth: 193, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width7, lookaheadDepth: 4, beamWidth: 7, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width8, lookaheadDepth: 4, beamWidth: 8, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width23, lookaheadDepth: 4, beamWidth: 23, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width35, lookaheadDepth: 4, beamWidth: 35, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width68, lookaheadDepth: 4, beamWidth: 68, maxDepth: 30, rootWidth: 1, useGuidedScores: true));
            solved.AddRange(ExecuteGamesWinningWords(gameIds: depth4_width82, lookaheadDepth: 4, beamWidth: 82, maxDepth: 30, rootWidth: 1, useGuidedScores: true));



            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 8803 },
                lookaheadDepth: 3,
                beamWidth: 28,
                maxDepth: 30,
                rootWidth: -1,
                useGuidedScores: false));

            // Start from winningWords[2 };
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 8804 },
                lookaheadDepth: 3,
                beamWidth: 4,
                maxDepth: 30,
                rootWidth: -2,
                useGuidedScores: false));

            // Start from winningWords[8 };
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 8806 },
                lookaheadDepth: 3,
                beamWidth: 77,
                maxDepth: 30,
                rootWidth: -8,
                useGuidedScores: false));

            // Start from winningWords[5 };
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9305 },
                lookaheadDepth: 3,
                beamWidth: 40,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[3 };
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9504 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -3,
                useGuidedScores: false));

            // Start from winningWords[6 };
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9505 },
                lookaheadDepth: 3,
                beamWidth: 51,
                maxDepth: 30,
                rootWidth: -6,
                useGuidedScores: false));

            // Start from winningWords[6 };
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9507 },
                lookaheadDepth: 3,
                beamWidth: 87,
                maxDepth: 30,
                rootWidth: -5,
                useGuidedScores: false));

            // Start from winningWords[1 };
            solved.AddRange(ExecuteGamesWinningWords(
                gameIds: new List<int> { 9602 },
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

            List<int> gameList = GameList.Games();
            var missing = new List<int>();

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
            List<int> depth1_width1 = new List<int> { 8703 };
            List<int> depth1_width25 = new List<int> { 8802, 9306 };
            List<int> depth1_width43 = new List<int> { 9212 };
            List<int> depth1_width75 = new List<int> { 8710 };

            List<int> depth2_width1 = new List<int> { 9002, 9109, 9312 };
            List<int> depth2_width50 = new List<int> { 8612, 8702, 8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311, 9412 };
            List<int> depth2_width75 = new List<int> { 8808, 9210 };
            List<int> depth2_width87 = new List<int> { 9303 };

            List<int> depth3_width1 = new List<int> { 8712, 9007, 9008 };
            List<int> depth3_width25 = new List<int> { 8705, 8811, 9103, 9308 };
            List<int> depth3_width37 = new List<int> { 8711 };

            List<int> solvedGames = new List<int>
                {
                    8703, 8802, 9306, 9212, 8710, 9002, 9109, 9312, 8612, 8702,
                    8704, 8809, 8910, 8912, 9104, 9105, 9108, 9207, 9310, 9311,
                    9412, 8808, 9210, 9303, 8712, 9007, 9008, 8705, 8811, 9103,
                    9308, 8711
                };

            //var overallStart = DateTimeCalculator.Now();

            List<int> solved = new List<int>();

            solved.AddRange(ExecuteGamesAllWords(depth1_width1, 1, 1, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth1_width25, 1, 25, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth1_width43, 1, 43, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth1_width75, 1, 75, 30, 1, false));

            solved.AddRange(ExecuteGamesAllWords(depth2_width1, 2, 1, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth2_width50, 2, 50, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth2_width75, 2, 75, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth2_width87, 2, 87, 30, 1, false));

            solved.AddRange(ExecuteGamesAllWords(depth3_width1, 3, 1, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth3_width25, 3, 25, 30, 1, false));
            solved.AddRange(ExecuteGamesAllWords(depth3_width37, 3, 37, 30, 1, false));

            var gameIds = GameList.Games();
            var missing = new List<int>();
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