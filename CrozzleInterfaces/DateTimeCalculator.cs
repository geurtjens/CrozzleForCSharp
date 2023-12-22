using System;
namespace CrozzleInterfaces;

using System;

public class DateTimeCalculator
{
    public static void PrintDate(string message)
    {
        if (FeatureFlags.Verbose)
        {
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss.ffff");
            Console.WriteLine($"{message} {formattedDate}");
        }
    }

    public static DateTime Now()
    {
        return DateTime.Now;
    }

    public static double Seconds(DateTime start, DateTime finish)
    {
        TimeSpan duration = finish - start;
        return duration.TotalSeconds;
    }

    public static string Duration(DateTime start)
    {
        DateTime finishTime = Now();
        return Duration(start, finishTime);
    }

    public static string Duration(DateTime start, DateTime finish)
    {
        double durationSeconds = Seconds(start, finish);

        if (durationSeconds > 10)
        {
            int durationSecondsInt = (int)durationSeconds;

            if (durationSecondsInt > 60)
            {
                string result = "";
                int seconds = durationSecondsInt % 60;
                int minutes = durationSecondsInt / 60;
                int hours = minutes / 60;
                if (hours > 0)
                {
                    minutes = minutes % 60;
                }

                if (hours > 0)
                {
                    result += $"{hours} hours ";
                }

                if (minutes > 0)
                {
                    result += $"{minutes} minutes ";
                }

                if (seconds > 0)
                {
                    result += $"{seconds} seconds";
                }
                return result;

            }
            else
            {
                return $"{durationSecondsInt} seconds";
            }
        }
        else
        {
            return $"{durationSeconds} seconds";
        }
    }
}

public static class FeatureFlags
{
    public static bool Verbose { get; set; } = true;
}


