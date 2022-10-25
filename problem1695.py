class Solution:
    def maximumUniqueSubarray(self, nums: List[int]) -> int:
        maxscore = 0
        left = 0
        visited  = set()
        currscore = 0
        
        for i in range(len(nums)):
            while(nums[i] in visited and left<=i):
                visited.remove(nums[left])
                currscore -= nums[left]
                left+=1
            visited.add(nums[i])
            currscore+=nums[i]
            maxscore=max(maxscore, currscore)

        return maxscore

#time: O(N)
#Space: O(N)