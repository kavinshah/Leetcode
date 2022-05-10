class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        charArr = [0]*26
        
        for char in s:
            charArr[ord(char)-ord('a')]+=1
            
        for char in t:
            charArr[ord(char)-ord('a')]-=1
        
        for n in charArr:
            if n!=0:
                return False
        
        return True
        
        
#Time: O(N)
# Space: O(1)