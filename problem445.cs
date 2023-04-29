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
    ListNode head, current;
    int carry;
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int length1, length2;
        int diff;
        
        length1=CalculateLength(l1);
        length2=CalculateLength(l2);
        
        if(length1>=length2)
        {
            diff=length1-length2;
            Add(Iterate(diff, l1), l2);
            AppendHead(l1, diff-1);
        }
        else
        {
            diff=length2-length1;
            Add(l1, Iterate(diff, l2));
            AppendHead(l2, diff-1);
        }
        Console.WriteLine(diff);
        if(carry>0)
        {
            ListNode newnode=new ListNode(carry%10);
            carry=carry/10;
            newnode.next=current;
            current=newnode;
        }
        
        return current;
    }
    
    public void AppendHead(ListNode listnode, int skip)
    {
        ListNode newnode;
        int sum;
        
        if(skip<0)
            return;
        if(skip>=1)
            AppendHead(listnode.next, skip-1);
        
        sum=listnode.val+carry;
        carry=sum/10;
        newnode=new ListNode(sum%10);
        newnode.next=current;
        current=newnode;
        return;
    }
    
    public int CalculateLength(ListNode node)
    {
        int length=0;
        while(node!=null)
        {
            node=node.next;
            length++;
        }
        return length;
    }
    
    public ListNode Iterate(int length, ListNode node)
    {
        while(length>0)
        {
            node=node.next;
            length--;
        }
        return node;
    }
    
    public void Add(ListNode node1, ListNode node2)
    {
        ListNode newnode;
        int sum;
        if(node1.next != null && node2.next != null)
            Add(node1.next, node2.next);
        
        sum=node1.val+node2.val+carry;
        carry=sum/10;
        newnode=new ListNode(sum%10);
        newnode.next=current;
        current=newnode;
        return;
    }
}

//time: O(N)
//space: O(N)