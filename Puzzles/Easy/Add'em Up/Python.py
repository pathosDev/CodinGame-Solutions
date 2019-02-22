#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Add'em Up                    *#
#* Difficulty: Easy                     *#
#* Date solved: 22.02.2019              *#
#*                                      *#
#****************************************#

#Read inputs.
N = int(input())
X = sorted(map(int, input().split()))

cost = 0

while len(X) > 1:
    #Smallest possible sum.
    minSum = X[0] + X[1]
    
    #Add costs and reduce integer list.
    cost += minSum
    X = sorted([minSum] + X[2:])

#Print total cost.
print(cost)