class Solution:
    def isMonotonic(self, nums: List[int]) -> bool:
        x = nums[0]
        flag=0
        for n in nums[1:]:
            if n<x:
                flag = 1
                break
            x=n
            
        if flag==1:
            x=nums[0]
            for n in nums[1:]:
                if n>x:
                    return False    
                x=n

        return True