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
    public IList<int> PostorderTraversal(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        IList<int> result = new List<int>();
        
        if(root==null)
            return result;
        
        stack.Push(root);
        if(root.right!=null)
            stack.Push(root.right);
        if(root.left!=null)
            stack.Push(root.left);
        
        root.right=null;
        root.left=null;
        //Console.WriteLine(stack.Count);

        while(stack.Count>0)
        {
            TreeNode current = stack.Pop();
            if(current.left==null && current.right==null)
                result.Add(current.val);
            else
            {
                stack.Push(current);
                if(current.right!=null)
                    stack.Push(current.right);
                if(current.left!=null)
                    stack.Push(current.left);
                current.right=null;
                current.left=null;
            }
            
            //Console.WriteLine(stack.Count);
        }        
        return result;
    }
}

//using iteration
//Time: O(N)
//Space: O(N)
