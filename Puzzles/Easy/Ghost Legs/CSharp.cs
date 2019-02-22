/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Ghost Legs                   */
/* Difficulty: Easy                     */
/* Date solved: 22.02.2019              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    { 
        //Read diagram size.
        string[] line = Console.ReadLine().Split();
        int W = int.Parse(line[0]);
        int H = int.Parse(line[1]);
        
        //Read top labels and create start indices.
        string[] T = Console.ReadLine().Split(new [] { "  " }, StringSplitOptions.None);
        int[] Ti = new int[T.Length];
        
        for (int i = 0; i < Ti.Length; i++)
        {
            Ti[i] = i;
        }
        
        //Read diagram lines.
        for (int i = 0; i < H - 2; i++)
        {
            line = Console.ReadLine().Split('|');
            
            //Search for horizontal lines.
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] == "--")
                {
                    //Check where the horizontal line is and change indices.
                    for (int k = 0; k < Ti.Length; k++)
                    {
                        if (Ti[k] == j - 1)
                        {
                            Ti[k] += 1;
                        }
                        else if (Ti[k] == j)
                        {
                            Ti[k] -= 1;
                        }
                    }
                }
            }
        }
        
        //Read bottom labels.
        string[] B = Console.ReadLine().Split(new [] { "  " }, StringSplitOptions.None);
        
        //Print result.
        for (int i = 0; i < T.Length; i++)
        {
            Console.WriteLine(T[i] + B[Ti[i]]);
        }
    }
}