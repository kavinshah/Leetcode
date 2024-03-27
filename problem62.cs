/*


2,2

0   0 
0   0

1
1


3,3

0   0   0
0   0   0
0   0   0

stack=[(0,0)]
stack=[(0,1)]
stack=[(0,2)]
stack=[(1,2)]
stack=[(2,2)] -- 1
stack=[(1,1)]
stack=[(1,2)]
stack=[(2,2)] -- 2
stack=[(2,1)]
stack=[(2,2)] -- 3

                            0,0
                    /                   \ 
                    0,1                 1,0
            /               \           /       \
            0,2             1,1       1,1       2,1
            /   \           /   \     / \        |
            x   1,2        1,2  2,1  1,2 2,1    2,2
                /   \       |    |    |    |    |
                x   2,2     2,2  2,2  2,2   2,2  1
                    |        |   |    |     |
                    1        1   1    1     1





*/


public class Solution {
    int maxRow, maxCol;
    int[][] memoization;
    public int UniquePaths(int m, int n) {
        maxRow = m-1;
        maxCol = n-1;
        memoization = new int[m][];
        for(int i=0; i<m; i++)
        {
            memoization[i] = new int[n];
            for(int j=0; j<n; j++)
                memoization[i][j]=-1;
        }
        return CalculatePaths(0,0);
    }
    
    public int CalculatePaths(int row, int col)
    {
        if(row==maxRow && col==maxCol)
            return 1;
        
        if(row > maxRow || col > maxCol)
            return 0;
        
        if(memoization[row][col] != -1)
            return memoization[row][col];
        
        memoization[row][col] = CalculatePaths(row, col+1) + CalculatePaths(row+1, col);
        return memoization[row][col];        
    }
}

//Time: O(M*N)
//Space: O(M*N)