# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseBetween(self, head: Optional[ListNode], left: int, right: int) -> Optional[ListNode]:
        prev=None
        curr=head
        next=None
        i=1
        while(i<left):
            prev=curr
            curr=curr.next
            i+=1
        end=curr
        start=prev
        while(i<=right):
            i=i+1
            next=curr.next
            curr.next=prev
            prev=curr
            curr=next
        if start:
            start.next=prev
        if end:
            end.next=next
        if left==1:
            return prev
        return head
        
        
#time:O(N)
#space: O(1)
#single pass