/*

[
[1,0,1,1,0,0,1,0,0,1],
[0,1,1,0,1,0,1,0,1,1],
[0,0,1,0,1,0,0,1,0,0],
[1,0,1,0,1,1,1,1,1,1],
[0,1,0,1,1,0,0,0,0,1],
[0,0,1,0,1,1,1,0,1,0],
[0,1,0,1,0,1,0,0,1,1],
[1,0,0,0,1,1,1,1,0,1],
[1,1,1,1,1,1,1,0,1,0],
[1,1,1,1,0,1,0,0,1,1]
]


[
[1,0,1,1,0,0,1,0,0,1],
[0,1,1,0,1,0,1,0,1,1],
[0,0,1,0,1,0,0,1,0,0],
[1,0,1,0,1,1,1,1,1,1],
[0,1,0,1,1,0,0,0,0,1],
[0,0,1,0,1,1,1,0,1,0],
[0,1,0,1,0,1,0,0,1,1],
[1,0,0,0,1,2,1,1,0,1],
[2,1,1,1,1,2,1,0,1,0],
[2,2,2,1,0,1,0,0,1,1]
]

[
[1,0,1,1,0,0,1,0,0,1],
[0,1,1,0,1,0,1,0,1,1],
[0,0,1,0,1,0,0,1,0,0],
[1,0,1,0,1,1,1,1,1,1],
[0,1,0,1,1,0,0,0,0,1],
[0,0,1,0,1,1,1,0,1,0],
[0,1,0,1,0,1,0,0,1,1],
[1,0,0,0,1,2,1,1,0,1],
[2,1,1,1,1,2,1,0,1,0],
[3,2,2,1,0,1,0,0,1,1]
]

*/



public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        int m = mat.Length;
        int n = mat[0].Length;
        int[][] dp = new int[m][];
        
        for (int row = 0; row < m; row++) {
            dp[row]=new int[n];
            for (int col = 0; col < n; col++) {
                dp[row][col] = mat[row][col];
            }
        } 

        for (int row = 0; row < m; row++) {
            for (int col = 0; col < n; col++) {
                if (dp[row][col] == 0) {
                    continue;
                }

                int minNeighbor = m * n;
                if (row > 0) {
                    minNeighbor = Math.Min(minNeighbor, dp[row - 1][col]);
                }
                
                if (col > 0) {
                    minNeighbor = Math.Min(minNeighbor, dp[row][col - 1]);
                }
                
                dp[row][col] = minNeighbor + 1;
            }
        }
        
        for (int row = m - 1; row >= 0; row--) {
            for (int col = n - 1; col >= 0; col--) {
                if (dp[row][col] == 0) {
                    continue;
                }
                
                int minNeighbor = m * n;
                if (row < m - 1) {
                    minNeighbor = Math.Min(minNeighbor, dp[row + 1][col]);
                }
                
                if (col < n - 1) {
                    minNeighbor = Math.Min(minNeighbor, dp[row][col + 1]);
                }
                
                dp[row][col] = Math.Min(dp[row][col], minNeighbor + 1);
            }
        }
        
        return dp;
    }
}

//DP
//Time: O(M*N)
// Space: O(M*N)
