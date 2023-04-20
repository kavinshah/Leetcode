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
    int pathWays=0;
    int targetSum;
    public int PathSum(TreeNode root, int targetSum) {
        this.targetSum=targetSum;
        Traverse(root);
        return pathWays;
    }
    
    public void Traverse(TreeNode node)
    {
        if(node==null)
            return;
        //Console.WriteLine("Dfs at root:" + node.val);
        Dfs(node, 0);
        Traverse(node.left);
        Traverse(node.right);
        
    }
    
    public void Dfs(TreeNode node, long currSum)
    {
        if(node==null)
            return;
        
        currSum+=node.val;
        
        if(currSum==targetSum)
            pathWays++;
        
        //Console.WriteLine("Visiting node:" + node.val + ", currsum:" + currSum + ",Pathways:" + pathWays);
        
        Dfs(node.left, currSum);
        Dfs(node.right, currSum);      
    }
}

//time: O(NlogN)
//space: O(logN)