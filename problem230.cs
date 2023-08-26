/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 
 
- traverse the entire tree
- build a max heap and insert elements
- start with left subtree
- if the heap is empty at the end of traversing the left subtree, then explore the right subtree
- if not, then return the last element in the tree
- if the tree is full while traversing the left subtree, then remove the topmost element and use the normal techniques of working with a max heap
 
 
 */

public class Solution {
    PriorityQueue<int, int> maxheap;
    int k;
    public int KthSmallest(TreeNode root, int k) {
        if(root.left==null && root.right==null)
            return root.val;
        
        maxheap = new PriorityQueue<int, int>();
        this.k=k;
        Traverse(root);
        return maxheap.Peek();
    }
    
    
    public void Traverse(TreeNode node)
    {
        if(node==null)
            return;
        
        if(maxheap.Count<k)
        {
            maxheap.Enqueue(node.val, -node.val);
        }
        else if(maxheap.Peek() > node.val)
        {
            maxheap.Dequeue();
            maxheap.Enqueue(node.val, -node.val);
        }
        
        //Console.WriteLine(maxheap.Peek());
        
        Traverse(node.left);
        Traverse(node.right);
    }
}

//Time: O(Nlogk)
//Space: O(K)