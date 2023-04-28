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


*/
public class Solution {
    Queue<(TreeNode,int)> q, tempQ;
    public int WidthOfBinaryTree(TreeNode root) {
        int res=0;
        q=new Queue<(TreeNode,int)>();
        q.Enqueue((root, 0));
        
        while(q.Count>0)
        {
            tempQ=new Queue<(TreeNode,int)>(q);
            q=new Queue<(TreeNode,int)>();
            res = Math.Max(res, tempQ.ElementAt(tempQ.Count-1).Item2-tempQ.ElementAt(0).Item2+1);
            //Console.WriteLine("Res:" + res);
            while(tempQ.Count>0)
            {
                (TreeNode, int) current=tempQ.Dequeue();
                if(current.Item1.left!=null)
                {
                    //Console.WriteLine($"{current.Item1}, {current.Item2*2+1}");
                    q.Enqueue((current.Item1.left, current.Item2*2+1));
                }
                
                if(current.Item1.right!=null)
                {
                    //Console.WriteLine($"{current.Item1}, {current.Item2*2+2}");
                    q.Enqueue((current.Item1.right, current.Item2*2+2));
                }
            }
        }
        return res;
    }
}

//Time: O(N)
//Space: O(N)