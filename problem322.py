"""

                            11
                    /       |       \
                   6        9       10
                /   |   \
              1     4   5
             /|\
           -5-1 0


"""

class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        result=float('inf')
        coins=sorted(coins, reverse=True)
        memoization = {0:0}
        def performChange(x):
            nonlocal coins, memoization
            if x==0:
                return 0
            if x<0:
                return float('inf')
            if x in memoization:
                return memoization[x]
            res = float('inf')
            for c in coins:
                res = min(res, 1+performChange(x-c))
            memoization[x]=res
            return res
        
        result=performChange(amount)
        
        if result==float('inf'):
            return -1
        return result
        
        
#Time: O(N*c),
#Space: O(N)