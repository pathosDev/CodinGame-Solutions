/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Add'em Up                    */
/* Difficulty: Easy                     */
/* Date solved: 22.02.2019              */
/*                                      */
/****************************************/

import java.util.*;
import java.util.stream.*;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int N = Integer.parseInt(scanner.nextLine());
        
        ArrayList<Integer> X = new ArrayList<Integer>();
        
        for (String s : scanner.nextLine().split(" "))
        {
            X.add(Integer.parseInt(s));
        }
        
        int cost = 0;
        
        while (X.size() > 1)
        {
            Collections.sort(X);
            
            //Smallest possible sum.
            int minSum = X.get(0) + X.get(1);
            
            //Add costs and reduce integer list.
            cost += minSum;

            X.remove(0);
            X.remove(0);
            X.add(minSum);
        }
        
        //Print total cost.
        System.out.println(cost);
    }
}