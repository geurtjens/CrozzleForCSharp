using System;
namespace CrozzleInterfaces;

public class ScoreCalculator
{
    public static int Score(char letter)
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
    
}