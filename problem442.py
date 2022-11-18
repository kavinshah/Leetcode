class Solution:
    def findDuplicates(self, nums: List[int]) -> List[int]:
        for curr in range(len(nums)):
            # print("i", i, ", nums:", nums)
            if curr+1==nums[curr]:
                continue
            # curr=i
            #print('while loop:', curr)
            while (curr+1)!=nums[curr]:
                if nums[nums[curr]-1] == nums[curr]:
                    break 
                temp = nums[nums[curr]-1]
                nums[nums[curr]-1] = nums[curr]
                nums[curr] = temp
                #print(nums)

        result = []
        for i in range(len(nums)):
            if nums[i]-1!=i:
                result.append(nums[i])
        return result
        
#time: O(N^2)
#space: O(1)