"""

aabb
a-2
b-2
abba
baab

aabbaa
a-4
b-2
aab

                                    a=2, b=1, ""
                            /                      \
                    a=1, b=1, a                 a=2, b=0, b
                    /           \                   |
            a=0, b=1, aa       a=1, b=0, ab    a=1,b=0,ba
                |                   |              |
        a=0, b=0, aab         a=0, b=0, aba     a=0,b=0,baa


                                    a=2, b=1, c=1 ""
                            /                      |                    \
                    a=1,b=1,c=1 a                 a=2,b=0,c=1 b      a=2,b=1,c=0, c
                    /           \                   |                   /       \
            a=0, b=1, aa       a=1, b=0, ab    a=1,b=0,ba   a=2,b=0,c=0,cb  a=1,b=1,c=0,ca
                |                   |              |            |           /       \
        a=0, b=0, aab         a=0, b=0, aba     a=0,b=0,baa    cbaa         caab    caba




1. Check if given string is palindromic
2. 

"""
class Solution:
    def generatePalindromes(self, s: str) -> List[str]:
            def checkPalindrome(inputString):
                nonlocal counts, keyval, evenChar
                for ch in inputString:
                    counts[ord(ch)-ord('a')]+=1
                for i in range(26):
                    if counts[i]>1:
                        keyval[chr(i+ord('a'))]=counts[i]//2
                    if counts[i]%2==1:
                        evenChar+=(chr(i+ord('a')))
                return len(evenChar)<=1
            
            def getPerm(res):
                nonlocal resultset, evenChar, keyval
                flag=False
                for key in keyval.keys():
                    if keyval[key]==0:
                        continue
                    flag=True
                    keyval[key]-=1
                    res.append(key)
                    getPerm(res)
                    res.pop()
                    keyval[key]+=1
                
                if not flag:
                    resultset.append(''.join(res+[evenChar]+res[::-1]))
            
            counts = [0]*26
            evenChar=""
            resultset = []
            keyval = {}
            
            if len(s)==1:
                return [s]
            
            if not checkPalindrome(s):
                return []

            getPerm([])    
            return list(resultset)
        