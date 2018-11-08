/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Horse-racing Duals           */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

import java.util.Arrays;
import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read the inputs.
        Scanner scanner = new Scanner(System.in);
        int N = scanner.nextInt();
        
        int[] P = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            P[i] = scanner.nextInt();
        }

        //Sort horse strengths.
        Arrays.sort(P);
        
        //Find D.
        int D = Integer.MAX_VALUE;
        
        for (int i = 1; i < N; i++)
        {
            D = Math.min(D, P[i] - P[i - 1]);
        }
        
        //Print D.
        System.out.println(D);
    }
}