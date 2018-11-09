/*********************************************/
/*                                           */
/* CodinGame.com Solutions by pathosDev      */
/*                                           */
/* Puzzle: Balanced ternary computer: encode */
/* Difficulty: Easy                          */
/* Date solved: 09.11.2018                   */
/*                                           */
/*********************************************/

import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read input.
        Scanner scanner = new Scanner(System.in);
        
        int N = scanner.nextInt();

        if (N == 0)
        {
            System.out.println("0");
        }
        else
        {
            //Get ternary representation.
            System.out.println(ConvertToTernary(N));
        }
    }

    //Generates the ternary representation of an integer.
    private static String ConvertToTernary(int number)
    {
        if (number < 0)
        {
            String BT = ConvertToTernary(-number);
            String BTFLIP = "";
            
            for (int i = 0; i < BT.length(); i++)
            {
                char c = BT.charAt(i);
                BTFLIP += (c == 'T') ? '1' : ((c == '1') ? 'T' : '0');
            }
            
            return BTFLIP;
        }

        if (number == 0)
        {
            return "";
        }

        if (number % 3 == 2)
        {
            return ConvertToTernary((number + 1) / 3) + "T";
        }
        else
        {
            return ConvertToTernary(number / 3) + (number % 3);
        }
    }
}