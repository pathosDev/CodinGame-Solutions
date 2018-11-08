/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Onboarding                   */
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
            //Read inputs.
            string enemy1 = Console.ReadLine();
            int dist1 = int.Parse(Console.ReadLine());
            
            string enemy2 = Console.ReadLine();
            int dist2 = int.Parse(Console.ReadLine());

            //Output nearest enemy.
            Console.WriteLine(dist1 < dist2 ? enemy1 : enemy2);
        }
    }
}