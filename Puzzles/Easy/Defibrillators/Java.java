/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Defibrillators               */
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

        double lonA = Double.parseDouble(scanner.nextLine().replace(",", "."));
        double latA = Double.parseDouble(scanner.nextLine().replace(",", "."));
        int N = Integer.parseInt(scanner.nextLine());
        
        //Define minimum.
        double min = Double.MAX_VALUE;
        String minName = "";
        
        for (int i = 0; i < N; i++)
        {
            //Read defibrillator.
            String[] DEFIB = scanner.nextLine().split(";");
            
            double lonB = Double.parseDouble(DEFIB[4].replace(",", "."));
            double latB = Double.parseDouble(DEFIB[5].replace(",", "."));
            
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
        System.out.println(minName);
    }
    
    //Calculates the distance between two points on earth.
    private static double Distance(double lonA, double latA, double lonB, double latB)
    {
        lonA = Math.toRadians(lonA);
        lonB = Math.toRadians(lonB);
        latA = Math.toRadians(latA);
        latB = Math.toRadians(latB);
        
        double x = (lonB - lonA) * Math.cos((latA + latB) / 2);
        double y = latB - latA;
        
        return Math.sqrt(x * x + y * y) * 6371;
    }
}