# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
"""

5-1-3 --> dfs
5-2-6 --> dfs

u->u->
r->l

5-2-6 --> dfs
5-1-3 --> dfs

u->u
l->l

5-2-6 --> dfs
5 --> dfs
u->u

5 --> dfs
5-2-6 --> dfs

r->l

5-2-6
5-2-4

u
r

1. dfs to find the start node.
2. dfs to reach the destination node.
3. while you are going to destination node, use a stack to store the path
4. 


"""

class Solution:
    def getDirections(self, root: Optional[TreeNode], startValue: int, destValue: int) -> str:
        def findpath(node, x, d):
            if not node:
                return None
            if node.val == x:
                return True
            
            if node.left and findpath(node.left, x, d):
                d.append("L")
            elif node.right and findpath(node.right, x, d):
                d.append("R")
            
            return d
        
        directionS=[]
        directionD=[]
        findpath(root, startValue, directionS)
        findpath(root, destValue, directionD)
        
        #print(directionS, directionD)
        while directionS and directionD and directionS[-1]==directionD[-1]:
            directionS.pop()
            directionD.pop()
            
        return ''.join(["U"]*(len(directionS)) + directionD[::-1])