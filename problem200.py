"""

1. traverse over the input matrix for every cell = 1 and not visited.
2. while traversing - use DFS for every neighbour which is not visited and = 1
3. use a stack for performing DFS since the range can give stack overflow.
4. count the number of times 2 and 3 are performed. The result is number of island

"""
from collections import deque
class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        count = 0
        maxR, maxC = len(grid), len(grid[0])
        directions = [[0,1],[0,-1], [1,0], [-1,0]]
        queue = deque()
        for row in range(len(grid)):
            for col in range(len(grid[0])):
                if grid[row][col]=="1":
                    count += 1
                    grid[row][col]="2"
                    queue.append((row, col))
                    while(queue):
                        currRow, currCol = queue.popleft()
                        for d in directions:
                            newRow=currRow+d[0]
                            newCol=currCol+d[1]
                            if 0<=newRow<maxR and 0<=newCol<maxC and grid[newRow][newCol]=="1":
                                grid[newRow][newCol]="2"
                                queue.append((newRow, newCol))
                        
        return count
        
            