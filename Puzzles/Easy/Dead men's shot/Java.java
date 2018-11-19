/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Dead men's shot              */
/* Difficulty: Easy                     */
/* Date solved: 19.11.2018              */
/*                                      */
/****************************************/

import java.awt.Point;
import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int N = Integer.parseInt(scanner.nextLine());
        
        Point[] corners = new Point[N];
        
        for (int i = 0; i < N; i++)
        {
            String[] cornerXY = scanner.nextLine().split(" ");
            int cornerX = Integer.parseInt(cornerXY[0]);
            int cornerY = Integer.parseInt(cornerXY[1]);
            
            corners[i] = new Point(cornerX, cornerY);
        }
        
        int M = Integer.parseInt(scanner.nextLine());
        
        for (int i = 0; i < M; i++)
        {
            String[] shotXY = scanner.nextLine().split(" ");
            int shotX = Integer.parseInt(shotXY[0]);
            int shotY = Integer.parseInt(shotXY[1]);
            
            //Check if current shot lays in the polygon or not.
            if (pointInPolygon(corners, shotX, shotY))
            {
                System.out.println("hit");
            }
            else
            {
                System.out.println("miss");
            }
        }
    }
    
    //Checks if a point lays inside a polygon or not.
    private static boolean pointInPolygon(Point[] polygon, double px, double py)
    {
        boolean collision = false;
        
        for (int current = 0; current < polygon.length; current++) 
        {
            Point vc = polygon[current];
            Point vn = polygon[(current + 1) % polygon.length];
            
            boolean btv = (vc.y > py) != (vn.y > py); //Check if between vc.y and vn.y.
            boolean jct = px < (vn.x - vc.x) * (py - vc.y) / (vn.y - vc.y) + vc.x; //Jordan Curve Theorem.
    
            if (btv && jct)
            {
                //Swap collision state.
                collision = !collision;
            }
        }
        
        return collision;
    }
}