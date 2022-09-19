class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        if not root:
            return []
        stack=[(root, False)]
        result=[]
        while(stack):
            curr, visited=stack.pop()
            if visited:
                result.append(curr.val)
            else:
                if curr.right:
                    stack.append((curr.right, False))
                if curr.left:
                    stack.append((curr.left, False))
                stack.append((curr, True))
        return result
        
        
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

class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        if not root:
            return []
        stack=[(root, False)]
        result=[]
        while(stack):
            curr, visited=stack.pop()
            if visited:
                result.append(curr.val)
            else:
                if curr.right:
                    stack.append((curr.right, False))
                stack.append((curr, True))
                if curr.left:
                    stack.append((curr.left, False))
                
        return result
        
        
# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def postorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        if not root:
            return []
        stack=[(root, False)]
        result=[]
        while(stack):
            curr, visited=stack.pop()
            if visited:
                result.append(curr.val)
            else:
                stack.append((curr, True))
                if curr.right:
                    stack.append((curr.right, False))
                if curr.left:
                    stack.append((curr.left, False))
                
        return result
            
            
