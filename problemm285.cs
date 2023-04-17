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
    List<TreeNode> nodes=new List<TreeNode>();
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        Dfs(root);
        for(int i=0; i<nodes.Count; i++)
        {
            if(nodes[i].val==p.val && i<(nodes.Count-1))
            {
                return nodes[i+1];
            }
        }
        return null;
    }
    
    public void Dfs(TreeNode node)
    {
        if(node==null)
            return;
        
        Dfs(node.left);
        nodes.Add(node);
        Dfs(node.right);
        return;
    }
    
}

//time: O(N)
//space: O(N)