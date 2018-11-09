#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Gravity Tumbler              *#
#* Difficulty: Easy                     *#
#* Date solved: 09.11.2018              *#
#*                                      *#
#****************************************#

#Rotates the grid counterclockwise by 90°.
def rotateGrid(grid):
    gridRotated = [[0 for x in range(len(grid))] for y in range(len(grid[0]))]
    for x in range(len(gridRotated)):
        for y in range(len(gridRotated[0])):
            gridRotated[x][y] = grid[y][x]
    return gridRotated

#Applies physics to let the blocks fall to the ground.
def applyPhysics(grid):
    for x in range(len(grid)):
        grid[x] = sorted(grid[x])
    return grid

#Read inputs.
inputs = input().split()

width = int(inputs[0])
height = int(inputs[1])

count = int(input())

#Create empty grid.
grid = [[0 for x in range(height)] for y in range(width)] 

#Fill the grid. Replace blocks with 0 and 1.
for y in range(height):
    raster = input()
    for x in range(width):
        grid[x][y] = 0 if raster[x] == '.' else 1

#Rotate grid <count> times and move blocks down after each rotation.
for i in range(count):
    grid = rotateGrid(grid)
    grid = applyPhysics(grid)

#Print grid.
for y in range(len(grid[0])):
    for x in range(len(grid)):
        print('.' if grid[x][y] == 0 else '#', end='')
    print()