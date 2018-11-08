#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Chuck Norris                 *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

#Read input.
MESSAGE = input()

#Convert input message to binary representation.
BINARY = ''

for i in range(len(MESSAGE)):
    charInBinary = str(bin(ord(MESSAGE[i])))[2:]
    
    #Fill binary representation with zeroes to get 7 bit.
    charInBinary = charInBinary.zfill(7)
    
    BINARY += charInBinary

#Convert binary representation in "Chuck Norris Code".
lastChar = ' '
codedMessage = ''
encodedBits = [' 00 0', ' 0 0']

for i in range(len(BINARY)):
    if BINARY[i] != lastChar:
        lastChar = BINARY[i]
        codedMessage += encodedBits[ord(lastChar) - ord('0')]
    else:
        codedMessage += '0'

#Print encoded message.
print(codedMessage[1:])