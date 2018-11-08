#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Onboarding                   *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

#Game loop.
while True:
    #Read inputs.
    enemy1 = input()
    dist1 = int(input())
    
    enemy2 = input()
    dist2 = int(input())

    #Output nearest enemy.
    print(enemy1 if dist1 < dist2 else enemy2)