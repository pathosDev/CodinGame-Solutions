#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Guessing n Cheating          *#
#* Difficulty: Easy                     *#
#* Date solved: 05.03.2019              *#
#*                                      *#
#****************************************#

R = int(input())

start, end = 1, 100

for i in range(R):
    #Read conversations.
    guess = input().split()
    
    bob = int(guess[0])
    alice = guess[1] + ' ' + guess[2]
    
    #Adjust range.
    if alice == 'too low':
        start = max(start, bob + 1)
    elif alice == 'too high':
        end = min(end, bob - 1)

    #Check if alice cheated.
    if end < start or alice == 'right on' and not start <= bob <= end:
        print('Alice cheated in round %d' % (i + 1))
        exit()

#Alice didn't cheat.
print('No evidence of cheating')