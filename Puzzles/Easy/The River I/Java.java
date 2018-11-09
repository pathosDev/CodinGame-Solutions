/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: The River I.                 */
/* Difficulty: Easy                     */
/* Date solved: 09.11.2018              */
/*                                      */
/****************************************/

import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        long r1 = Long.parseLong(scanner.nextLine());
        long r2 = Long.parseLong(scanner.nextLine());

        //Find meeting point.
        while (r1 != r2)
        {
            if (r1 < r2)
            {
                r1 = GetNextRiverNumber(r1);
            }
            else
            {
                r2 = GetNextRiverNumber(r2);
            }
        }

        //Output meeting point.
        System.out.println(r1);
    }
    
    //Calculates the a following river number (e.g 7 -> 14, 14 -> 19, etc).
    private static long GetNextRiverNumber(long riverNumber)
    {
        long nextRiverNumber = riverNumber;
        
        while (riverNumber > 0)
        {
            nextRiverNumber += riverNumber % 10;
            riverNumber -= riverNumber % 10;
            riverNumber /= 10;
        }
        
        return nextRiverNumber;
    }
}