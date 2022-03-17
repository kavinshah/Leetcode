public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int perimeter=0;
        int rows=grid.Length, cols = grid[0].Length;
        for(int i=0; i<rows; i++)
        {
            for(int j=0; j<cols; j++)
            {
                if(grid[i][j]==1)
                {
                    if((i-1)<0 || grid[i-1][j]==0)
                    {
                        perimeter+=1;
                    }

                    if((j-1)<0 || grid[i][j-1]==0)
                    {
                        perimeter+=1;
                    }

                    if((i+1)>=rows || grid[i+1][j]==0)
                    {
                        perimeter+=1;
                    }

                    if((j+1)>=cols || grid[i][j+1]==0)
                    {
                        perimeter+=1;
                    }
                }
                //Console.WriteLine("{0},{1},{2}",i,j, perimeter);
            }
        }
        
        return perimeter;
    }
}

//time:O(MN)
//Space: O(1)