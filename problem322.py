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
        coins=sorted(coins, reverse=True)
        memoization = [0]*(amount+1)
        def performChange(x):
            nonlocal coins, memoization
            if x==0:
                return 0
            if x<0:
                return -1
            if memoization[x]!=0:
                return memoization[x]
            minimum = float('inf')
            for c in coins:
                result = performChange(x-c)
                if result>=0:
                    minimum = min(minimum, 1+result)
            if minimum == float('inf'):
                memoization[x]=-1
            else:
                memoization[x]=minimum
            return memoization[x]
        
        result=performChange(amount)
        return result