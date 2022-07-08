"""
                                0
                            1       2
                          2   3    3   4
                          



"""
class Solution:
    def climbStairs(self, n: int) -> int:
        first=0
        second=1
        third=0
        for i in range(1, n+1):
            third=first+second
            first=second
            second=third
            
        return third
        
#Time: O(N)
#Space: O(1)