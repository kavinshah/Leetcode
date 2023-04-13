/*


n=3

d(2) = root(1) + root(2)
     = d[0]*d[1] + d[1]*d[0]
     = 1*1 + 1*1
     = 1+1
     = 2


d(3) = root(3) + roo(2) + root(1)
     = (d[2]*d[0]) + (d[1]*d[1]) + (d[0]*d[2])
     = 2*1 + 1*1 + 1*2
     = 2 + 1 + 2
     = 5
     
d(4) = root(1) + root(2) + root(3) + root(4)
     = d[0]*d[3] + d[1]*d[2] + d[2]*d[1] + d[3]*d[0]
     = 1*5 + 1*2 + 2*1 + 5*1
     = 5+2+2+5
     = 14

F(5) = root(5) + root(4) + root(3) + root(2) + root(1)
     = d[4]*d[0] + d[3]*d[1] + d[2]*d[2] + d[1]*d[3] + d[0]*d[4]
     = 14*1 + 5*1 + 2*2 + 1*5 + 1*14
     = 14+5+4+5+14
     = 19+4+19
     = 42
            
** this is a palindrome


*/

public class Solution {
    public int NumTrees(int n) {
        int[] map = new int[n+1];
        map[0]=1;
        map[1]=1;
        
        for(int i=2; i<=n; i++) // this loop calculates for number of nodes
        {
            for(int j=1; j<=i; j++) // this loop add the number of combination for each root
            {
                map[i]+=map[j-1]*map[i-j];
            }
        }
        
        return map[n];
    }
    
}

//time: O(N^2)
//space: O(N)