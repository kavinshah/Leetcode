/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}

queue=[1], temp=[], prev=null, curr=null
queue=[], temp=[2], prev=null, curr=1
queue=[], temp=[2,3], prev=2, curr=1
queue=[2,3], temp=[], prev=null, curr=null
queue=[3], temp=[], prev=null, curr=2
queue=[3], temp=[4], prev=4, curr=2
queue=[3], temp=[4,5], prev=5, curr=2
queue=[], temp=[4,5,6,7], prev=6, curr=3
queue=[4,5,6,7], temp=[], prev=null, curr=null
queue=[5,6,7], temp=[], prev=4, curr=4
queue=[6,7], temp=[], prev=5, curr=5
queue=[7], temp=[], prev=5, curr=6
queue=[], temp=[], prev=6, curr=7

*/

public class Solution {
    public Node Connect(Node root) {
        
        if(root==null)
            return null;
        
        Traverse(root);
        return root;
    }
    
    void Traverse(Node current)
    {
        if(current==null)
            return;
        
        if(current.left!=null)
            current.left.next = current.right;
        
        if(current.right!=null && current.next!=null)
            current.right.next = current.next.left;
        
        Traverse(current.left);
        Traverse(current.right);
    }
}

//Time: O(N)
//space: O(1)