/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Bank Robbers                 */
/* Difficulty: Easy                     */
/* Date solved: 22.02.2019              */
/*                                      */
/****************************************/

import java.util.Arrays;
import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int R = Integer.parseInt(scanner.nextLine());
        int V = Integer.parseInt(scanner.nextLine());
        
        //List of times for each robber.
        int[] T = new int[R];
        
        for (int i = 0; i < V; i++)
        {
            String[] line = scanner.nextLine().split(" ");
            int C = Integer.parseInt(line[0]);
            int N = Integer.parseInt(line[1]);
            
            //Add vault time to the robber that has "nothing to do".
            T[0] += (int)(Math.pow(10, N) * Math.pow(5, C - N));
            Arrays.sort(T);
        }
        
        //Print time of the robber with the most time.
        System.out.println(T[R - 1]);
    }
}