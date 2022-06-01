class Solution:
    def canJump(self, nums: List[int]) -> bool:
        maxreachable = 0
        for i in range(len(nums)):
            if maxreachable<i:
                return False
            if maxreachable>=len(nums)-1:
                return True
            maxreachable = max(nums[i]+i, maxreachable)
            
            
        return maxreachable>=len(nums)-1
            
            
#Time: O(N)
#Spacec: O(1)