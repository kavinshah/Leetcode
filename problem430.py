"""
# Definition for a Node.
class Node:
    def __init__(self, val, prev, next, child):
        self.val = val
        self.prev = prev
        self.next = next
        self.child = child
"""

class Solution:
    def flatten(self, head: 'Optional[Node]') -> 'Optional[Node]':
        
        if not head:
            return None
        
        stack = [head]
        prev=None
        
        while(stack):
            curr=stack.pop()
            
            if prev:
                curr.prev=prev
                prev.next=curr
            
            if curr.next:
                stack.append(curr.next)
            
            if curr.child:
                stack.append(curr.child)
                curr.child=None
                
            prev=curr
            
        return head
    
    
"""
1=2=3=7=8=11=12=9=10=4=5=6

stack = [1], prev=none, curr=none
stack = [2], prev=1, curr=1
stack = [3], prev=2, curr=2
stack = [4, 7], curr=3, prev=3
stack = [4,8], curr=7, prev=7
stack = [4,9,11], curr=8, prev=8
stack = [4,9,12], curr=11, prev=11
stack = [4,9], curr=12, prev=12
stack = [4,10], curr=9, prev=9
stack = [4], curr=10, prev=10
stack = [5], curr=4, prev=4
stack = [6], curr=5, prev=5
stack = [], curr=6, prev=6


"""