/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: ASCII Art                    */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine().ToUpper();
        
        //Define index for non alphabetic chars.
        const int unknownCharIndex = 'Z' - 'A' + 1;
        
        for (int i = 0; i < H; i++)
        {
            string asciiLine = Console.ReadLine();
            
            for (int j = 0; j < T.Length; j++)
            {
                //Get ASCII index of current char.
                int charIndex = T[j] - 'A';
                int letterIndex = char.IsLetter(T[j]) ? charIndex : unknownCharIndex;
                
                //Get ASCII line of current char.
                string asciiPart = asciiLine.Substring(letterIndex * L, L);
                
                //Print ASCII line part.
                Console.Write(asciiPart);
            }
            
            Console.WriteLine();
        }
    }
}