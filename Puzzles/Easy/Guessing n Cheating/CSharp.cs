/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Guessing n Cheating          */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        int R = int.Parse(Console.ReadLine());
        
        int start = 1, end = 100;
        
        for (int i = 0; i < R; i++)
        {
            //Read conversations.
            string[] guess = Console.ReadLine().Split();
            
            int bob = int.Parse(guess[0]);
            string alice = guess[1] + " " + guess[2];
            
            //Adjust range.
            if (alice == "too low")
            {
                start = Math.Max(start, bob + 1);
            }
            else if (alice == "too high")
            {
                end = Math.Min(end, bob - 1);
            }
        
            //Check if alice cheated.
            if (end < start || alice == "right on" && !(start <= bob && bob <= end))
            {
                Console.WriteLine("Alice cheated in round {0}", i + 1);
                Environment.Exit(0);
            }
        }
        
        //Alice didn't cheat.
        Console.WriteLine("No evidence of cheating");
    }
}