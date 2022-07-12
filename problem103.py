# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def zigzagLevelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        if not root:
            return []
        queue = [[root]]
        result=[]
        flag=False
        while queue:
            current=queue.pop()
            row = []
            traversal = []
            for n in current:
                traversal.append(n.val)
                if n.left:
                    row.append(n.left)
                    
                if n.right:
                    row.append(n.right)
             
            if row:
                queue.append(row)
            if not flag:
                result.append(traversal)
                flag=True
            else:
                result.append(traversal[::-1])
                flag=False
                
        return result
        
        
#Time: O(N)
#Space: O(N)