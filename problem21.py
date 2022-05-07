# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        start= ListNode(None)
        head=start
        while(list1 and list2):
            if list1.val<list2.val:
                start.next=list1
                list1=list1.next
            else:
                start.next=list2
                list2=list2.next
            start=start.next
            
        if list1:
            start.next=list1
        else:
            start.next=list2
            
        return head.next