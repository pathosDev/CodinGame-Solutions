/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Brick in the Wall            */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

using System;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int X = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int[] M = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(s => s).ToArray();
        
        double W = 0;
        
        //Calculate minimum work.
        for (int i = 0; i < N; i++)
        {
            int L = i / X;
            W += L * .65 * M[i];
        }
            
        //Print minimum work.
        Console.WriteLine(Math.Round(W, 3).ToString("0.000"));
    }
}