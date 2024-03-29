public class Solution {
    char[][] grid;
    int count;
    public int NumIslands(char[][] grid) {
        count=0;
        this.grid = grid;
        
        for(int i=0; i<grid.Length; i++)
        {
            for(int j=0; j<grid[0].Length; j++)
            {
                if(grid[i][j]=='1')
                {
                    count++;
                    Dfs(i,j);
                }
            }
        }
        
        return count;
    }
    
    public void Dfs(int row, int col)
    {
        
        grid[row][col]='2';
        
        if((row+1)<grid.Length && (col)<grid[0].Length && grid[row+1][col]=='1')
            Dfs(row+1, col);
        
        if((row)<grid.Length && (col+1)<grid[0].Length && grid[row][col+1]=='1')
            Dfs(row, col+1);
        
        if((row-1)>=0 && (col)<grid[0].Length && grid[row-1][col]=='1')
            Dfs(row-1, col);
        
        if((row)<grid.Length && (col-1)>=0 && grid[row][col-1]=='1')
            Dfs(row, col-1);
    }
}

//time: O(MN)
//space: O(MN)