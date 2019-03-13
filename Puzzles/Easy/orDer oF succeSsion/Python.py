#****************************************#
#*                                      *#
#* CodinGame.com Solutions by pathosDev *#
#*                                      *#
#* Puzzle: orDer oF succeSsion          *#
#* Difficulty: Easy                     *#
#* Date solved: 05.03.2019              *#
#*                                      *#
#****************************************#

#Represents a node in the tree.
class Royal:
    #Constructor.
    def __init__(self, name, parent, birth, death, religion, gender):
        self.name = name
        self.parent = parent
        self.birth = int(birth)
        self.death = int(death) if death != '-' else None
        self.religion = religion
        self.isfemale = gender == 'F'
        self.children = []
    
    #Adds a child to the node or its subnodes.
    def addChild(self, child):
        if child.parent == self.name:
            self.children += [child]
        else:
            for royal in self.children:
                royal.addChild(child)
    
    #Traverse the node and its subnodes with the rules given in the statement.
    def traverse(self):
        succession = []
        
        #Exclude dead and catholic royals.
        if not self.death and self.religion == 'Anglican':
            succession += [self]
            
        #Ordering rules.
        sortedChildren = sorted(self.children, key=lambda child: (child.isfemale, child.birth))
        
        #Traverse subnodes.
        for child in sortedChildren:
            succession += child.traverse()
            
        return succession

#Read inputs().
n = int(input())
royalLeader = Royal(*input().split())
    
for i in range(n - 1):
    royal = Royal(*input().split())
    royalLeader.addChild(royal)

#Traverse the complete tree.
for royal in royalLeader.traverse():
    print(royal.name)