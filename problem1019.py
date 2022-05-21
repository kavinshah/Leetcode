# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
"""
[5,3] 
pop from stack until stack is not empty and curr element > stack.top
use stack.top else 0
push current element on stack.


"""
class Solution:
    def nextLargerNodes(self, head: Optional[ListNode]) -> List[int]:
        result=deque()
        stack = []
        def traverseNodes(node):
            nonlocal result, stack
            if node.next:
                traverseNodes(node.next)
            while(stack and node.val>=stack[-1]):
                stack.pop()
            if stack:
                result.appendleft(stack[-1])
            else:
                result.appendleft(0)
            stack.append(node.val)
            return
        
        traverseNodes(head)
        return result
                