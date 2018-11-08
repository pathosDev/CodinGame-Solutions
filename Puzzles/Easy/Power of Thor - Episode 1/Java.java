/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Power of Thor - Episode 1    */
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
        
        String[] inputs = scanner.nextLine().split(" ");
        
        int lightX = Integer.parseInt(inputs[0]);
        int lightY = Integer.parseInt(inputs[1]);
        int initialTX = Integer.parseInt(inputs[2]);
        int initialTY = Integer.parseInt(inputs[3]);

        while (true)
        {
            int remainingTurns = Integer.parseInt(scanner.nextLine());

            String move = "";

            //Vertical movement.
            if (lightY > initialTY)
            {
                initialTY++;
                move += "S";
            }
            else if (lightY < initialTY)
            {
                initialTY--;
                move += "N";
            }
            
            //Horizontal movement.
            if (lightX > initialTX)
            {
                initialTX++;
                move += "E";
            }
            else if (lightX < initialTX)
            {
                initialTX--;
                move += "W";
            }
            
            //Output next move.
            System.out.println(move);
        }
    }
}