/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Mars Lander - Episode 1      */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

import java.util.Scanner;

class Player
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int surfaceN = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < surfaceN; i++)
        {
            scanner.nextLine();
        }
        
        //Game loop.
        while (true)
        {
            int vSpeed = Integer.parseInt(scanner.nextLine().split(" ")[3]);

            //Keep vertical speed at -40 m/s.
            if (vSpeed <= -40)
            {
                System.out.println("0 4");
            }
            else
            {
                System.out.println("0 0");
            }
         }
    }
}