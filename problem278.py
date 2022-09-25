# The isBadVersion API is already defined for you.
# def isBadVersion(version: int) -> bool:
"""

    1   2   3   4   5
low=0, high=4, mid=2, firstbad=
low=0, high=4, mid=2

"""


class Solution:
    def firstBadVersion(self, n: int) -> int:
        left, right=1, n
        ans = -1
        while left<=right:
            mid=(left+right)//2
            if isBadVersion(mid):
                ans=mid
                right=mid-1
            else:
                left=mid+1
            
        return ans
        
#Time: O(logN)
#Space: O(1)