# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        heap = []
        
        def traverse(node):
            nonlocal heap, k
            if not node:
                return
            heapq.heappush(heap, -node.val)
            if len(heap)>k:
                heapq.heappop(heap)
                
            traverse(node.left)
            traverse(node.right)
            
        heapq.heappush(heap, -root.val)
        traverse(root.left)
        if len(heap)<k:
            traverse(root.right)
            
        return -heap[0]
        
#Time: O(Nlogk)
#Space: O(k)