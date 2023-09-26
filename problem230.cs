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
- use the property of BST
- 
 
 */

public class Solution {
    int k;
    int smallest;
    public int KthSmallest(TreeNode root, int k) {
        this.k=k;
        Traverse(root);
        return smallest;
    }
    
    public void Traverse(TreeNode node)
    {
        
        if(node==null || k<1)
            return;
        
        Traverse(node.left);
        
        if(k-- == 1)
        {
            smallest=node.val;
            return;
        }
        
        Traverse(node.right);
    }
}

//Time: O(K)
//Space: O(1)
