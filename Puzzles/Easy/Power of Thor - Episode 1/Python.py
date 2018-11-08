#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Power of Thor - Episode 1    *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

#Read inputs.
inputs = input().split(' ')

lightX = int(inputs[0])
lightY = int(inputs[1])
initialTX = int(inputs[2])
initialTY = int(inputs[3])

while True:
    remainingTurns = int(input())

    move = ''

    #Vertical movement.
    if lightY > initialTY:
        initialTY += 1
        move += 'S'
    elif lightY < initialTY:
        initialTY -= 1
        move += 'N'
    
    #Horizontal movement.
    if lightX > initialTX:
        initialTX += 1
        move += 'E'
    elif lightX < initialTX:
        initialTX -= 1
        move += 'W'
    
    #Output next move.
    print(move)