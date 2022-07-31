# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

"""
                                            
                                                15
                                /                           \
                            6                                   20
                        /       \                           /       \
                    3               9                   12             25
                /       \          /    \
                1       8        7       10
                
                        [-inf, 15]
                    [-inf, 6]   [6, 15]
                [-inf,3] [3, 6] []
            [-inf,1]
                                            
"""

class Solution:
    def isValidBST(self, node: Optional[TreeNode], low=float('-inf'), high=float('inf')) -> bool:
        
        if not low<node.val<high:
            return False
            
        return (not node.left or self.isValidBST(node.left, low, node.val)) and (not node.right or self.isValidBST(node.right, node.val, high))