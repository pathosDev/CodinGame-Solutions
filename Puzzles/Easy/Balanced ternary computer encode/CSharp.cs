/*********************************************/
/*                                           */
/* CodinGame.com Solutions by pathosDev      */
/*                                           */
/* Puzzle: Balanced ternary computer: encode */
/* Difficulty: Easy                          */
/* Date solved: 09.11.2018                   */
/*                                           */
/*********************************************/

using System;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        //Read input.
        int N = int.Parse(Console.ReadLine());

        if (N == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            //Get ternary representation.
            Console.WriteLine(ConvertToTernary(N));
        }
    }

    //Generates the ternary representation of an integer.
    private static string ConvertToTernary(int number)
    {
        if (number < 0)
        {
            string BT = ConvertToTernary(-number);
            return string.Concat(BT.Select(c => (c == 'T') ? '1' : ((c == '1') ? 'T' : '0')));
        }

        if (number == 0)
        {
            return string.Empty;
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