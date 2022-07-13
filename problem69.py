"""

0,200,100
0,99,48
0,47,26
0,25,12
0,11,5
0,4,2
"""
class Solution:
    def mySqrt(self, x: int) -> int:
        #2^31=323767
        #200*200=40000
        low=0
        high=10000000
        mid=(low+high)//2
        while(low<=high):
            mid=(low+high)//2
            if mid*mid==x:
                return mid
            if (mid*mid)>x:
                high=mid-1
            elif (mid+1)*(mid+1)>x:
                return mid
            else:
                low=mid+1
                
        return mid
        
        
#Time: O(log N), Space: O(1)
# was asked this in microsoft onsite
# please remember-- 2^31 != 32768. It's much larger i.e. of the order 10^10
# 2^15 = 32678