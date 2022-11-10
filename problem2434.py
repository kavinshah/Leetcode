"""

baac
"", ba, ac
ab, "", ac
abca, "", ""

baac
"", baa, c
aab, "", c
aabc, "", ""


cabe

'', '', cabe
'', c, abe
'', ca, be
a, c, be
a, cb, 'e'
ab, c, e
abce 

baca

'', ba, ca
a, b, ca
a, bca, ''
aa, bc,''
aacb, '', ''

"", ba, ca
ab, "", ca
ab, ca, ""
abac, "", ""

"", baca, ""
acab, "", ""

Time: O(N)
Space: O(N)

"""

class Solution:
    def robotWithString(self, s: str) -> str:
        counts = [0]*26
        last=0
        for c in s:
            counts[ord(c)-ord('a')] += 1
        def getMin():
            nonlocal last
            for i in range(last, len(counts)):
                if counts[i]>0:
                    last=i
                    return chr(i+ord('a'))
         #vzhofn po   
        stack=[]
        result = []
        for c in s:
            minChar = getMin()
            #print("before:", result, stack, c, minChar, counts)
            while stack and stack[-1]<=minChar:
                result.append(stack.pop())
            stack.append(c)
            counts[ord(c)-ord('a')]-=1
            #print("after:", result, stack, c, minChar, counts)

        while stack:
            result.append(stack.pop())

        return ''.join(result)
