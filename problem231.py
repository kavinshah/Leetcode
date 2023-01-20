"""

-8
1000
0111
1000


n=7

n            = 0000 0111
~n           = 1111 1000
~n+1 i.e. -n = 1111 1001
n&(-n)       = 0000 0001

since n&-n != n, return False

n=8

n           = 0000 1000
-n          = 1111 1000
n&-n        = 0000 1000

since n==n&-n, return True

"""

class Solution:
    def isPowerOfTwo(self, n: int) -> bool:
        if n==0:
            return False
        return n&-n==n
            
        
        
#time: O(1)
#spacE: O(1)