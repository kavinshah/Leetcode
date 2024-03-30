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
    public bool IsValidBST(TreeNode root) {
        return CheckBST(Int64.MinValue, Int64.MaxValue, root);
    }
    
    bool CheckBST(long minValue, long maxValue, TreeNode node)
    {
        if(node==null)
            return true;
        
        // Eventhough current root may not be bounded to [minvalue, maxvalue] and return true, the recursive calls to left and right children will return false if the values are not bounded to [minvalue, maxvalue]
        
        return CheckBST(minValue, node.val, node.left)
            && CheckBST(node.val, maxValue, node.right)
            && node.val<maxValue
            && node.val>minValue;
    }
}


//Time:O(N)
//Space: O(N)
