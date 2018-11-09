/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: The River I.                 */
/* Difficulty: Easy                     */
/* Date solved: 09.11.2018              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        long r1 = long.Parse(Console.ReadLine());
        long r2 = long.Parse(Console.ReadLine());

        //Find meeting point.
        while (r1 != r2)
        {
            if (r1 < r2)
            {
                r1 = GetNextRiverNumber(r1);
            }
            else
            {
                r2 = GetNextRiverNumber(r2);
            }
        }

        //Output meeting point.
        Console.WriteLine(r1);
    }
    
    //Calculates the a following river number (e.g 7 -> 14, 14 -> 19, etc).
    private static long GetNextRiverNumber(long riverNumber)
    {
        long nextRiverNumber = riverNumber;
        
        while (riverNumber > 0)
        {
            nextRiverNumber += riverNumber % 10;
            riverNumber -= riverNumber % 10;
            riverNumber /= 10;
        }
        
        return nextRiverNumber;
    }
}