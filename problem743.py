class Solution:
    def networkDelayTime(self, times: List[List[int]], n: int, k: int) -> int:
        dist=[float('inf')]*(n+1)
        dist[k]=0
        for i in range(n):
            flag=0
            for e in times:
                if dist[e[1]] > dist[e[0]]+e[2]:
                    flag=1
                    dist[e[1]] = dist[e[0]]+e[2]
                    
            if flag==0:
                break
                
        if max(dist[1:])==float('inf'):
            return -1
        return max(dist[1:])
    
        
#time: O(v*e)
#space: O(v)