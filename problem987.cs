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
    SortedDictionary<int, SortedDictionary<int, List<int>>> traversalLevels;
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        traversalLevels = new SortedDictionary<int, SortedDictionary<int, List<int>>>();
        Traverse(root, 0, 0);
        
        foreach(var horizontalLevel in traversalLevels)
        {
            List<int> level = new List<int>();
            foreach(var kvp in horizontalLevel.Value)
            {
                kvp.Value.Sort();
                level.AddRange(kvp.Value);
            }
            result.Add(level);
        }
        
        return result;
    }
    
    public void Traverse(TreeNode node, int verticalLevel, int horizontalLevel)
    {
        if(node==null)
            return;
        
        if(!traversalLevels.ContainsKey(horizontalLevel))
        {
            traversalLevels[horizontalLevel] = new SortedDictionary<int, List<int>>();
        }
        
        if(!traversalLevels[horizontalLevel].ContainsKey(verticalLevel))
        {
            traversalLevels[horizontalLevel][verticalLevel] = new List<int>();
        }
        
        traversalLevels[horizontalLevel][verticalLevel].Add(node.val);
        
        if(node.left!=null)
            Traverse(node.left, verticalLevel+1, horizontalLevel-1);
        if(node.right!=null)
            Traverse(node.right, verticalLevel+1, horizontalLevel+1);
        return;
    }
}

//time: O(N)
//space: O(N)