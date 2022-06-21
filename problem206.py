# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
"""
              p cn
<-1<-2<-3<-4<-5


"""
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if not head:
            return None
        
        nextp=None
        prev=None
        curr=head
        while(curr):
            nextp=curr.next
            curr.next=prev
            prev=curr
            curr=nextp
            
        return prev