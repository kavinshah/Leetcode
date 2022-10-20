"""

[1,2,3]
[1,2]
[1]
[2,3]
[2]
[3]

"""
class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        result = []
        def backtracking(curr, index):
            nonlocal result

            if index>=len(nums):
                result.append(curr)
                return
            backtracking(curr+[nums[index]], index+1)
            backtracking(curr, index+1)
            return

        backtracking([], 0)
        return result

#time: O(2^N)
#space: O(2^N)