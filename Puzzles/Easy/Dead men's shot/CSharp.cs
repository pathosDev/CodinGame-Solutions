/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Dead men's shot              */
/* Difficulty: Easy                     */
/* Date solved: 19.11.2018              */
/*                                      */
/****************************************/

using System;
using System.Drawing;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int N = int.Parse(Console.ReadLine());
        
        Point[] corners = new Point[N];
        
        for (int i = 0; i < N; i++)
        {
            string[] cornerXY = Console.ReadLine().Split(' ');
            int cornerX = int.Parse(cornerXY[0]);
            int cornerY = int.Parse(cornerXY[1]);
            
            corners[i] = new Point(cornerX, cornerY);
        }
        
        int M = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < M; i++)
        {
            string[] shotXY = Console.ReadLine().Split(' ');
            int shotX = int.Parse(shotXY[0]);
            int shotY = int.Parse(shotXY[1]);
            
            //Check if current shot lays in the polygon or not.
            if (PointInPolygon(corners, shotX, shotY))
            {
                Console.WriteLine("hit");
            }
            else
            {
                Console.WriteLine("miss");
            }
        }
    }
    
    //Checks if a point lays inside a polygon or not.
    private static bool PointInPolygon(Point[] polygon, double px, double py)
    {
        bool collision = false;
        
        for (int current = 0; current < polygon.Length; current++) 
        {
            Point vc = polygon[current];
            Point vn = polygon[(current + 1) % polygon.Length];
            
            bool btv = (vc.Y > py) != (vn.Y > py); //Check if between vc.y and vn.y.
            bool jct = px < (vn.X - vc.X) * (py - vc.Y) / (vn.Y - vc.Y) + vc.X; //Jordan Curve Theorem.
    
            if (btv && jct)
            {
                //Swap collision state.
                collision = !collision;
            }
        }
        
        return collision;
    }
}