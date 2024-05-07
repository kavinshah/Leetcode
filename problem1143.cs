/*


    a   b   c   d   e

a   1   1   1   1   1
c   1   1   2   2   2
e   1   1   1   1   3


*/

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[][] dp = new int[text1.Length+1][];
        
        for(int i=0; i<=text1.Length; i++)
            dp[i] = new int[text2.Length+1];
        
        for(int i=1; i<=text1.Length; i++){
            for(int j=1; j<=text2.Length; j++){
                if(text1[i-1] == text2[j-1])
                    dp[i][j] = 1+dp[i-1][j-1];
                else
                    dp[i][j] = Math.Max(dp[i-1][j], dp[i][j-1]);
            }
        }
        return dp[text1.Length][text2.Length];
    }
}

//time: O(MN)
//space: O(MN)