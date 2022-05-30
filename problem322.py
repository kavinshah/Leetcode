"""

                        11
                /       |       \
                6         9        10
            /   |   \
            1   4   5
    /   |   \   /|\   
    -4  -1  0  -1,2,0
            |    /|\
            3  -2,0,1 
                  | /|\              
                  4-4,-1,0
                         |
                         
0:0
1:1
2:1
3:2
4:2
5:1
6:2
7:2
8:3
9:3
10:2
11:3
12:3
13:4

"""
class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        dp = [float('inf')] * (amount + 1)
        dp[0] = 0
        
        for coin in coins:
            for x in range(coin, amount + 1):
                dp[x] = min(dp[x], dp[x - coin] + 1)
        return dp[amount] if dp[amount] != float('inf') else -1 