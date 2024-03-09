/*

500*500=2,500,000

//1. For each row
//2. Find the wall and update the enemies count for all cells until the wall
//3. move beyond the wall and repeat 2 until the end of the row
//4. For each col
//5. Find the wall and update the enemies count for all cells until the wall
//6. move beyond the wall and repeat 5 until the end of col
//7. For each empty spot, calculate the total enemies count for row and col

*/

public class Solution {
    public int MaxKilledEnemies(char[][] grid) {
        int[][] enemies_row = new int[grid.Length][];
        int[][] enemies_col = new int[grid.Length][];
        int result=0;
        
        for(int i=0; i<grid.Length; i++)
        {
            enemies_row[i]=new int[grid[i].Length];
            enemies_col[i]=new int[grid[i].Length];

            int wall_index=-1;
            int enemies=0;
            for(int j=0; j<grid[i].Length; j++)
            {
                if(grid[i][j]=='E')
                    enemies++;
                
                else if(grid[i][j] == 'W')
                {
                    for(int k=wall_index+1; k<j;k++)
                    {
                        enemies_row[i][k]=enemies;
                    }
                    wall_index=j;
                    enemies=0;
                }
            }
            for(int k=wall_index+1; k<grid[i].Length;k++)
            {
                enemies_row[i][k]=enemies;
            }
        }
        
        for(int i=0; i<grid[0].Length; i++)
        {
            int wall_index=-1;
            int enemies=0;
            for(int j=0; j<grid.Length; j++)
            {
                if(grid[j][i]=='E')
                    enemies++;
                
                else if(grid[j][i] == 'W')
                {
                    for(int k=wall_index+1; k<j;k++)
                    {
                        enemies_col[k][i]=enemies;
                    }
                    wall_index=j;
                    enemies=0;
                }
            }
            for(int k=wall_index+1; k<grid.Length;k++)
            {
                enemies_col[k][i]=enemies;
            }
        }
        
//         for(int i=0; i<grid.Length; i++)
//             Console.WriteLine(String.Join(",", enemies_row[i]));
        
//         for(int i=0; i<grid.Length; i++)
//             Console.WriteLine(String.Join(",", enemies_col[i]));
        
        for(int i=0; i<grid.Length; i++)
        {
            for(int j=0; j<grid[0].Length; j++)
            {
                if(grid[i][j]=='0')
                {
                    result=Math.Max(result, enemies_row[i][j]+enemies_col[i][j]);
                }
            }
        }
        
        return result;
    }
}

//time: O(MN)
//space: O(MN)