class Solution:
    def balancedStringSplit(self, s: str) -> int:
        count=0
        result=0
        for c in s:
            count=count+1 if c=='L' else count - 1 
            if count==0:
                result+=1
                
        return result
        
#Time=O(N)
#space:O(1)