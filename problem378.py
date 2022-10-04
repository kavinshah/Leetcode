"""

[1, 5,  9]
[10,11,13]
[12,13,15]



"""

class Solution:
    def kthSmallest(self, matrix: List[List[int]], k: int) -> int:
        maxheap=[]
        N=len(matrix)*len(matrix)
        for r in matrix:
            for x in r:
                if len(maxheap)<(N-k+1):
                    heappush(maxheap, x)
                elif maxheap[0] < x:
                    heappop(maxheap)
                    heappush(maxheap, x)

        return maxheap[0]


#time: O(nlog(n^2-k+1))
#space: O(n^2-K)