public class Solution {
    int maxRow, maxCol;
    char[][] grid;
    public int NumIslands(char[][] grid) {
        int count = 0;
        maxRow=grid.Length;
        maxCol=grid[0].Length;
        this.grid=grid;
        for(int i =0; i<maxRow;i++)
        {
            for(int j=0; j<maxCol; j++)
            {
                if(grid[i][j] == '1')
                {
                    count+=1;
                    Dfs(i,j);
                }
            }
        }
        return count;
    }
    
    public void Dfs(int row, int col)
    {
        grid[row][col]='0';
        
        if((row+1)<maxRow && grid[row+1][col]=='1')
        {
            Dfs(row+1, col);
        }
        if((row-1)>=0 && grid[row-1][col]=='1')
        {
            Dfs(row-1, col);
        }
        if((col+1)<maxCol && grid[row][col+1]=='1')
        {
            Dfs(row, col+1);
        }
        if((col-1)>=0 && grid[row][col-1]=='1')
        {
            Dfs(row, col-1);
        }
        
    }
}