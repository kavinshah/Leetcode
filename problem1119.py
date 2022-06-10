class Solution:
    def removeVowels(self, s: str) -> str:
        result=[]
        
        for i in range(len(s)):
            if s[i] not in ['a','e','i','o','u']:
                result.append(s[i])
                
        return ''.join(result)