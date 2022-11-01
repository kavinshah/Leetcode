"""
# Definition for a Node.
class Node:
    def __init__(self, val, prev, next, child):
        self.val = val
        self.prev = prev
        self.next = next
        self.child = child


# use a stack for recursion
# push head onto the stack
# pop the top element from stack
# push node.next if not null
# then push node.child if not null
# loop through the stack until the stack is not empty 


"""

class Solution:
    def flatten(self, head: 'Optional[Node]') -> 'Optional[Node]':
        if not head:
            return None
        stack = [head]
        prev=None

        print("new case")

        while(stack):
            curr=stack.pop()
            if curr.next:
                stack.append(curr.next)

            if curr.child:
                stack.append(curr.child)

            curr.child=None
            #curr.prev=prev

            if prev:
                prev.next=curr
                curr.prev=prev
            
            prev=curr
            print(curr.val)

        return head



#time: O(N)
#space: O(N)