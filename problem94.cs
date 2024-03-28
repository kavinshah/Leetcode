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
        
        IList<int> result = new List<int>();
        TreeNode curr = root;
        
        while(curr != null)
        {
            if(curr.left==null)
            {
                result.Add(curr.val);
                curr=curr.right;
            }
            else
            {
                TreeNode prev = curr.left;
                while(prev.right!=null && prev.right!=curr)
                {
                    prev=prev.right;
                }
                
                if(prev.right==null)
                {
                    prev.right=curr;
                    curr=curr.left;
                }
                else
                {
                    prev.right=null;
                    result.Add(curr.val);
                    curr=curr.right;
                }
            }
        }
        return result;
    }
}

//Morris Inorder Traversal
//time: O(N)
//space: O(1)