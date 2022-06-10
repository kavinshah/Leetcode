class Solution:
    def canPermutePalindrome(self, s: str) -> bool:
        counts=[0]*26
        even=0
        for ch in s:
            counts[ord(ch)-ord('a')]+=1
            
        
        for c in counts:
            if c%2==1:
                even+=1
            if even>1:
                return False
            
        return True
        