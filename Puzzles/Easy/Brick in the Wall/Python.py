#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Brick in the Wall            *#
#* Difficulty: Easy                     *#
#* Date solved: 05.03.2019              *#
#*                                      *#
#****************************************#

#Read inputs.
X = int(input())
N = int(input())
M = sorted(map(int, input().split()), reverse=True)

W = 0

#Calculate minimum work.
for i in range(N):
    L = i // X
    W += L * .65 * M[i]
    
#Print minimum work.
print('%.3f' % round(W, 3))