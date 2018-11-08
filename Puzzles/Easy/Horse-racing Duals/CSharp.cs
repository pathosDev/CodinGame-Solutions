/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Horse-racing Duals           */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read the inputs.
        int N = int.Parse(Console.ReadLine());
        
        int[] P = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        //Sort horse strengths.
        Array.Sort(P);
        
        //Find D.
        int D = int.MaxValue;
        
        for (int i = 1; i < N; i++)
        {
            D = Math.Min(D, P[i] - P[i - 1]);
        }
        
        //Print D.
        Console.WriteLine(D);
    }
}