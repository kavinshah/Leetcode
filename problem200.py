class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:

        count=0
        maxR=len(grid)
        maxC=len(grid[0])
        def countIslands(r, c):
            nonlocal grid, count, maxR, maxC
            if r<0 or r>=maxR or c<0 or c>=maxC or grid[r][c]!="1":
                return
            grid[r][c]="-1"
            countIslands(r-1,c)
            countIslands(r+1,c)
            countIslands(r,c+1)
            countIslands(r,c-1)

        for i in range(maxR):
            for j in range(maxC):
                #print(i,j, grid[i][j])
                if grid[i][j]=="1":
                    count+=1
                    countIslands(i,j)

        return count


#time: O(MN)
#Space: O(MN)