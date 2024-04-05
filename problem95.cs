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
    Dictionary<(int,int), List<TreeNode>> roots;
    public IList<TreeNode> GenerateTrees(int n) {
        roots = new Dictionary<(int,int), List<TreeNode>>();
        for(int i=0; i<n; i++)
        {
            for(int j=1; j<=(n-i); j++)
            {
                roots.Add((j,j+i), MakeSubTrees(j, j+i));
            }
        }
        return roots[(1,n)];
    }
    
    List<TreeNode> MakeSubTrees(int low, int high)
    {
        List<TreeNode> subtrees = new List<TreeNode>();
        
        if(low>high)
            return new List<TreeNode>();
        
        if(roots.ContainsKey((low, high)))
        {
            return roots[(low, high)];
        }
        
        //Console.WriteLine("Calling {0}, {1}", low, high);
        for(int i=low; i<=high; i++)
        {
            TreeNode root = new TreeNode(i);
            //go for possible left subtrees
            List<TreeNode> leftsubtrees = new List<TreeNode>();
            foreach(TreeNode l in MakeSubTrees(low, i-1))
            {
                TreeNode ls = Clone(root);
                ls.left = Clone(l);
                leftsubtrees.Add(ls);
            }
            
            if(leftsubtrees.Count==0)
            {
                leftsubtrees.Add(root);
            }
            
            List<TreeNode> rightsubtrees = new List<TreeNode>();
            //go for possible right subtrees
            foreach(TreeNode r in MakeSubTrees(i+1, high))
            {
                foreach(TreeNode l in leftsubtrees)
                {
                    TreeNode newroot = Clone(l);
                    newroot.right = Clone(r);
                    rightsubtrees.Add(newroot);
                }
            }
            
            if(rightsubtrees.Count==0)
            {
                subtrees.AddRange(leftsubtrees);
            } else {
                subtrees.AddRange(rightsubtrees);
            }
        }
        
        // Console.WriteLine("BFS Traversal of {0}, {1}", low, high);
        // foreach(TreeNode node in subtrees)
        // {
        //     Console.WriteLine("Root:{0}", node.val);
        //     Traverse(node);
        // }
        
        return subtrees;
    }
    
    TreeNode Clone(TreeNode node)
    {
        if(node==null)
            return null;
        TreeNode newnode = new TreeNode(node.val);
        newnode.left = Clone(node.left);
        newnode.right = Clone(node.right);
        return newnode;
    }
    
//     void Traverse(TreeNode root)
//     {
//         if(root==null)
//             return;
        
//         Queue<TreeNode> queue = new Queue<TreeNode>();
//         queue.Enqueue(root);
        
//         while(queue.Count>0)
//         {
//             Queue<TreeNode> newQueue = new Queue<TreeNode>();
//             Console.WriteLine();
//             while(queue.Count>0)
//             {
//                 TreeNode current = queue.Dequeue();
//                 Console.Write(current.val + "\t");
//                 if(current.left!=null)
//                     newQueue.Enqueue(current.left);
//                 if(current.right!=null)
//                     newQueue.Enqueue(current.right);
//             }
//             queue = newQueue;
//         }
//         Console.WriteLine();
//         return;
//     }
    
}