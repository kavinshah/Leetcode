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
 
                3
            /       \
            1       4
        /       \
        0       2
        
     if root>high:
        make left as root
    else if root<low:
        make right as root
        
        
                        3
                    /       \
                    1       4
                /       \
                0       2

if current==null
    return

trim root:
    -> if current.val>high:
        => current.val=current.left.val
        => temp=current.left
        => current.left = temp.left
        => current.right = temp.right
        => recurse on current
        
    ->else if current.val<low:
        => current.val=current.right.val
        => temp=current.right
        => current.left=temp.left
        => current.right=temp.right
        => recurse on current
        
trim left node:
if current.left.val<low:
    -> make current.left=current.left.right
    //-> recurse on current.left node.
    
trim right node:
if current.right.val>high:
    -> make current.right=current.right.left
    //-> recurse on current.right node

recurse current.left
recurse current.right
 
 
 */
public class Solution {
    int high,low;
    public TreeNode TrimBST(TreeNode root, int low, int high) {
        this.low=low;
        this.high=high;
        root=Trim(root);
        return root;
    }
    
    public TreeNode Trim(TreeNode node)
    {
        if(node==null)
            return null;
        
        if(node.val<low)
        {
            if(node.right==null)
                return null;
            
            TreeNode temp=node.right;
            node.val=temp.val;
            node.left=temp.left;
            node.right=temp.right;
            node=Trim(node);
        }
        else if(node.val>high)
        {
            if(node.left==null)
                return null;
            
            TreeNode temp=node.left;
            node.val=temp.val;
            node.left=temp.left;
            node.right=temp.right;
            node=Trim(node);
        }
        if(node?.left!=null)
            node.left=Trim(node.left);
        if(node?.right!=null)
            node.right=Trim(node.right);
        return node;
    }   
}

//Time: O(N)
//space: O(N)