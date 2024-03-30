/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //trace path of finding both the nodes and compare the 
        //paths to find the lowest common ancestor
        List<TreeNode> path1=new List<TreeNode>(), path2=new List<TreeNode>();
        Dfs(root, p, path1);
        Dfs(root, q, path2);
        TreeNode prev=null;
        for(int i=0; i<path1.Count; i++)
        {
            if(i>=path2.Count || path1[i].val!=path2[i].val)
                return prev;
            prev=path1[i];
        }
        return prev;
    }
    
    void Dfs(TreeNode node, TreeNode x, List<TreeNode> path)
    {
        if(node==null)
            return;
        
        path.Add(node);
        
        if(node.val == x.val)
            return;
        
        if(node.val > x.val)
            Dfs(node.left, x, path);
        else
            Dfs(node.right, x, path);
        
        return;
    }
}

//time: O(log N)
//space: O(log N)