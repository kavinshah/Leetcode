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
    public IList<int> InorderTraversal(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        IList<int> result = new List<int>();
        
        if(root==null)
            return result;
        
        if(root.right!=null)
            stack.Push(root.right);
        stack.Push(root);
        if(root.left!=null)
            stack.Push(root.left);
        root.left=null;
        root.right=null;
        
        while(stack.Count>0)
        {
            TreeNode current = stack.Pop();
            
            if(current.right == null && current.left == null)
                result.Add(current.val);
            else
            {
                if(current.right!=null)
                    stack.Push(current.right);
                stack.Push(current);
                if(current.left!=null)
                    stack.Push(current.left);
                current.left=null;
                current.right=null;
            }
        }
        
        return result;
    }
}

//time: O(N)
//space: O(N)