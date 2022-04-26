"""
  0 1  2 3  4 5 6  7 8 9
[-2,1,-3,4,-1,2,1,-5,4,2]

maxSubArray(A, i) = maxSubArray(A, i - 1) > 0 ? maxSubArray(A, i - 1) : 0 + A[i]; 

i=0, max = -2
i=1, max = 1
i=2, max = -2
i=3, max = 4
i=4, max = 3
i=5, max = 5
i=6, max = 6
i=7, max = 1
i=8, max = 5
i=9, max = 7

"""

class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        dp=[0]*len(nums)
        dp[0]=maxsum=nums[0]
        for i in range(1, len(nums)):
            dp[i]=nums[i]
            if dp[i-1]>0:
                dp[i]+=dp[i-1]   
            
            maxsum=max(maxsum, dp[i])
            
        return maxsum
    
    
    