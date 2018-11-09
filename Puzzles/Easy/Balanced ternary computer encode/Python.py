#*********************************************#
#*                                           *#
#* CodinGame.com Solutions by pathosDev      *#
#*                                           *#
#* Puzzle: Balanced ternary computer: encode *#
#* Difficulty: Easy                          *#
#* Date solved: 09.11.2018                   *#
#*                                           *#
#*********************************************#

#Generates the ternary representation of an integer.
def convertToTernary(number):
    if number < 0:
        BT = convertToTernary(-number)
        return ''.join(['1' if c == 'T' else ('T' if c == '1' else '0') for c in BT])

    if number == 0:
        return ''

    if number % 3 == 2:
        return convertToTernary((number + 1) // 3) + 'T';
    else:
        return convertToTernary(number // 3) + str(number % 3)

#Read input.
N = int(input())

if N == 0:
    print('0')
else:
    #Get ternary representation.
    print(convertToTernary(N))