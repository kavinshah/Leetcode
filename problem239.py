"""
 0 1 2   3 4
[1,3,-1,-3,5,3,6,7]
i=0, p=[1], res=[]
i=1, p=[3], res=[]
i=2, p=[3,-1], res=[3]
i=3, p=[3,-1,-3], res=[3,3]
i=4, p=[5], res=[3,3,5]
i=5, p=[5,3], res=[3,3,5,5]
i=6, p=[6], res=[3,3,5,5,6]
i=7, p=[7], res=[3,3,5,5,6,7]

"""

class Solution:
    def maxSlidingWindow(self, nums: List[int], k: int) -> List[int]:
        q= deque()
        res=[]
        for i in range(len(nums)):
            # create a monotonic decreasing stack
            while q and nums[q[-1]]<nums[i]:
                q.pop()
            q.append(i)
            
            # remove the first element outside of the window
            if q[0] == i-k:
                q.popleft()
            # start adding to the result if the window is now greater than k
            if i>=k-1:
                #print(q)
                res.append(nums[q[0]])
            
        return res
        
#Time: O(N)
#Space: O(N)