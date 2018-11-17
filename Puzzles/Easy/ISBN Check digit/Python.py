#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: ISBN Check digit             *#
#* Difficulty: Easy                     *#
#* Date solved: 17.11.2018              *#
#*                                      *#
#****************************************#

import re

#Checks if a given ISBN-10 is valid or not.
def isValidISBN10(isbn):
    #Check allowed characters.
    if not re.fullmatch(r'^\d{9}(\d|X)$', isbn):
        return False

    #Calculating checksum.
    checkSum = 0

    for i in range(len(isbn) - 1):
        checkSum += (ord(isbn[i]) - ord('0')) * (10 - i)

    checkDigit = (11 - checkSum) % 11
    givenCheckDigit = 10 if isbn[-1] == 'X' else ord(isbn[-1]) - ord('0')

    #Comparing checkdigits.
    return givenCheckDigit == checkDigit

#Checks if a given ISBN-13 is valid or not.
def isValidISBN13(isbn):
    #Check allowed characters.
    if not re.fullmatch(r'^\d{13}$', isbn):
        return False

    #Calculating checksum.
    checkSum = 0

    for i in range(len(isbn) - 1):
        checkSum += (ord(isbn[i]) - ord('0')) * (1 if i % 2 == 0 else 3)

    checkDigit = (10 - checkSum) % 10
    givenCheckDigit = 10 if isbn[-1] == 'X' else ord(isbn[-1]) - ord('0')

    #Comparing checkdigits.
    return givenCheckDigit == checkDigit
    
#Checks if a given ISBN-10 or ISBN-13 is valid or not.
def isValidISBN(isbn):
    if len(isbn) == 10: #Check if isbn is ISBN-10.
        return isValidISBN10(isbn)
    elif len(isbn) == 13: #Check if isbn is ISBN-13.
        return isValidISBN13(isbn)
    return False

#Read inputs.
N = int(input())

#Store invalid ISBNs.
invalidISBN = []

for i in range(N):
    ISBN = input()
    #Check if current ISBN is invalid.
    if not isValidISBN(ISBN):
        invalidISBN.append(ISBN)

#Output invalid ISBN's.
print(str(len(invalidISBN)) + ' invalid:')
print('\n'.join(invalidISBN))