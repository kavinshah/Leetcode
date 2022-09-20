# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> Optional[ListNode]:
        lenA = 0
        lenB = 0
        ptr1 = headA
        
        while ptr1:
            lenA+=1
            ptr1=ptr1.next
            
        ptr1=headB
        while ptr1:
            lenB+=1
            ptr1=ptr1.next
        
        if lenA>lenB:
            ptr1=headA
            ptr2=headB
        else:
            ptr1=headB
            ptr2=headA
            
        for i in range(abs(lenA-lenB)):
            ptr1=ptr1.next
            
        while(ptr1 and ptr2 and ptr1!=ptr2):
            ptr1=ptr1.next
            ptr2=ptr2.next
        
        if ptr1 == ptr2:
            return ptr1
        return None
        
        
#Time: O(N)
#Space: O(1)