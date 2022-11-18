class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        for curr in range(len(nums)):
            # print("i", i, ", nums:", nums)
            if curr+1==nums[curr]:
                continue
            #print('while loop:', curr)
            while (curr+1)!=nums[curr]:
                if nums[nums[curr]-1] == nums[curr]:
                    return nums[curr] 
                temp = nums[nums[curr]-1]
                nums[nums[curr]-1] = nums[curr]
                nums[curr] = temp
                #print(nums)

        return

#time:(N^2)
#space: O(1)