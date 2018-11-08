/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Power of Thor - Episode 1    */
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
        string[] inputs = Console.ReadLine().Split(' ');
        
        int lightX = int.Parse(inputs[0]);
        int lightY = int.Parse(inputs[1]);
        int initialTX = int.Parse(inputs[2]);
        int initialTY = int.Parse(inputs[3]);

        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine());

            string move = "";

            if (lightY > initialTY)
            {
                initialTY++;
                move += "S";
            }
            else if (lightY < initialTY)
            {
                initialTY--;
                move += "N";
            }
            
            if (lightX > initialTX)
            {
                initialTX++;
                move += "E";
            }
            else if (lightX < initialTX)
            {
                initialTX--;
                move += "W";
            }
            
            Console.WriteLine(move);
        }
    }
}