#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: The River I.                 *#
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

#Read inputs.
r1 = int(input())
r2 = int(input())

#Find meeting point.
while r1 != r2:
    if r1 < r2:
        r1 = getNextRiverNumber(r1)
    else:
        r2 = getNextRiverNumber(r2)

#Output meeting point.
print(round(r1))