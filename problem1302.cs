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
    int sum=0, maxDepth=0;
    public int DeepestLeavesSum(TreeNode root) {
        dfs(root,0);
        return sum;
    }
    
    public void dfs(TreeNode root, int depth){
        if (root==null){
            return;
        }
        
        if (depth> maxDepth){
            maxDepth=depth;
            sum=root.val;
        }
        else if (depth==maxDepth){
            sum+=root.val;
        }
        
        dfs(root.right, depth+1);
        dfs(root.left, depth+1);
        return;
        
    }
}

//time: O(N)
//space: O(log N)