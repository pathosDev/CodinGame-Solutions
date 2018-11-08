/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Defibrillators               */
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
        double lonA = double.Parse(Console.ReadLine().Replace(",", "."));
        double latA = double.Parse(Console.ReadLine().Replace(",", "."));
        int N = int.Parse(Console.ReadLine());
        
        //Define minimum.
        double min = double.MaxValue;
        string minName = string.Empty;
        
        for (int i = 0; i < N; i++)
        {
            //Read defibrillator.
            string[] DEFIB = Console.ReadLine().Split(';');
            
            double lonB = double.Parse(DEFIB[4].Replace(",", "."));
            double latB = double.Parse(DEFIB[5].Replace(",", "."));
            
            //Calculating distance for current defibrillator.
            double d = Distance(lonA, latA, lonB, latB);
            
            //Set nearest defibrillator.
            if (d < min)
            {
                min = d;
                minName = DEFIB[1];
            }
        }

        //Print nearest defibrillator.
        Console.WriteLine(minName);
    }
    
    //Calculates the distance between two points on earth.
    private static double Distance(double lonA, double latA, double lonB, double latB)
    {
        lonA = DegToRad(lonA);
        lonB = DegToRad(lonB);
        latA = DegToRad(latA);
        latB = DegToRad(latB);
        
        double x = (lonB - lonA) * Math.Cos((latA + latB) / 2);
        double y = latB - latA;
        
        return Math.Sqrt(x * x + y * y) * 6371;
    }
    
    //Converts degrees to radians.
    private static double DegToRad(double angle)
    {
        return angle * (Math.PI / 180);   
    }
}