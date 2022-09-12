"""

nums = [1,1,1], k=2

nums = [1,2,3], k=3

complement = [-2], currsum=1, res = 0
complement = [-2, 0, ], currsum=3, res = 1
complement = [0, -2], currsum=3, res = 2


nums = [1,1,2,-1,-5,2,3], target=3
i=0, comp=[2,], sum=1, res=0
i=1, comp=[2,1],sum=2, res=0
i=2, comp=[2,1,-1], sum=4, res=0
i=3, comp=[2,1,-1,0], sum=3, res=1,
i=4, comp=[2,1,-1,5], sum=-2, res=1
i=5, comp=[2,1,-1,5], sum=0, res=2,
i=6, comp=[0,2,1,-1,5], sum=3, res=2,


"""

class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        complement = defaultdict(int)
        complement[0]=1
        result=0
        currsum=0
        for n in nums:
            currsum+=n
            result+=complement[currsum-k]
            complement[currsum]+=1
            
        return result
        
#Time: O(N)
#Space: O(N)
# https://replit.com/@vokoshyv/DearExpensiveLevel#index.js