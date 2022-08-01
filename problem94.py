# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

"""

inorder traversal : left + root.val + right


                1
             /      \
            2        3
         /    \     /
        4     5    6
stack=[1]
left=[2], result=[1]
left=[4], stack = [], right=[3], result=[2,1]
left=[], stack = [], right=[3,5], result=[4, 2,1]
left=[], stack = [], right=[3], result=[4, 2,1,5]
left=[], stack = [], right=[3], result=[4, 2,1,5]


left + root.val + right
stack=[], right=[], result=[1]
stack=[], right=[], result=[1]

"""

class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        if not root:
            return []
        
        return self.inorderTraversal(root.left) + [root.val] + self.inorderTraversal(root.right)