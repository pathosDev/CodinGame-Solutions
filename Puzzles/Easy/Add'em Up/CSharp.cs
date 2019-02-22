/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Add'em Up                    */
/* Difficulty: Easy                     */
/* Date solved: 22.02.2019              */
/*                                      */
/****************************************/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int N = int.Parse(Console.ReadLine());
        List<int> X = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        
        int cost = 0;
        
        while (X.Count() > 1)
        {
            X.Sort();
            
            //Smallest possible sum.
            int minSum = X.ElementAt(0) + X.ElementAt(1);
            
            //Add costs and reduce integer list.
            cost += minSum;

            X.RemoveAt(0);
            X.RemoveAt(0);
            X.Add(minSum);
        }
        
        //Print total cost.
        Console.WriteLine(cost);
    }
}