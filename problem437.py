# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def pathSum(self, root: Optional[TreeNode], targetSum: int) -> int:
        complements = defaultdict(int)
        complements[0]=1
        counts = 0
        def dfs(node, currsum):
            nonlocal complements, targetSum, counts
            if not node:
                return
            currsum+=node.val
            counts+=complements[currsum-targetSum]
            complements[currsum]+=1
            dfs(node.left, currsum)
            dfs(node.right, currsum)
            complements[currsum]-=1
            return
        
        dfs(root, 0)
        return counts
        
#Time: O(V+E)
#Space: O(V+E)