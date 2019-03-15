#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: How time flies               *#
#* Difficulty: Easy                     *#
#* Date solved: 05.03.2019              *#
#*                                      *#
#****************************************#

from datetime import datetime

#Read dates.
begin = datetime.strptime(input(), "%d.%m.%Y")
end = datetime.strptime(input(), "%d.%m.%Y")

#Calculate result.
days = (end - begin).days
months = (datetime.min + (end - begin)).month - 1
years = days // 365

#Print result.
if years > 0:
    print('%d year%s, ' % (years, 's' if years > 1 else ''), end='')
    
if months > 0:
    print('%d month%s, ' % (months, 's' if months > 1 else ''), end='')

print('total %d days' % days)