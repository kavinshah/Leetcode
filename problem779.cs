/*

                       0
                /           \
                0            1
             /    \      /       \
            0      1     1        0
          /  \    /  \  / \    /   \
         0    1   1  0  1  0   0    1
         |    |   |  |  |  |   |    |
         01   10  10 01 10 01 01   10

n=2, k=3 (2)
n(2) = n(1)*2 -- 2>>1 = 1+1-1 = 1
n(1) = n(0) 1>>2 = 0, 1%2=1, 

n[0]=0
n[1]=1
n[2]=0


                                0 ==> "01" (0,1)                    => (0, 0, 1)=1
                        /               \
                       0*2+0                 0*2+1                  => (1, 1, 1)=0
                    /       \            /         \
                 0*2+0       0*2+1    1*2+0        1*2+1            => (2, 3, 0)=0
                /   \       /   \      /  \        /    \
            0*2+0  0*2+1 1*2+0 1*2+1 2*2+0 2*2+1  3*2+0 3*2+1       => (3, 6, 0)=0

n=3, k=7
3,6,0 => 
2,3,0 => 0
1,1,1 => 0
0,0,1 => 1

*/


public class Solution {
    public int KthGrammar(int n, int k) {
        char result = CalculateGrammar(n-1, k-1, 0);
        //Console.WriteLine("{0},{1},{2}:{3}", n-1, k-1, 0, result);
        return result-'0';
    }
    
    public char CalculateGrammar(int n, int row, int col)
    {
        if(n==0)
            return "01"[col];
        
        char result = CalculateGrammar(n-1, (int)(row/2), row%2);
        //Console.WriteLine("{0},{1},{2}:{3}", n-1, (int)(row/2), row%2, result);
        if(result=='1')
            return "10"[col];
        else
            return "01"[col];
    }
}

//time: O(N)
//space:  O(N) --recursive call stack