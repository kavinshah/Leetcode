# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
import heapq
class Item:
    def __init__(self, node):
        self.val=node.val
        self.next=node.next
        
    def __lt__(self, other):
        return self.val<other.val
        
class Solution:
    def mergeKLists(self, lists: List[ListNode]) -> ListNode:
        heap = []
        head=ListNode()
        curr=head
        #insert first element from each list and push into heap
        for i in range(len(lists)):
            if lists[i]:
                l=Item(lists[i])
                heappush(heap,l)
        #continue till heap has elements. Pop the min element and push the next element of current minimum element.
        while(heap):
            minelement = heapq.heappop(heap)
            curr.next = ListNode(minelement.val)
            curr=curr.next
            if minelement.next:
                l = Item(minelement.next)
                heapq.heappush(heap, l)
        #return the head once the heap is empty.
        return head.next
    
#time: O(NklogK)
#space: O(K)