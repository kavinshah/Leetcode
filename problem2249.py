"""

for each circle
for each x cordinate x-r to x+r:
    for each y cordinate y-r to y+r:
        # check if the point is not in result set.
        # check if the point is in the circle. use distance formula

return len(result)

"""

class Solution:
    def countLatticePoints(self, circles: List[List[int]]) -> int:
        points=set()
        for circle in circles:
            cx,cy=circle[0], circle[1]
            r=circle[2]
            for x in range(cx-r, cx+r+1):
                for y in range(cy-r, cy+r+1):
                    if (x,y) not in points:
                        if ((x-cx)**2+(y-cy)**2) <= r**2:
                            points.add((x,y))
                        
        return len(points)
    
    
# time: O(NR^2), Space: (1)