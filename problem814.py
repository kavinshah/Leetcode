# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
"""

#postorder traversal
left -> right -> root

start with root:

if left subtree returns true, set root.left=null

if right subtree returns true, set root.right=null

if root==0 return left and right
else return false

Time: O(N)
space: O(N)

"""

class Solution:
    def pruneTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:

        def traverse(current):
            if not current:
                return True

            left = traverse(current.left)
            right = traverse(current.right)
            if left:
                current.left=None
            if right:
                current.right=None
            if current.val==0:
                return left and right
            return False

        if traverse(root):
            return None
        return root
