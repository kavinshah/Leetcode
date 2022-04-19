# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isCousins(self, root: Optional[TreeNode], x: int, y: int) -> bool:
        
        def dfs(root, x, depth, parent):
            if not root:
                return
            
            if root.val == x:
                return depth+1, parent
            
            result = dfs(root.left, x, depth+1, root)
            
            if not result:
                return dfs(root.right, x, depth+1, root)
            
            return result[0], result[1]
            
        
        depthX, parentX = dfs(root, x, 0, None)
        depthY, parentY = dfs(root, y, 0, None)
        
        return (depthX==depthY and parentX!=parentY)
        
        