"""

1. brute force
2. memoization??
-> applepenapple
      0 1 2 3 4 5 6 7
s=>   l e e t c o d e
dp = [0 0 0 0 0 0 0 0]
                0 1 2 3 4 5 6 7 8
i=0, j=0, dp = [1 0 0 0 0 0 0 0 0]
i=1, j=1, dp = [1 0 0 0 0 0 0 0 0]
i=2, j=2, dp = [1 0 0 0 0 0 0 0 0]
i=3, j=0, dp = [1 0 0 0 1 0 0 0 0]
i=4, j=3, dp = [1 0 0 0 1 0 0 0 0]
i=5, j=3, dp = [1 0 0 0 1 0 0 0 0]
i=6, j=4, dp = [1 0 0 0 1 0 0 0 0]
i=7, j=4, dp = [1 0 0 0 1 0 0 0 0]
i=8, j=4, dp = [1 0 0 0 1 0 0 0 1]

"""

class Solution:
    def wordBreak(self, s: str, wordDict: List[str]) -> bool:
        dp = [False]*(len(s)+1)
        dp[0]=True
        wordSet = set(wordDict)
        for i in range(len(s)+1):
            for j in range(i-1,-1,-1):
                if dp[j] and s[j:i] in wordSet:
                    dp[i] = True
                    #print(f"i={i},j={j}, dp={dp}")
                    break
                #print(f"i={i},j={j}, dp={dp}")
                
        return dp[len(s)]
    
    
#Time: O(N^3)
#Space: O(N)
    