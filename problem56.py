"""

sorted on start time


"""
class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        intervals=sorted(intervals, key=lambda x : (x[0],x[1]))
        result=[intervals[0]]
        for interval in intervals[1:]:
            curr=result.pop()
            if curr[0] <= interval[0] <= curr[1]:
                curr=[curr[0], max(interval[1], curr[1])]  
                result.append(curr)
            else:
                result.append(curr)
                result.append(interval)
            
        return result
        
        
#time: O(NlogN)
#space: O(N)