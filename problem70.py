"""

                    5
            /               \
           5-1=4            5-2
        /       \
        3        2
      /   \
      2    1
  /     \  /\
   1    0  0 -1
  / \   |  |  |
  0  -1 +1 +1 0
  |   |
  +1  0

0:0
1:1
2:2
3:3
4:5
5:8


"""
class Solution:
    def climbStairs(self, n: int) -> int:
        def findPath(n):
            nonlocal ways
            if n==0:
                return 1
            
            if n<0:
                return 0
            
            if n in ways:
                return ways[n]
            
            ways[n]=findPath(n-1) + findPath(n-2)
            return ways[n]
        
        count=0
        ways = {0:0, 1:1}
        
        return findPath(n)