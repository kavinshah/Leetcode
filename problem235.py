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
        
        def traverseBST(root, p, q):
            if p.val>root.val and q.val>root.val:
                return traverseBST(root.right, p, q)
            elif p.val<root.val and q.val<root.val:
                return traverseBST(root.left, p, q)
            else:
                return root
            
        return traverseBST(r, p, q)