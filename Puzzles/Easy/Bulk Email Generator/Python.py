#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Bulk Email Generator         *#
#* Difficulty: Easy                     *#
#* Date solved: 12.11.2018              *#
#*                                      *#
#****************************************#

import re

#Read inputs.
N = int(input())

emailTemplateLines = [''] * N

for i in range(N):
    emailTemplateLines[i] = input()

emailTemplate = '\n'.join(emailTemplateLines)
choicesCounter = -1

#Replacing choices.
def choiceReplace(match):
    global choicesCounter
    choicesCounter += 1
    choices = match.group()[1:-1].split('|')
    return choices[choicesCounter % len(choices)]

email = re.sub('\([^)]*\)', choiceReplace, emailTemplate)

#Output email.
print(email)