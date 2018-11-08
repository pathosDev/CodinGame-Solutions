#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: ASCII Art                    *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

#Read inputs.
L = int(input())
H = int(input())
T = input().upper()

#Define index for non alphabetic chars.
unknownCharIndex = ord('Z') - ord('A') + 1

for i in range(H):
    asciiLine = input()
    
    for j in range(len(T)):
        #Get ASCII index of current char.
        charIndex = ord(T[j]) - ord('A')
        letterIndex = charIndex if T[j].isalpha() else unknownCharIndex
        
        #Get ASCII line of current char.
        asciiPart = asciiLine[letterIndex * L : (letterIndex + 1) * L]
        
        #Print ASCII line part.
        print(asciiPart, end='')
    
    print()