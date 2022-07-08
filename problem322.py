"""
bottom up approach iteration:
dp[i]= min(dp[i], 1+dp[i-c]) - c=coins, and i-c>=0
     = -1                     - otherwise

"""
class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        
        dp=[float('inf')]*(amount+1)
        dp[0]=0
        for i in range(amount+1):
            for c in coins:
                if (i-c)>=0:
                    dp[i]=min(dp[i], 1+dp[i-c])
                    
        if dp[amount]==float('inf'):
            return -1
        return dp[amount]
    
    
#time: O(amount*N)
#space: O(amount)