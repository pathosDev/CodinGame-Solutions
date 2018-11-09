/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Gravity Tumbler              */
/* Difficulty: Easy                     */
/* Date solved: 09.11.2018              */
/*                                      */
/****************************************/

using System;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        string[] inputs = Console.ReadLine().Split(' ');
        
        int width = int.Parse(inputs[0]);
        int height = int.Parse(inputs[1]);
        
        int count = int.Parse(Console.ReadLine());
        
        //Create empty grid.
        int[][] grid = new int[width][];
        
        for (int x = 0; x < width; x++)
        {
            grid[x] = new int[height];
        }
        
        //Fill the grid. Replace blocks with 0 and 1.
        for (int y = 0; y < height; y++)
        {
            string raster = Console.ReadLine();
            
            for (int x = 0; x < width; x++)
            {
                grid[x][y] = (raster[x] == '.') ? 0 : 1;
            }
        }
        
        //Rotate grid <count> times and move blocks down after each rotation.
        for (int i = 0; i < count; i++)
        {
            grid = RotateGrid(grid);
            grid = ApplyPhysics(grid);
        }
        
        //Print grid.
        for (int y = 0; y < grid[0].Length; y++)
        {
            for (int x = 0; x < grid.Length; x++)
            {
                Console.Write(grid[x][y] == 0 ? '.' : '#');
            }
            
            Console.WriteLine();
        }
    }
    
    //Rotates the grid counterclockwise by 90°.
    private static int[][] RotateGrid(int[][] grid)
    {
        int[][] gridRotated = new int[grid[0].Length][];
        
        for (int x = 0; x < gridRotated.Length; x++)
        {
            gridRotated[x] = new int[grid.Length];
            
            for (int y = 0; y < gridRotated[0].Length; y++)
            {
                gridRotated[x][y] = grid[y][x];
            }
        }
        
        return gridRotated;
    }
    
    //Applies physics to let the blocks fall to the ground.
    private static int[][] ApplyPhysics(int[][] grid)
    {
        for (int x = 0; x < grid.Length; x++)
        {
            Array.Sort(grid[x]);
        }
        
        return grid;
    }
}