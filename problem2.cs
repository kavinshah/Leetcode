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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result=new ListNode();
        int carry=0;
        ListNode head = result;
        
        while(l1!=null && l2!=null)
        {
            result.next = new ListNode((l1.val+l2.val+carry)%10);
            result = result.next;
            carry = (l1.val+l2.val+carry)/10;
            l1=l1.next;
            l2=l2.next;
        }
        
        if(l1!=null)
            result.next= l1;
        else if(l2!=null)
            result.next= l2;
        
        while(carry>0 && result.next!=null)
        {
            result = result.next;
            int val = (result.val+carry)%10;
            carry = (result.val+carry)/10;
            result.val = val;
        }
        
        if(carry>0)
        {
            result.next= new ListNode(carry);
        }
        
        return head.next;
    }
}

//time: O(N)
//Space: O(1)