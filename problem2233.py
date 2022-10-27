"""

5*2=10
5*3=15

6*1=6

maintain a min heap and always increament the smallest number. This will effectively increase the total product of nums

6*3*3*4=24*9=216

"""
class Solution:
    def maximumProduct(self, nums: List[int], k: int) -> int:
        minheap = []
        for n in nums:
            heapq.heappush(minheap, n)
        
        while(k>0):
            k-=1
            x = heapq.heappop(minheap)
            x+=1
            heapq.heappush(minheap, x)
            
        product = 1
        modulo=10**9+7
        for m in minheap:
            product=(product*m)%modulo

        return product%modulo


#time: O(KlogN)
#Space: O(NlogN)