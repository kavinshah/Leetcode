"""

[1,2,3,1]

index:
    max(amount+index+2, index+1)
                         0 1 2 3 4 5 6 7
                        [1,2,3,1,7,9,3,1]
                        
                                    0,0
                        /                   \
                1+f(2)                      f(1)
            /               \
        3+f(4) =13           f(3)
        /       \
    10=7+f(6)    f(5)=10
    /   \     /         \
    3   1    9+f(7)10 f(6) 3
            /     \   /     \
            1      0 3+f(8)   f(7)
                        |    |
                        3    1
                        
f(n) = max(f(n-2)+x[n], f[n-1]) ----> n>=2
     = x[n]                     ----> n=0, n=1
     = 0                        ----> otherwise
                        
[1,2,3,1]
memo=[1,0,0,0], i=0
memo=[1,2,0,0], i=1
memo=[1,2,4,0], i=2
memo=[1,2,4,4], i=3

[2,7,9,3,1]
memo=[2,0,0,0,0] i=0
memo=[2,7,0,0,0] i=1
memo=[2,7,11,0,0] i=2
memo=[2,7,11,11,0] i=3
memo=[2,7,11,11,12] i=4

[2,1,1,2,7,9,3,1]
memo=[2,0,0,0,0,0,0,0], i=0
memo=[2,2,0,0,0,0,0,0], i=1
memo=[2,2,3,0,0,0,0,0], i=2
memo=[2,2,3,4,0,0,0,0], i=3
memo=[2,2,3,4,10,0,0,0], i=4
memo=[2,2,3,4,10,13,0,0], i=5
memo=[2,2,3,4,10,13,13,0], i=6
memo=[2,2,3,4,10,13,13,14], i=7
"""
class Solution:
    def rob(self, nums: List[int]) -> int:
        first=0
        second=nums[0]
        third=max(first, second)
        for i in range(2, len(nums)+1):
            third=max(first+nums[i-1], second)
            first=second
            second=third
            
        return third
    
#Time: O(N)
#Space: O(1)