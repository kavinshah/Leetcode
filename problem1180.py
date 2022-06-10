"""

aaaaaaaaaa
5*11=55

"""

class Solution:
    def countLetters(self, s: str) -> int:
        prev=s[0]
        count=0
        result=0
        for i in range(len(s)):
            ch=s[i]
            if ch==prev:
                count+=1
            else:
                prev=ch
                count=1
            result+=count
            
        return result