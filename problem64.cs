/*

1   3
1   5

2*2 = (2-1)+(2-1) = 2
number of paths = 2

1   3
1   5
4   2

length of longest path:
2*3 = (2-1) + (3-1) = 3
number of paths = 3

1   3   1
1   5   1
4   2   1
3*3
length of longest path: 4
1,3,1,1,1
1,3,5,1,1
1,3,5,2,1
1,1,5,1,1
1,1,5,2,1
1,1,4,2,1
number of paths = 6

                                0,0
                        /               \
                    1,0                         0,1
            /               \           /               \
        2,0                 1,1         1,1             0,2
    /       \       /           \       /   \       /       \
    x     2,1     2,1           1,2     2,1 1,2     1,2      x
           /\      /   \       /    \   |     /\    /   \
          x  2,2   x    2,2  2,2    1,3 2,2 2,2 x   2,2 1,3
                                                     |   |
                                                    1    x
                                                     
        
                        

*/

public class Solution {
    public int MinPathSum(int[][] grid) {
        int[][] dp = new int[grid.Length][];
        
        for(int i=0; i<grid.Length; i++)
            dp[i] = Enumerable.Repeat(Int32.MaxValue, grid[0].Length).ToArray();
        
        dp[grid.Length-1][grid[0].Length-1] = grid[grid.Length-1][grid[0].Length-1];
        
        for(int i=grid.Length-1; i>=0; i--){
            for(int j=grid[0].Length-1; j>=0; j--){
                if((i+1)<grid.Length && dp[i+1][j]!=Int32.MaxValue){
                    dp[i][j] = Math.Min(dp[i][j], grid[i][j] + dp[i+1][j]);
                }
                
                if((j+1)<grid[0].Length && dp[i][j+1]!=Int32.MaxValue){
                    dp[i][j] = Math.Min(dp[i][j], grid[i][j] + dp[i][j+1]);
                }
            }
        }
        
        // for(int i=0; i<grid.Length; i++){
        //     Console.WriteLine(String.Join(",", dp[i]));
        // }
        
        return dp[0][0];
    }
}

//Time: O(MN)
//Space: O(MN)