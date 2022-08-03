# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

#     1 -> 2 -> 3
# odd= slow.next to end

#     1 -> 2 -> 3 -> 4
    
# even = prev.next to end
    
#     1->2->3->4->5
# odd=prev.next to end

#     1->2->3->4->5->6

# 1->2->null
# 3->null

# 1->3->2
"""

ideal brute force:

-> find length of list
-> create a list from n/2+1 to end in reverse order.
-> merge both the lists.


optmized
-> find the mid point using fast and slow pointers
-> reverse the second half of the list.
-> traverse from both the ends of the list and merge the heads

"""


class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        """
        Do not return anything, modify head in-place instead.
        """
        if head==None or head.next==None:
            return head
        
        slow=head
        fast=head
        prev=None
        while(fast and slow):
            fast=fast.next
            if not fast:
                prev=prev.next
                break
            fast=fast.next
            prev=slow
            slow=slow.next
            
        head2=prev.next
        prev.next=None
        
        #reverse from head2 to end
        current=head2
        nextNode=None
        prev=None
        while current:
            nextNode=current.next
            current.next=prev
            prev=current
            current=nextNode
        
        head2=prev
        
        #merge 2 lists
        h1=head
        h2=head2
        #print(head,head2)
        while h1 and h2:
            t2=h2
            h2=h2.next
            t1=h1.next
            h1.next=t2
            t2.next=t1
            h1=t1
            
        return head


        