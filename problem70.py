"""
                                0
                            1       2
                          2   3    3   4
                          



"""
class Solution:
    def climbStairs(self, n: int) -> int:
        memoize = {0:1, 1:1}
        def climb(x):
            if x in memoize:
                return memoize[x]
            if x<0:
                return 0
            memoize[x] = climb(x-1) + climb(x-2)
            return memoize[x]
        
        return climb(n)