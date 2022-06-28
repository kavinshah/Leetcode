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
        path = []
        def getPath(root, node):
            nonlocal path
            if not root:
                return False
            path.append(root)
            if root.val==node.val:
                return True
            
            if root.val>node.val:
                return getPath(root.left, node)
            return getPath(root.right, node)
        
        getPath(r, p)
        p1 = path.copy()
        path=[]
        getPath(r, q)
        p2 = path.copy()
        i=0
        result=None
        #print(p1, p2)
        while i<len(p1) and i<len(p2):
            if p1[i].val!=p2[i].val:
                return result
            result=p1[i]
            i+=1
        
        return result
        
        
#Time: O(N)
#Space: O(N)
            