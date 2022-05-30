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
        coins = sorted(coins, reverse=True)
        result=float('inf')
        coindict = {0:0}
        
        for c in coins:
            coindict[c]=1
            
        for a in range(1, amount+1):
            if a in coindict:
                continue
                
            res = float('inf')
            for c in coins:
                if (a-c)>=0 and (a-c) in coindict:
                    res=min(res, 1+coindict[a-c])
                #print(a, c, coindict)
                
            if res != float('inf'):
                coindict[a]=res
                
            #print(a, coindict)
            
        if amount in coindict:
            return coindict[amount]
        
        return -1
