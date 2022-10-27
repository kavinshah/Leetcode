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
        modulo=10**9+7
        
        for n in nums:
            heapq.heappush(minheap, n)
        
        if len(nums)==1:
            return (nums[0]+k)%modulo

        while(k>0):
            x = heapq.heappop(minheap)
            y=minheap[0]
            diff=min(k, y-x+1)
            k=k-diff
            x=x+diff
            heapq.heappush(minheap, x)
        
        product = 1
        for m in minheap:
            product=(product*m)%modulo

        return product%modulo


#time: O(KlogN)
#Space: O(NlogN)