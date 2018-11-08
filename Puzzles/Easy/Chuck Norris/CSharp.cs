/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Chuck Norris                 */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

using System;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        //Read input.
        string MESSAGE = Console.ReadLine();
        
        //Convert input message to binary representation.
        string BINARY = string.Empty;
        
        for (int i = 0; i < MESSAGE.Length; i++)
        {
            string charInBinary = Convert.ToString((int)MESSAGE[i], 2);
            
            //Fill binary representation with zeroes to get 7 bit.
            charInBinary = charInBinary.PadLeft(7, '0');
            
            BINARY += charInBinary;
        }

        //Convert binary representation in "Chuck Norris Code".
        char lastChar = ' ';
        string codedMessage = "";
        string[] encodedBits = new string[] { " 00 0", " 0 0" };
        
        for (int i = 0; i < BINARY.Length; i++)
        {
            if (BINARY[i] != lastChar)
            {
                lastChar = BINARY[i];
                codedMessage += encodedBits[lastChar - '0'];
            }
            else
            {
                codedMessage += "0";
            }
        }
        
        //Print encoded message.
        Console.WriteLine(codedMessage.Substring(1));
    }
}