#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Dead men's shot              *#
#* Difficulty: Easy                     *#
#* Date solved: 19.11.2018              *#
#*                                      *#
#****************************************#

def divisionEx(a, b):
    if b != 0:
        return a / b
    else:
        return float('Inf')

#Checks if a point lays inside a polygon or not.
def pointInPolygon(polygon, px, py):
    collision = False
    
    for current in range(len(polygon)):
        vc = polygon[current]
        vn = polygon[(current + 1) % len(polygon)]
        
        btv = (vc[1] > py) != (vn[1] > py) #Check if between vc.y and vn.y.
        jct = px < divisionEx((vn[0] - vc[0]) * (py - vc[1]), (vn[1] - vc[1])) + vc[0] #Jordan Curve Theorem.

        if btv and jct:
            #Swap collision state.
            collision = not collision
    
    return collision

#Read inputs.
N = int(input())

corners = []

for i in range(N):
    cornerX, cornerY = map(int, input().split())
    corners.append((cornerX, cornerY))

M = int(input())

for i in range(M):
    shotX, shotY = map(int, input().split())
    
    #Check if current shot lays in the polygon or not.
    if pointInPolygon(corners, shotX, shotY):
        print('hit')
    else:
        print('miss')