#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: The Descent                  *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

import sys

#Game loop.
while True:
    max = 0
    maxIndex = -1
    
    for i in range(8):
        #Read inputs.
        mountainH = int(input())
        
        #Set highest mountain.
        if mountainH > max:
            max = mountainH
            maxIndex = i

    #Output highest mountain.
    print(maxIndex)