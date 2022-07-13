class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        current=0
        front=0
        back=len(nums)-1
        
        while(current<=back):
            if nums[current]==2:
                nums[current], nums[back]=nums[back], nums[current]
                back-=1
            elif nums[current]==0:
                nums[current], nums[front]=nums[front], nums[current]
                front+=1
                current+=1
            else:
                current+=1
                
                
#Time: O(N), Space: O(1)
#single pass solution