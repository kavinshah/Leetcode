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
*/

public class Solution {
    public Node Connect(Node root) {
        Dfs(root, null);
        return root;
            
    }
    
    public void Dfs(Node current, Node parent)
    {
        if(current==null)
            return;
        
        if(current.left != null)
        {
            current.left.next = current.right;
        }
        
        if(current.right != null && current.next!=null)
        {
            current.right.next = current.next.left;
        }
        
        // if(current.next!=null)
        //     Console.WriteLine($"{current.val}, {current.next.val}");
        // else
        //     Console.WriteLine($"{current.val}, Null");
        
        Dfs(current.left, current);
        Dfs(current.right, current);
    }
}

//time: O(N)
//space: O(N) due to stack