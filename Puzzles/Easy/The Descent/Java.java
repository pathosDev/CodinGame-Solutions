/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: The Descent                  */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

import java.util.Scanner;

class Player
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        
        //Game loop.
        while (true)
        {
            int max = 0;
            int maxIndex = -1;
            
            for (int i = 0; i < 8; i++)
            {
                //Read inputs.
                int mountainH = Integer.parseInt(scanner.nextLine());
                
                //Set highest mountain.
                if (mountainH > max)
                {
                    max = mountainH;
                    maxIndex = i;
                }
            }

            //Output highest mountain.
            System.out.println(maxIndex);
        }
    }
}