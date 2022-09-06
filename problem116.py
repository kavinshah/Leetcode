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
        queue=deque()
        queue.append([root])
        while(queue):
            currentlevel=queue.pop()
            nextlevel=[]
            for i in range(len(currentlevel)-1):
                currentlevel[i].next=currentlevel[i+1]
                if currentlevel[i].left:
                    nextlevel.append(currentlevel[i].left)
                    nextlevel.append(currentlevel[i].right)
            if currentlevel and currentlevel[-1] and currentlevel[-1].left:
                nextlevel.append(currentlevel[-1].left)
                nextlevel.append(currentlevel[-1].right)
            if nextlevel:
                queue.append(nextlevel)
        return root
    
# time: O(N)
#Space: O(N)