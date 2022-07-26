"""


3               

2           

1       _   _

0   _   _
    0   1   2   3
    
    
3                 _

2   

1       _   _

0   _
    0   1   2   3
    
    
 3       _

-1              _

-5          _

-9   _

    -4  -2  1   9


"""

class Solution:
    def isRectangleOverlap(self, rec1: List[int], rec2: List[int]) -> bool:
        #if either rectangle is a line, return False
        if rec1[0]==rec1[2] or rec1[1]==rec1[3] \
            or rec2[0]==rec2[2] or rec2[1]==rec2[3]:
                return False
            
        return not (rec1[2] <= rec2[0] or rec1[0] >= rec2[2] or rec1[1] >= rec2[3] or rec1[3] <= rec2[1])
        
        