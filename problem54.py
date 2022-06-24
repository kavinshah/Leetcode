"""

1   2   3   4   21
5   6   7   8   22
9   10  11  12  23
13  14  15  16  24
25  26  27  28  29


1. lowC, highC=0,4
   lowR, highR = 0,4
2. while lowC<=highC and lowR<=highR:
    if 

"""
class Solution:
    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
        directions = [(0,1),(1,0),(0,-1),(-1,0)]
        lowR, highR = 0, len(matrix)-1
        lowC, highC = 0, len(matrix[0])-1
        result = []
        curr_direction = directions[0]
        currR, currC=0, -1
        i=0
        while lowC<=highC and lowR<=highR:
            if curr_direction == (0,1):
                currC+=1
            elif curr_direction == (1,0):
                currR+=1
            elif curr_direction == (0,-1):
                currC-=1
            else:
                currR-=1
            if lowR>currR or currR>highR or lowC>currC or currC>highC:
                #change direction
                if curr_direction == (0,1):
                    currR=lowR
                    currC=highC
                    lowR+=1
                elif curr_direction == (1,0):
                    currR=highR
                    currC=highC
                    highC-=1
                elif curr_direction == (0,-1):
                    currR=highR
                    currC=lowC
                    highR-=1
                else: #curr_direction == (-1,0):
                    currR=lowR
                    currC=lowC
                    lowC+=1
                i+=1
                curr_direction=directions[i%4]
                continue
            
            #print(currR, currC, curr_direction)
            result.append(matrix[currR][currC])
                
        return result