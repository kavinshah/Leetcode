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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> sequence1=new List<int>();
        List<int> sequence2=new List<int>();
        
        Dfs(root1, sequence1);
        Dfs(root2, sequence2);
        
//         Console.WriteLine("Sequence 1");
//         foreach(int val in sequence1)
//             Console.Write(val+"\t");
        
//         Console.WriteLine("\nSequence 2");
//         foreach(int val in sequence2)
//             Console.Write(val+"\t");
        
        if(sequence1.Count != sequence2.Count)
            return false;
        
        for(int i=0; i<sequence1.Count; i++)
        {
            if(sequence1[i]!=sequence2[i])
                return false;
        }
        
        return true;
        
    }
    
    public void Dfs(TreeNode node, List<int> currentSequence)
    {
        if(node==null)
        {
            return;
        }
        
        if(node.left==null && node.right==null)
        {
            currentSequence.Add(node.val);
        }
        
        Dfs(node.left, currentSequence);
        Dfs(node.right, currentSequence);
    }
}

//time: O(N+M)
//space: O(M+N)