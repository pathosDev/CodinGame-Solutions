/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Bank Robbers                 */
/* Difficulty: Easy                     */
/* Date solved: 22.02.2019              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int R = int.Parse(Console.ReadLine());
        int V = int.Parse(Console.ReadLine());
        
        //List of times for each robber.
        int[] T = new int[R];
        
        for (int i = 0; i < V; i++)
        {
            string[] line = Console.ReadLine().Split();
            int C = int.Parse(line[0]);
            int N = int.Parse(line[1]);
            
            //Add vault time to the robber that has "nothing to do".
            T[0] += (int)(Math.Pow(10, N) * Math.Pow(5, C - N));
            Array.Sort(T);
        }
        
        //Print time of the robber with the most time.
        Console.WriteLine(T[R - 1]);
    }
}