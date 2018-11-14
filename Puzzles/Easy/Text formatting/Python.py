#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: Text formatting              *#
#* Difficulty: Easy                     *#
#* Date solved: 13.11.2018              *#
#*                                      *#
#****************************************#

import re

#Read input.
text = input().lower().strip()

#Remove excessive spaces.
#text = Regex.Replace(text, @"\s{2,}", " ");
text = re.sub(r'\s{2,}', ' ', text)

#Remove spaces before and after punctuations.
text = re.sub(r'\s?[^\s\w\d]\s?', lambda match: match.group().strip(), text)

#Remove repeated punctuations.
text = re.sub(r'[^\s\w\d]+', lambda match: match.group().strip()[0], text)

#Converts any string to pascal case.
def stringToPascalCase(s):
    if not s:
        return ''
    chars = list(s)
    chars[0] = chars[0].upper()
    return ''.join(chars)

#First letter uppercase.
text = '.'.join(stringToPascalCase(s) for s in text.split('.'))

#Add spaces after punctuations.
text = re.sub(r'[^\s\w\d]', lambda match: match.group() + ' ', text)

#Output formatted text.
print(text.strip())