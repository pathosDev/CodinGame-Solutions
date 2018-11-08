#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Mars Lander - Episode 1      *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

#Read inputs.
surfaceN = int(input())

for i in range(surfaceN):
    input()

#Game loop.
while True:
    vSpeed = int(input().split()[3])

    #Keep vertical speed at -40 m/s.
    if (vSpeed <= -40):
        print('0 4')
    else:
        print('0 0')