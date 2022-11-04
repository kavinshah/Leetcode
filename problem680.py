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
        
        def recursive(left, right, canSkip):
            print(left, right)
            nonlocal s
            while(left<right):
                if s[left]==s[right]:
                    left+=1
                    right-=1
                elif canSkip:
                    canSkip=False
                    #skip on left
                    return recursive(left+1, right, canSkip) or recursive(left, right-1, canSkip)
                else:
                    return False
            return True
        
        return recursive(0,len(s)-1, True)

        