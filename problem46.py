"""

[1] + [2,3]
[1] + [2] + [3]
[1] + [3] + [2]

[2] + [1,3]
[2] + [1] + [3]
[2] + [3] + [1]


[3] + [1,2]
[3] + [1] + [2]
[3] + [2] + [1]

"""
class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        result = []
        def findPermutations(arr, res):
            nonlocal result
            if not arr:
                result.append(res)
            
            for i in range(len(arr)):
                findPermutations(arr[:i] + arr[i+1:], res + [arr[i]])
                
        findPermutations(nums, [])
        return result