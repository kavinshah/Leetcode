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
    public int SumNumbers(TreeNode root) {
        
        return RootToSum(root, 0);
    }
    
    public int RootToSum(TreeNode node, int currentSum)
    {
        if(node==null)
        {
            return 0;
        }
        
        currentSum = currentSum*10+node.val;
        
        if(node.left==null && node.right==null)
        {
            return currentSum;
        }
        
        return RootToSum(node.left, currentSum)
                + RootToSum(node.right, currentSum);
        
    }
}

//Time: O(N)
//Space: O(N)