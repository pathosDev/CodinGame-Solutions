/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Ghost Legs                   */
/* Difficulty: Easy                     */
/* Date solved: 22.02.2019              */
/*                                      */
/****************************************/

import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    { 
        //Read diagram size.
        Scanner scanner = new Scanner(System.in);
        
        String[] line = scanner.nextLine().split(" ");
        int W = Integer.parseInt(line[0]);
        int H = Integer.parseInt(line[1]);
        
        //Read top labels and create start indices.
        String[] T = scanner.nextLine().split("  ");
        int[] Ti = new int[T.length];
        
        for (int i = 0; i < Ti.length; i++)
        {
            Ti[i] = i;
        }
        
        //Read diagram lines.
        for (int i = 0; i < H - 2; i++)
        {
            line = scanner.nextLine().split("\\|");
            
            //Search for horizontal lines.
            for (int j = 0; j < line.length; j++)
            {
                if (line[j].equals("--"))
                {
                    //Check where the horizontal line is and change indices.
                    for (int k = 0; k < Ti.length; k++)
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
        String[] B = scanner.nextLine().split("  ");
        
        //Print result.
        for (int i = 0; i < T.length; i++)
        {
            System.out.println(T[i] + B[Ti[i]]);
        }
    }
}