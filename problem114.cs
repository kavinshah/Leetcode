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
/*

        1
    /       \
    2       5
/       \    \
3       4     6


Dfs(node, prev)
prev.right=node
prev.left=null

stack: [6]


*/


public class Solution {
    public void Flatten(TreeNode root) {
        Dfs(root);
        return;
    }
    
    public void Dfs(TreeNode node)
    {
        if(node==null)
            return;
        
        Stack<TreeNode> stack=new Stack<TreeNode>();
        stack.Push(node);
        TreeNode prev=null;
        
        while(stack.Count>0)
        {
            TreeNode current=stack.Pop();
            if(prev!=null)
            {
                prev.left=null;
                prev.right=current;
            }
            
            if(current.right!=null)
                stack.Push(current.right);
            
            if(current.left!=null)
                stack.Push(current.left);
            
            prev=current;
            
        }
        
        
        
    }
    
}

//time: O(N)
//Space: O(N)