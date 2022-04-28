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
        found_offset = False
        for offset in range(n):
            found_offset = True
            for i in range(min(n, m)):
                if a[(offset+i)%n] != b[i]:
                    found_offset = False
                    break
            if found_offset:
                break
        if not found_offset:
            return -1
        
        # Use offset in our calculation
        if m <= n - offset:
            return 1
        else:
            return 1 + math.ceil((m - (n-offset))/n)