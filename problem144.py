#iterative approach
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
        
        