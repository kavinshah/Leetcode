"""

-8
1000
0111
1000

"""

class Solution:
    def isPowerOfTwo(self, n: int) -> bool:
        if n==0:
            return False
        return n&-n==n
            
        
        
#time: O(1)
#spacE: O(1)