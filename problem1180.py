"""

aaaaaaaaaa
5*11=55

"""

class Solution:
    def countLetters(self, s: str) -> int:
        prev=s[0]
        currcount=1
        result=0
        for i in range(1, len(s)):
            ch=s[i]
            if ch==prev:
                currcount += 1
            else:
                prev=ch
                result+=(currcount*(currcount+1))//2
                currcount=1
                
        result+=(currcount*(currcount+1))//2
        return result