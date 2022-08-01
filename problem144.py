# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

"""

pre-order : [root.val] + left + right

                                1
                            /       \
                            2         3
                        /       \   /   \
                        4       5   6   7

q=[1], res=[]
q=[2,3], res=[1]
q=[3,4,5], res=[1,2]
q=[4,5,6,7], res=[1,2,3]
q=[5,6,7], res=[1,2,3,4]
q=[6,7], res=[1,2,3,4,5]
q=[7], res=[1,2,3,4,5,6]
q=[], res=[1,2,3,4,5,6,7]

[1,2,4,5,3,6,7]

"""


class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        if not root:
            return []
        
        return [root.val] + self.preorderTraversal(root.left) + self.preorderTraversal(root.right)