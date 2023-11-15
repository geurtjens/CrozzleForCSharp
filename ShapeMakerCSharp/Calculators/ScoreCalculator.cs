using System;


namespace ShapeMakerCSharp
{
	public class ScoreCalculator
	{
        public static int score(char letter)
        {
            switch (letter)
            {
                case 'A':
                    return 2;
                case 'B':
                    return 2;
                case 'C':
                    return 2;
                case 'D':
                    return 2;
                case 'E':
                    return 2;
                case 'F':
                    return 2;

                case 'G':
                    return 4;
                case 'H':
                    return 4;
                case 'I':
                    return 4;
                case 'J':
                    return 4;
                case 'K':
                    return 4;
                case 'L':
                    return 4;
                    
                case 'M':
                    return 8;
                case 'N':
                    return 8;
                case 'O':
                    return 8;
                case 'P':
                    return 8;
                case 'Q':
                    return 8;
                case 'R':
                    return 8;
                    
                case 'S':
                    return 16;
                case 'T':
                    return 16;
                case 'U':
                    return 16;
                case 'V':
                    return 16;
                case 'W':
                    return 16;
                case 'X':
                    return 16;
                    
                case 'Y':
                    return 32;
                    
                case 'Z':
                    return 64;
                    
                default:
                    return 0;
            }
        }


        public static int rectangle(char topLeft, char topRight, char bottomLeft, char bottomRight)
        {
            int result = score(topLeft) + score(topRight) + score(bottomLeft) + score(bottomRight) + 40;
            return result;
        }


        /// convenience method for calculating the score of the `topLeft` rectangle
        public static int topLeft(char topRight, char bottomLeft, char bottomRight)
        {
            int result = score(topRight) + score(bottomLeft) + score(bottomRight) + 40;
            return result;
        }


        /// convenience method for calculating the score of the `bottomLeft` rectangle
        public static int bottomLeft(char topLeft, char topRight, char bottomRight)
        {
            int result = score(topLeft) + score(topRight) + score(bottomRight) + 40;
            return result;
        }


        /// convenience method for calculating the score of the `bottomRight` rectangle
        public static int bottomRight(char topLeft, char topRight, char bottomLeft)
        {
            int result = score(topLeft) + score(topRight) + score(bottomLeft) + 40;
            return result;
        }

        /// convenience method for calculating the score of the `topRight` rectangle
        public static int topRight(char topLeft, char bottomLeft, char bottomRight)
        {
            int result = score(topLeft) + score(bottomLeft) + score(bottomRight) + 40;
            return result;
        }

        public static ushort clusterCalculator(
            in List<int> wordsHorizontal,
            in List<ClusterPosition> patternHorizontal,
            in List<string> start,
            in List<string> end,
            int horizontalWordCount,
            int verticalWordCount)
        {
            int result = (horizontalWordCount + verticalWordCount) * 10;
    
            for (int i=0; i<patternHorizontal.Count; i++) {
                switch (patternHorizontal[i]) { 
                    case ClusterPosition.leading:
                        for(int j=0; j<verticalWordCount; j++) {
                            result += score(end[wordsHorizontal[i]][j]);
                        }
                        break;
                    case ClusterPosition.trailing:
                        for (int j=0; j<verticalWordCount; j++) {
                            result += score(start[wordsHorizontal[i]][j]);
                        }
                        break;
                    case ClusterPosition.middle:
                        for (int j = 0; j < verticalWordCount; j++)
                        {
                            result += score(end[wordsHorizontal[i]][j]);
                        }
                        break;
                    case ClusterPosition.outer:
                        break;
                }
            }
            return (ushort)result;
        }

    }
}