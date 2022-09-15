# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
"""

iteratively:

                            1
                    /               \
                    2               3
                /       \       /       \
                4       5       6       7
                
                
stack=[1]
stack=[3,1,2]



"""
#iterative approach
class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        stack=[]
        res=[]
        
        while True:
            while root:
                stack.append(root)
                root=root.left
            if not stack:
                return res
            root=stack.pop()
            res.append(root.val)
            root=root.right
            
        return res
            
            
            