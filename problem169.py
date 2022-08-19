class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        last = nums[0]
        count=1
        
        for i in range(1, len(nums)):
            if nums[i]==last:
                count+=1
            else:
                if count>0:
                    count=count-1
                else:
                    last=nums[i]
                    count=1
                
        return last
        
        
#time: O(N)
#space: O(1)
# https://www.geeksforgeeks.org/boyer-moore-majority-voting-algorithm/