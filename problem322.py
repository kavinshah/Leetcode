"""
bottom up approach iteration:
dp[i]= min(dp[i], 1+dp[i-c]) - c=coins, and i-c>=0
     = -1                     - otherwise

"""
class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        memoize = [0]*(amount+1)
        def performChange(x):
            nonlocal coins, memoize
            if x<0:
                return -1
            if x==0:
                return 0
            if memoize[x]!=0:
                return memoize[x]
            minimum = float('inf')
            for c in coins:
                res = performChange(x-c)
                if res>=0:
                    minimum=min(minimum, 1+res)
            if minimum==float('inf'):
                memoize[x]=-1
            else:
                memoize[x]=minimum
            return memoize[x]
            
        return performChange(amount)
    
    
#time: O(amount*N)
#space: O(amount)