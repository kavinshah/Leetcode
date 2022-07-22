class Solution:
    def hasAllCodes(self, s: str, k: int) -> bool:
        count = 1<<k
        visited = set()
        current = []
        for i in range(k, len(s)+1):
            if s[i-k:i] not in visited:
                visited.add(s[i-k:i])
                count-=1
        return count==0
            
#Time: O(NK)
#space: O(NK)