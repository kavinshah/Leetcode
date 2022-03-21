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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        if(root==null)
            return new List<IList<int>>();
        
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count!=0)
        {
            int counter=queue.Count;
            List<int> level = new List<int>();
            for(int i=0; i<counter; i++)
            {
                TreeNode current = queue.Dequeue();
                if(current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    queue.Enqueue(current.right);
                }
                level.Add(current.val);
            }
            result.Add(level);
        }
        
        return result;
    }
}