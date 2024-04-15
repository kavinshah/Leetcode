/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        
        if(lists.Length==0)
            return null;
        
        if(lists.Length==1)
            return lists[0];
        
        ListNode head = new ListNode();
        ListNode current = head;
        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();
        
        foreach(ListNode h in lists)
        {
            if(h!=null)
                minHeap.Enqueue(h, h.val);
        }
        
        while(minHeap.Count>0)
        {
            ListNode minElement = minHeap.Dequeue();
            if(minElement.next!=null)
                minHeap.Enqueue(minElement.next, minElement.next.val);
            current.next = minElement;
            current=current.next;
            current.next=null;
        }
        return head.next;
    }
}

//time: O(NklogN)
//space: O(N)
