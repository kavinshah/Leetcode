# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None
"""
                                                                                 1
                                           2 
[-21,10,17,8,4,26,5,35,33,-7,-16,27,-12,6,29,-12,5,9,20,14,14,2,13,-24,21,23,-21,5]
-1

"""
class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        if not head:
            return False
        
        p1, p2 = head.next, head
        
        while(p1 and p2):
            if p1==p2:
                return True
            if not p1.next:
                return False
            p1=p1.next.next
            p2=p2.next
            
        
        return p1==p2
                