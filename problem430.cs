/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        
        if(head==null)
        {
            return null;
        }
        
        Stack<Node> stack = new Stack<Node>();
        Node prev = null;
        stack.Push(head);
        
        while(stack.Count!=0)
        {
            Node curr = stack.Pop();
            
            if(prev!=null)
            {
                prev.next=curr;
                curr.prev=prev;
            }
            
            if(curr.next!=null)
            {
                stack.Push(curr.next);
            }
            
            if(curr.child!=null)
            {
                stack.Push(curr.child);
                curr.child=null;
            }
            
            prev=curr;
        }
        
        return head;
        
    }
}