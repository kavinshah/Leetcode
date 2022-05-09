class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        result=0
        for i in range(len(nums)+1):
            result=result^i
        
        for n in nums:
            result=result^n
            
        return result