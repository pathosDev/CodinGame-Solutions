#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Ghost Legs                   *#
#* Difficulty: Easy                     *#
#* Date solved: 22.02.2019              *#
#*                                      *#
#****************************************#

#Read diagram size.
W, H = map(int, input().split())

#Read top labels and create start indices.
T = input().split('  ')
Ti = list(range(len(T)))

#Read diagram lines.
for i in range(H - 2):
    line = input().split('|')
    
    #Search for horizontal lines.
    for j in range(len(line)):
        if line[j] == '--':
            
            #Check where the horizontal line is and change indices.
            for k in range(len(Ti)):
                if Ti[k] == j - 1:
                    Ti[k] += 1
                elif Ti[k] == j:
                    Ti[k] -= 1

#Read bottom labels.
B = input().split('  ')

#Print result.
for i in range(len(T)):
    print(T[i] + B[Ti[i]])