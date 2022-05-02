"""

abca - true
abbc - false
ebbet - true
tebbe - true
tebcbe - true
tebbem - false
axbcbaba - false
aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga - true

"aba"
"abca"
"abc"
"tebcbe"
"ebcbet"
"tebbem"
"axbcbaba"

keeping counts doesn't help because the order can be non-palindromic.
brute force is TLE
linear complexity is the only possibility

"""

class Solution:
    def validPalindrome(self, s: str) -> bool:
        i, j = 0, len(s)-1
        
        def checkPalindrome(front, back, repeat=False):
            nonlocal s, i, j
            while(front<=back):
                if s[front]!=s[back]:
                    if not repeat:
                        i, j = front, back
                    return False
                front+=1
                back-=1
            return True
        
        if not checkPalindrome(i,j):
            return checkPalindrome(i+1, j, True) or checkPalindrome(i, j-1, True)
        
        return True