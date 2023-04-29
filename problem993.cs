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
    int depthX=-1, depthY=-1;
    TreeNode parentX, parentY;
    Queue<(TreeNode, int, TreeNode)> q;
    public bool IsCousins(TreeNode root, int x, int y) {
        q= new Queue<(TreeNode,int, TreeNode)>();
        q.Enqueue((root,0, null));
        
        while(q.Count>0)
        {
            (TreeNode,int, TreeNode) item = q.Dequeue();
            
            if(item.Item1.val==x)
            {
                depthX=item.Item2;
                parentX=item.Item3;
            }
            else if(item.Item1.val==y)
            {
                depthY=item.Item2;
                parentY=item.Item3;
            }
            
            if(depthX!=-1 && depthY!=-1)
                break;
            
            if((depthX!=-1 && item.Item2>depthX)
               || (depthY!=-1 && item.Item2>depthY))
                continue;
            
            if(item.Item1.left!=null)
                q.Enqueue((item.Item1.left,item.Item2+1, item.Item1));
            
            if(item.Item1.right!=null)
                q.Enqueue((item.Item1.right,item.Item2+1, item.Item1));
        }
        // Console.WriteLine(depthX);
        // Console.WriteLine(depthY);
        return depthX==depthY && parentX!=parentY;
    }
}

//Time: O(N)
//space: O(N)