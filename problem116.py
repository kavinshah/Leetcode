"""
# Definition for a Node.
class Node:
    def __init__(self, val: int = 0, left: 'Node' = None, right: 'Node' = None, next: 'Node' = None):
        self.val = val
        self.left = left
        self.right = right
        self.next = next

BFS:
level order traversal

Recursion:

root.left.next=root.right
if root.next:
    root.right.next=root.next.left
else:
    root.right.next=null
    
recursion on left child
recursion on right child

"""

class Solution:
    def connect(self, root: 'Optional[Node]') -> 'Optional[Node]':
        
        def Traverse(node):
            if not node:
                return
            
            if node.left:
                node.left.next=node.right
                
            if node.right and node.next:
                node.right.next=node.next.left
            
            Traverse(node.left)
            Traverse(node.right)
            return
        
        Traverse(root)
        return root
    
    
# time: O(N)
#Space: O(logN)