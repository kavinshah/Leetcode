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

"""
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        count = 0
        curr = head
        newhead = None
        # get the length of linked list
        while(curr):
            node = ListNode(curr.val)
            node.next = newhead
            newhead = node
            
            count+=1
            curr=curr.next
            
        maxsum=float('-inf')
        curr=head
        newcurr = newhead
        for i in range(count//2):
            maxsum = max(maxsum, curr.val+newcurr.val)
            newcurr=newcurr.next
            curr=curr.next
            
        print(maxsum)
        
        return maxsum