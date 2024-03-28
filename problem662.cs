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
 
1 3 2 5 3 null 9
0 1 2 3 4 5    6
 
1 3 2 5 null null 9    6   null     null    null null  null     7
0 1 2 3 4      5  6    7   8           9   10      11  12      13
 
13-7+1=7
 
 
*/

public class Solution {
    Dictionary<int, int> minLevel, maxLevel;
    public int WidthOfBinaryTree(TreeNode root) {
        minLevel = new Dictionary<int,int>();
        maxLevel = new Dictionary<int,int>();
        int maxDistance=1;
        
        Traverse(root, 0, 0);
        
        foreach(var kvp in minLevel)
        {
            if(maxLevel.ContainsKey(kvp.Key))
                maxDistance = Math.Max(maxDistance, maxLevel[kvp.Key] - minLevel[kvp.Key] + 1);
        }
        
        return maxDistance;
    }
    
    void Traverse(TreeNode node, int level, int index)
    {
        if(node==null)
            return;
        
        if(!minLevel.ContainsKey(level))
        {
            minLevel.Add(level, index);
        }
        else
        {
            maxLevel[level] = index;
        }
        
        if(node.left!=null)
            Traverse(node.left, level+1, index*2+1);
        
        if(node.right!=null)
            Traverse(node.right, level+1, index*2+2);
        
        return;
    }
}

//time: O(N)
//Space: O(logN)