class Solution:
    def intersection(self, nums: List[List[int]]) -> List[int]:
        counts = [0]*1001
        for arr in nums:
            for x in arr:
                counts[x]+=1
            
        #print(counts)
        n = len(nums)
        result = []
        for i in range(1,1001):
            if counts[i]==n:
                result.append(i)
                
        #print(result)
        return result
        
# Time: O(MN), Space: O(1)
# was asked in palantir onsite.