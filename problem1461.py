class Solution:
    def hasAllCodes(self, s: str, k: int) -> bool:
        need = 1<<k
        all_ones = (1<<k) - 1
        counts = [0]*need
        hashval=0
        for i in range(len(s)):
            hashval = (hashval<<1 & all_ones) | int(s[i])
            if i>=(k-1) and counts[hashval]==0:
                counts[hashval]=1
                need-=1
                
        return need==0