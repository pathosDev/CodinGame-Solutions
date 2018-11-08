/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: The Descent                  */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Game loop.
        while (true)
        {
            int max = 0;
            int maxIndex = -1;
            
            for (int i = 0; i < 8; i++)
            {
                //Read inputs.
                int mountainH = int.Parse(Console.ReadLine());
                
                //Set highest mountain.
                if (mountainH > max)
                {
                    max = mountainH;
                    maxIndex = i;
                }
            }

            //Output highest mountain.
            Console.WriteLine(maxIndex);
        }
    }
}