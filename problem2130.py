# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
"""

100 000

approach 1:
store all elements from 0-n/2 and then evaluate max sum

approach 2:
reverse the list from n/2+1 to n and then run 2 pointers starting at 0 and n/2+1.

approach 3:
create another list in reverse order and then evaluate the pairs from 0 to n/2-1

fine tuning:

Use slow and fast pointers to find the middle elemnt of the linked list.

5->4->2->1
5->4

"""
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        def reverseList(node):
            nextnode=None
            curr=node
            prev=None
            while(curr):
                nextnode=curr.next
                curr.next=prev
                prev=curr
                curr=nextnode

            return prev
        
        slow = head
        fast = head
        while(fast):
            slow=slow.next
            fast=fast.next.next
        mid = reverseList(slow)
        maxsum=float('-inf')
        while(mid and head):
            maxsum=max(maxsum, mid.val+head.val)
            mid=mid.next
            head=head.next
        
        return maxsum