 /*

 0 1 2
[5,2,1]


                            11
                    /       |
                    6     
            /       |       \
            1       4       5
    /   |  \    /   |   \
    x   x  0    x   2    3
            |
            3



    
*/

public class Solution {
    int[] dp;
    int[] coins;
    public int CoinChange(int[] coins, int amount) {
        this.coins = coins;
        this.dp = Enumerable.Repeat(Int32.MaxValue, amount+1).ToArray();
        dp[0]=0;
        
        for(int i=1; i<=amount; i++){
            for(int j=0; j<coins.Length; j++){
                if(i>=coins[j] && dp[i-coins[j]]!=Int32.MaxValue){
                    dp[i] = Math.Min(dp[i], dp[i-coins[j]]+1);
                }
            }
        }
        
        if(dp[amount]==Int32.MaxValue)
            return -1;
        
        return dp[amount];
    }
}

//time: O(N*Amount)
//Space: O(Amount)