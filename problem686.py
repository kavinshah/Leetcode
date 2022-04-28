import math
​
class Solution:
    def repeatedStringMatch(self, a: str, b: str) -> int:
        n = len(a)
        m = len(b)
        
        # Check if b repeats with period n
        for i in range(m):
            if b[i] != b[i%n]:
                return -1
        
        # Find rotation offset
        for offset in range(n):
            for i in range(min(n, m)):
                if a[(offset+i)%n] != b[i]:
                    break
            else:
                break
        else:
            return -1
        
        # Use offset in our calculation
        if m <= n - offset:
            return 1
        else:
            return 1 + ceil_div(m - (n-offset), n)
​
def ceil_div(a, b):
    return (a + b - 1) // b