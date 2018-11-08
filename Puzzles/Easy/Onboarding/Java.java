/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Onboarding                   */
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
            //Read inputs.
            String enemy1 = scanner.nextLine();
            int dist1 = Integer.parseInt(scanner.nextLine());
            
            String enemy2 = scanner.nextLine();
            int dist2 = Integer.parseInt(scanner.nextLine());

            //Output nearest enemy.
            System.out.println(dist1 < dist2 ? enemy1 : enemy2);
        }
    }
}