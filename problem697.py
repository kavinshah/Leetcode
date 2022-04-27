"""

1. find freq of each element. use dict
2. find max freq and store all elements with max freq in a dict
3. find first and last index of max degree elements
4. return the lowest distance.

"""
from collections import defaultdict
class Solution:
    def findShortestSubArray(self, nums: List[int]) -> int:
        freq = defaultdict(int)
        mindistance={}
        maxdistance=defaultdict(int)
        maxfreq=0
        
        for i in range(len(nums)):
            n=nums[i]
            freq[n]+=1
            
            maxdistance[n]=i
            if n not in mindistance:
                mindistance[n]=i
            maxfreq = max(maxfreq, freq[n])
            
        result=len(nums)
        for n in freq.keys():
            if freq[n]==maxfreq:
                result=min(result, maxdistance[n]-mindistance[n]+1)
                
        return result