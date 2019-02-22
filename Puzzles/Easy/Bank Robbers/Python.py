#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Bank Robbers                 *#
#* Difficulty: Easy                     *#
#* Date solved: 22.02.2019              *#
#*                                      *#
#****************************************#

#Read inputs.
R = int(input())
V = int(input())

#List of times for each robber.
T = [0] * R

for i in range(V):
    C, N = map(int, input().split())
    
    #Add vault time to the robber that has "nothing to do".
    T[0] += (10 ** N) * (5 ** (C - N))
    T = sorted(T)

#Print time of the robber with the most time.
print(T[-1])