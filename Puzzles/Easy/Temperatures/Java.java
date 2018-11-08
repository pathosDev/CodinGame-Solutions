/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Temperatures                 */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int N = Integer.parseInt(scanner.nextLine());
        String[] inputs = scanner.nextLine().split(" ");
        
        //If there are no temperatures provided, output 0.
        if (N <= 0)
        {
            System.out.println(0);
            return;
        }
        
        int closestToZero = Integer.MAX_VALUE;
        
        for (int i = 0; i < N; i++)
        {
            int T = Integer.parseInt(inputs[i]);
            
            //Find the closest to zero.
            if (Math.abs(T) < Math.abs(closestToZero))
            {
                closestToZero = T;
            }
            //Find the positive number that is closest to zero instead of the negative number (see 5 and -5).
            else if (Math.abs(T) == Math.abs(closestToZero))
            {
                closestToZero = Math.max(closestToZero, T);
            }
        }

        //Print output.
        System.out.println(closestToZero);
    }
}