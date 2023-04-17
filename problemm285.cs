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
    TreeNode successor,p;
    
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        this.p=p;
        Dfs(root);
        // for(int i=0; i<nodes.Count; i++)
        // {
            // if(nodes[i].val==p.val && i<(nodes.Count-1))
            // {
                // return nodes[i+1];
            // }
        // }
        return successor;
    }
    
    public void Dfs(TreeNode node)
    {
        if(node==null)
            return;
        
        if(node.val>p.val)
        {
            if(successor==null)
                successor = node;
            else if(successor.val>node.val)
            {
                successor=node;
            }
        }
        
        if(p.val<node.val)
            Dfs(node.left);
        //nodes.Add(node);
        else
            Dfs(node.right);
        return;
    }
}

//time: O(LogN)
//space: O(1)