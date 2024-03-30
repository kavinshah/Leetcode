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
        
        //use bfs and store all items in the queue with its level id
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            Queue<Node> temp = new Queue<Node>();
            Node prev=null;
            while(queue.Count>0)
            {
                Node curr = queue.Dequeue();
                
                if(curr.left!=null)
                {
                    temp.Enqueue(curr.left);
                }
                
                if(curr.right!=null)
                {
                    temp.Enqueue(curr.right);
                }
                
                if(prev!=null)
                {
                    prev.next=curr;
                }
                prev=curr;
            }
            queue=temp;
        }
        return root;
    }
}

//Time: O(N)
//space: O(N)