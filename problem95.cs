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

n=1

1
 = 1

n=2

     1                       2
     \                     /
     2                    1
 = 2

n=3

      1                              1
       \                              \
        2                              3
         \                            /
          3                          2

                        2
                    /       \
                   1          3

          3                               3
        /                                /
        1                               2
          \                           /
           2                         1

1   2   3
1,2                
                    1                          2
                     \                        /
                      2                      1

2,3
                    2                           3              
                     \                         /
                      3                       2

3,4
                    3                       4
                     \                     /
                      4                   3

1,2,3

                    1                       1
                     \                       \
                      2                       3
                       \                     /
                        3                   2

                                    2
                                  /   \             
                                 1     3

                    3                           3
                   /                           /
                  2                           1
                 /                             \ 
                1                               2

2,3,4

            2                               2
             \                               \
              3                               4
               \                             /
                4                           3

                                3
                            /       \
                            2       4

            4                       4
           /                       /
          2                       3
           \                     /
            3                   2

1,2,3,4

            1
             \
             5 subtrees (2,3,4)
             
             2
            /  \
           1    2 such subtrees (3,4)
           
                       3
                     /   \
    2 subtrees (1,2)      4

                        4
                       /
                      5 such subtrees (1,2,3)
        
*/

public class Solution {
    
    public IList<TreeNode> GenerateTrees(int n) {
        return GenerateTrees(1, n);
    }
    
    List<TreeNode> GenerateTrees(int low, int high)
    {
        List<TreeNode> result = new List<TreeNode>();
        
        if(low>high)
        {
            result.Add(null);
            return result;
        }
            
        
        for(int i=low; i<=high; i++)
        {
            List<TreeNode> leftsubtrees = GenerateTrees(low, i-1);
            List<TreeNode> rightsubtrees = GenerateTrees(i+1, high);
            
            foreach(TreeNode l in leftsubtrees)
            {
                foreach(TreeNode r in rightsubtrees)
                {
                    TreeNode node = new TreeNode(i);
                    node.left = l;
                    node.right = r;
                    result.Add(node);
                }
            }
        }
        return result;
    }
}

//time: O(4^N/sqrt(N))
//Space: O((N-K+1)*4^K/sqrt(K))