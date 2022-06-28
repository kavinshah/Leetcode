# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None
"""

1. find path from root to given node for p and q
2. now compare the paths from root to givven node.
3. return the last comparable node in the path. This is the lowest common ancestor
"""
class Solution:
    def lowestCommonAncestor(self, r: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
        root=r
        while(root):
            if p.val>root.val and q.val>root.val:
                root = root.right
            elif p.val<root.val and q.val<root.val:
                root=root.left
            else:
                return root
            
        return root