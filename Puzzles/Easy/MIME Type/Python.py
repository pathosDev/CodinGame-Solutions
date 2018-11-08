#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: MIME Type                    *#
#* Difficulty: Easy                     *#
#* Date solved: 08.11.2018              *#
#*                                      *#
#****************************************#

#Gets a file's extension without the dot itself. If the file has no extension it will return "".
def getFileExtension(file):
    #Find the beginning of an extension.
    extensionIndex = file.rfind('.')
    
    if extensionIndex < 0:
        #There is no extension.
        return ""
    
    return file[extensionIndex + 1:]

#Read inputs.
N = int(input())
Q = int(input())

#Creating hashmap: extension -> mimetype
mimeTypes = { }

for i in range(N):
    inputs = input().split()
    
    EXTENSION = inputs[0]
    MIMETYPE = inputs[1]
    
    #Fill the hashmap.
    mimeTypes[EXTENSION.lower()] = MIMETYPE

for i in range(Q):
    FILENAME = input()
    FILEEXT = getFileExtension(FILENAME).lower()
    
    #Check if the file's extension is known.
    if FILEEXT in mimeTypes:
        #Output the corresponding MIME type if file's extension is known.
        print(mimeTypes[FILEEXT])
    else:
        #Output "UNKNKOWN" if file's extension is not known.
        print("UNKNOWN")