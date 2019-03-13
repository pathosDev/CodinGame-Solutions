/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Brick in the Wall            */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int X = Integer.parseInt(scanner.nextLine());
        int N = Integer.parseInt(scanner.nextLine());
        int[] M = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).sorted().toArray();
        
        double W = 0;
        
        //Calculate minimum work.
        for (int i = 0; i < N; i++)
        {
            int L = i / X;
            W += L * .65 * M[N-i-1];
        }
            
        //Print minimum work.
        System.out.println(String.format("%.3f", Math.round(W * 1000) / 1000.0));
    }
}