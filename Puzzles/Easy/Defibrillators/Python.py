#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Defibrillators               *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

import sys
import math

#Calculates the distance between two points on earth.
def distance(lonA, latA, lonB, latB):
    lonA = math.radians(lonA)
    lonB = math.radians(lonB)
    latA = math.radians(latA)
    latB = math.radians(latB)
    
    x = (lonB - lonA) * math.cos((latA + latB) / 2)
    y = latB - latA
    
    return math.sqrt(x * x + y * y) * 6371

#Read inputs.
lonA = float(input().replace(',', '.'))
latA = float(input().replace(',', '.'))
N = int(input())

#Define minimum.
min = sys.maxsize
minName = ''

for i in range(N):
    #Read defibrillator.
    DEFIB = input().split(';')
    
    lonB = float(DEFIB[4].replace(',', '.'))
    latB = float(DEFIB[5].replace(',', '.'))
    
    #Calculating distance for current defibrillator.
    d = distance(lonA, latA, lonB, latB)
    
    #Set nearest defibrillator.
    if d < min:
        min = d
        minName = DEFIB[1]

#Print nearest defibrillator.
print(minName);