/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Lumen                        */
/* Difficulty: Easy                     */
/* Date solved: 22.02.2019              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int N = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
        
        int[,] grid = new int[N, N];
        
        //Read and create initial grid.
        for (int x = 0; x < N; x++)
        {
            string[] line = Console.ReadLine().Split();
            
            for (int y = 0; y < N; y++)
            {
                grid[x, y] = line[y] == "C" ? L : 0;
            }
        }
        
        //Add dimmed spots, so everything 0<x<L.
        for (int i = L - 1; i > 0; i--)
        {
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    //Find biggest surrounding cell.
                    int max_surrounding_cell = 0;
                    
                    for (int x_step = -1; x_step <= 1; x_step++)
                    {
                        for (int y_step = -1; y_step <= 1; y_step++)
                        {
                            if(0 <= x + x_step && x + x_step < N && 0 <= y + y_step && y + y_step < N)
                            {
                                max_surrounding_cell = Math.Max(max_surrounding_cell, grid[x + x_step, y + y_step]);
                            }
                        }
                    }
        
                    //Dimmed spot on (x, y) is the maximum in the surrounding cells minus one.
                    grid[x, y] = Math.Max(grid[x, y], max_surrounding_cell - 1);
                }
            }
        }
        
        //Count dark spots and print the result.
        int darkSpots = 0;
        
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < N; y++)
            {
                if (grid[x, y] == 0)
                {
                    darkSpots++;
                }
            }
        }
        
        Console.WriteLine(darkSpots);
    }
}