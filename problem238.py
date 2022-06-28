class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prod = [1]*len(nums)
        for i in range(1, len(nums)):
            prod[i]=prod[i-1]*nums[i-1]
        R=1 
        for i in range(len(nums)-1, -1, -1):
            prod[i]=prod[i]*R
            R=R*nums[i]
            
            
        return prod
        
#Time: O(N)
#Space: O(1)