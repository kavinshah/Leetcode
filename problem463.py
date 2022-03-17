class Solution:
    def islandPerimeter(self, grid: List[List[int]]) -> int:
        perimeter=0
        row=len(grid)
        col=len(grid[0])
        for i in range(row):
            for j in range(col):
                if grid[i][j]==1:
                    #check for cells on all 4 sides
                    # if the cell is bound of bounds or water then add to perimeter
                    if (i-1)<0 or grid[i-1][j]==0:
                        perimeter+=1
                    
                    if (j-1)<0 or grid[i][j-1]==0:
                        perimeter+=1
                    
                    if (i+1)>=row or grid[i+1][j]==0:
                        perimeter+=1
                        
                    if (j+1)>=col or grid[i][j+1]==0:
                        perimeter+=1
                #print(i,j,perimeter)
                        
        return perimeter
        
#Time: O(MN)
#space: O(1)