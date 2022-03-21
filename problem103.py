# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from collections import deque
class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        if not root:
            return []
        
        queue=deque()
        queue.append(root)
        result=[]
        while(queue):
            counter = len(queue)
            level=[]
            for i in range(counter):
                current=queue.popleft()
                level.append(current.val)
                if current.left:
                    queue.append(current.left)
                    
                if current.right:
                    queue.append(current.right)
            result.append(level)
            
        return result