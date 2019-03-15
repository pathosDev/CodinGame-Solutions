/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: How time flies               */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read dates.
        DateTime begin = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

        //Calculate result.
        int days = (end - begin).Days;
        int months = (DateTime.MinValue + (end - begin)).Month - 1;
        int years = days / 365;

        //Print result.
        if (years > 0)
        {
            Console.Write("{0} year{1}, ", years, years > 1 ? "s" : "");
        }

        if (months > 0)
        {
            Console.Write("{0} month{1}, ", months, months > 1 ? "s" : "");
        }

        Console.WriteLine("total {0} days", days);
    }
}