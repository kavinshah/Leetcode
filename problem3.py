"""

abcabcbb

currchar = a, set : a, count = 1, maxcount = -inf
currchar = b, set : ab, count = 2, maxcount = -inf
currchat = c, set: abc, count = 3, maxcount = -inf
currchar = a, set: a, count = 1, maxcount = 3
curr = b, set : ab, count = 2, maxcount = 3
curr = c, set : abc, count = 3, maxcount = 3
curr = b, set : b, count = 1, maxcount = 3
curr = b, set : b, count = 1, maxcount = 3

dvdfd

front=0, back=0, chars = d, count = 1, max=0
front=1, back=0, chars=dv, count = 2, max=0
front=2, back=0, chars = dv, count=2, max=2
    front=2, back=1, chars = v, count=1, max=2
    front=2, back=1, chars = vd, count=2, max=2
front=3, back=1, chars = vdf, count=3, max=2
front=4, back=1, chars = vdf, count=3, max=3
    front=4, back=2, chars = df, count=2, max=3
    front=4, back=3, chars = f, count=1, max=3
    front=4, back=3, chars = fd, count=2, max=3
front=5    



"""
class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        chars = set()
        maxcount = 0
        currcount = 0
        j=0
        for i in range(len(s)):
            if s[i] not in chars:
                currcount +=1
                chars.add(s[i])
            else:
                maxcount = max(maxcount, currcount)
                while(s[i] in chars):
                    chars.remove(s[j])
                    currcount-=1
                    j+=1
                currcount+=1
                chars.add(s[i])
                
            #print(chars)
        return max(maxcount, currcount)
                