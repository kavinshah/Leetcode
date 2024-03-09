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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode fast=head, slow=head;
        
        if(n==1)
        {
            if(slow.next==null)
                return null;
            while(slow.next.next != null)
            {
                slow=slow.next;
            }
            slow.next=null;
            return head;
        }
        
        for(int i=1; i<n;i++)
        {
            fast=fast.next;
        }
        
        while(fast.next!=null)
        {
            fast=fast.next;
            slow=slow.next;
        }
        
        slow.val=slow.next.val;
        slow.next=slow.next.next;
        
        return head;
    }
}

// Time: O(N)
// Space: O(1)
