#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: The River II.                *#
#* Difficulty: Easy                     *#
#* Date solved: 09.11.2018              *#
#*                                      *#
#****************************************#

#Calculates the a following river number (e.g 7 -> 14, 14 -> 19, etc).
def getNextRiverNumber(riverNumber):
    nextRiverNumber = riverNumber
    
    while riverNumber > 0:
        nextRiverNumber += riverNumber % 10
        riverNumber -= riverNumber % 10
        riverNumber /= 10
    
    return nextRiverNumber

#Read input.
r1 = int(input())

riversMeetR1 = False

#Find rivers that meet r1.
for i in range(r1 - 1, 0, -1):
    riversMeetR1 = (getNextRiverNumber(i) == r1)
    if riversMeetR1:
        break

#Output if other rivers meet r1.
print("YES" if riversMeetR1 else "NO")