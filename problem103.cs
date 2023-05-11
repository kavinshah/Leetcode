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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if(root==null)
            return new List<IList<int>>();
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        bool order=true;
        IList<IList<int>> result= new List<IList<int>>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            int counter=queue.Count;
            List<int> currentLevel=new List<int>();
            while(counter>0)
            {
                TreeNode node = queue.Dequeue();
                currentLevel.Add(node.val);
                if(node.left!=null)
                    queue.Enqueue(node.left);
                if(node.right!=null)
                    queue.Enqueue(node.right);
                counter--;
            }
            
            if(order)
            {
                result.Add(currentLevel);
            }
            else
            {
                currentLevel.Reverse();
                result.Add(currentLevel);
            }
            order=!order;
        }
        return result;
    }
}

//time: O(N)
//space: O(N)