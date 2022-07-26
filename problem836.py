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
        if rec1[0]<=rec2[0]:
            small_x1 = rec1[0]
            small_y1 = rec1[1]
            small_x2 = rec1[2]
            small_y2 = rec1[3]
            large_x1 = rec2[0]
            large_y1 = rec2[1]
            large_x2 = rec2[2]
            large_y2 = rec2[3]
        else:
            small_x1 = rec2[0]
            small_y1 = rec2[1]
            small_x2 = rec2[2]
            small_y2 = rec2[3]
            large_x1 = rec1[0]
            large_y1 = rec1[1]
            large_x2 = rec1[2]
            large_y2 = rec1[3]
            
        # the smaller rectange is to the left or larger rectange.
        #check if the large rectangle is above or below or right of smaller rectangle.
        if small_x1 < large_x1:
            if large_y1 >= small_y2 or large_y2 <= small_y1 or large_x1 >= small_x2:
                return False
            return True
            
        # if they are on small x-axis, then only check if larger rectange is above the smaller rectange since it cannot be below the smaller rectangle.
        if small_x1 == large_x1:
            if large_y1>= small_y2:
                return False
            return True
            