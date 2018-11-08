#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Horse-racing Duals           *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

import sys

#Read the inputs.
N = int(input())

P = [0] * N

for i in range(N):
    P[i] = int(input())

#Sort horse strengths.
P.sort()

#Find D.
D = sys.maxsize

for i in range(1, N):
    D = min(D, P[i] - P[i - 1])

#Print D.
print(D)