/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Mars Lander - Episode 1      */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int surfaceN = int.Parse(Console.ReadLine());

        for (int i = 0; i < surfaceN; i++)
        {
            Console.ReadLine();
        }
        
        //Game loop.
        while (true)
        {
            int vSpeed = int.Parse(Console.ReadLine().Split(' ')[3]);

            //Keep vertical speed at -40 m/s.
            if (vSpeed <= -40)
            {
                Console.WriteLine("0 4");
            }
            else
            {
                Console.WriteLine("0 0");
            }
         }
    }
}