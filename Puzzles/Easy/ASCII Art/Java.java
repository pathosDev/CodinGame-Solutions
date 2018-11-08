/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: ASCII Art                    */
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
        
        int L = Integer.parseInt(scanner.nextLine());
        int H = Integer.parseInt(scanner.nextLine());
        String T = scanner.nextLine().toUpperCase();
        
        //Define index for non alphabetic chars.
        final int unknownCharIndex = 'Z' - 'A' + 1;
        
        for (int i = 0; i < H; i++)
        {
            String asciiLine = scanner.nextLine();
            
            for (int j = 0; j < T.length(); j++)
            {
                //Get ASCII index of current char.
                int charIndex = T.charAt(j) - 'A';
                int letterIndex = Character.isLetter(T.charAt(j)) ? charIndex : unknownCharIndex;
                
                //Get ASCII line of current char.
                String asciiPart = asciiLine.substring(letterIndex * L, (letterIndex + 1) * L);
                
                //Print ASCII line part.
                System.out.print(asciiPart);
            }
            
            System.out.println();
        }
    }
}