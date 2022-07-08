"""

dp[i] = True -----> dp[j] and s[j+1:i] exists in wordDict
      = False  ----> otherwise

"""
class Solution:
    def wordBreak(self, s: str, wordDict: List[str]) -> bool:
        dp=[False]*(len(s)+1)
        wordSet = frozenset(wordDict)
        dp[0]=True
        for i in range(len(s)+1):
            for j in range(i-1,-1,-1):
                if dp[j] and s[j:i] in wordSet:
                    dp[i]=1
                    
        return dp[len(s)]
    
#Time: O(N^3)
#Space: O(N)