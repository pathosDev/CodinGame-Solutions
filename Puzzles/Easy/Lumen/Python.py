#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Lumen                        *#
#* Difficulty: Easy                     *#
#* Date solved: 22.02.2019              *#
#*                                      *#
#****************************************#

#Read inputs.
N = int(input())
L = int(input())

grid = []

#Read and create initial grid.
for x in range(N):
    grid += [[L if c == 'C' else 0 for c in input().split()]]

#Add dimmed spots, so everything 0<x<L.
for i in range(L - 1, 0, -1):
    for x in range(N):
        for y in range(N):
            
            #Find biggest surrounding cell.
            max_surrounding_cell = 0
            
            for x_step in range(-1, 2):
                for y_step in range(-1, 2):
                    if 0 <= x + x_step < N and 0 <= y + y_step < N:
                        max_surrounding_cell = max(max_surrounding_cell, grid[x + x_step][y + y_step])

            #Dimmed spot on (x, y) is the maximum in the surrounding cells minus one.
            grid[x][y] = max(grid[x][y], max_surrounding_cell - 1)

#Count dark spots and print the result.
print(sum(x.count(0) for x in grid))