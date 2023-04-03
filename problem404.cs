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
 */

public class Solution {
    int result=0;
    
    public int SumOfLeftLeaves(TreeNode root) {
        Dfs(root, root.left);
        Dfs(root, root.right);
        return result;
    }
    
    public void Dfs(TreeNode parent, TreeNode node)
    {
        if(node==null)
            return;
        
        if(node.left==null && node.right==null && parent.left==node)
            result += node.val;
        
        Dfs(node, node.left);
        Dfs(node, node.right);
        return;
        
    }
}

//time: O(N)
//space: O(log N)