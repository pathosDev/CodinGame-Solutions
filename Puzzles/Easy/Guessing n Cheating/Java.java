/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Guessing n Cheating          */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        
        int R = Integer.parseInt(scanner.nextLine());
        
        int start = 1, end = 100;
        
        for (int i = 0; i < R; i++)
        {
            //Read conversations.
            String[] guess = scanner.nextLine().split(" ");
            
            int bob = Integer.parseInt(guess[0]);
            String alice = guess[1] + " " + guess[2];
            
            //Adjust range.
            if (alice.equals("too low"))
            {
                start = Math.max(start, bob + 1);
            }
            else if (alice.equals("too high"))
            {
                end = Math.min(end, bob - 1);
            }
        
            //Check if alice cheated.
            if (end < start || alice.equals("right on") && !(start <= bob && bob <= end))
            {
                System.out.println("Alice cheated in round " + (i + 1));
                System.exit(0);
            }
        }
        
        //Alice didn't cheat.
        System.out.println("No evidence of cheating");
    }
}