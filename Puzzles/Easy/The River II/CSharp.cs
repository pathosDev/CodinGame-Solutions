/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: The River II.                */
/* Difficulty: Easy                     */
/* Date solved: 09.11.2018              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read input.
        int r1 = int.Parse(Console.ReadLine());

        bool riversMeetR1 = false;

        //Find rivers that meet r1.
        for (int i = r1 - 1; i > 0 && !riversMeetR1; i--)
        {
            riversMeetR1 = (GetNextRiverNumber(i) == r1);
        }
        
        //Output if other rivers meet r1.
        Console.WriteLine(riversMeetR1 ? "YES" : "NO");
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