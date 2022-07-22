class Solution:
    def hasAllCodes(self, s: str, k: int) -> bool:
        count = 1<<k
        visited = set()
        current = deque(s[:(k-1)])
        for i in range(k-1, len(s)):
            current.append(s[i])
            if ''.join(current) not in visited:
                visited.add(''.join(current))
                count-=1
            current.popleft()
        return count==0
            
        