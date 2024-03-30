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
 
 length=5, 5/2=2
 length=6, 6/2=3
 
 nums=[-10,-3,0,5,9]
                    0, 4, mid=5/2=2, root=0
                    /                   \
    low=0, high=1, mid=0, -10       low=3, high=4, mid=3, 5
    /               \                       /    \
0,-1,           1,1,1,-3            3,2            4,4, mid=4, 9
 
 
 
 */

public class Solution {
    int[] nums;
    public TreeNode SortedArrayToBST(int[] nums) {
        this.nums=nums;
        return Traverse(0, nums.Length-1, null);
    }
    
    TreeNode Traverse(int low, int high, TreeNode root)
    {
        int mid = (int)(low+high)/2;
        TreeNode next=null;
        
        if(low>high)
            return root;
        
        if(root==null)
        {
            root = new TreeNode(nums[mid]);
            next = root;
        }
        else if(root.val > nums[mid])
        {
            root.left = new TreeNode(nums[mid]);
            next=root.left;
        }
        else
        {
            root.right = new TreeNode(nums[mid]);
            next=root.right;
        }
        
        Traverse(low, mid-1, next);
        Traverse(mid+1, high, next);
        
        //Console.WriteLine("{0}, {1}, {2}, {3}", low, high, mid, root.val);
        
        return root;
    }
}

//Time: O(N)
//space: O(N)
