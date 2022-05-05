"""

sort the flowers in ascending
update count for each person at time T

"""

class Solution:
    def fullBloomFlowers(self, A: List[List[int]], persons: List[int]) -> List[int]:
        start, end = sorted(a for a,b in A), sorted(b for a,b in A)
        result=[]
        for t in persons:
            result.append(bisect_right(start, t) - bisect_left(end, t))
            
        return result

    