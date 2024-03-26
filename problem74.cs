/*

total elements = 12

low=0
high=11
mid=low+high/2 = 5

translate position to index
position=5
row = (position+1)/(totalcols) = 1
col = (position+1) - row*totalcols - 1 = 1
index = 1, 1

position=10
row = 2
col = 2
index=2,2

position=0
row=0
col=0

position=11
row=3
col=-1

position=3
row=1
col=-1

position=4
row=1
col=0

- if col==-1, then row = row-1 and col=totalcols-1


-- convert the 2d matrix into 1d array
-- convert left, right and mid values into 2-D matrix equivivalent indexes
-- continue binary search on the apppropriate half or return false.

*/


public class Solution {
    int totalcols;
    int[][] input;
    public bool SearchMatrix(int[][] matrix, int target) {
        input=matrix;
        totalcols = matrix[0].Length;
        int left=0, right=matrix.Length*totalcols-1;
        int mid = (int)(left+right)/2;
        
        while(left<=right)
        {
            mid = (int)(left+right)/2;
            if(target==GetElement(mid) || target==GetElement(left) || target==GetElement(right))
                return true;
            
            if(target > GetElement(left) && target<GetElement(mid))
                right=mid-1;
            else
                left=mid+1;
        }
        
        
        return false;
    }
    
    public int GetElement(int position)
    {
        int row = (position+1)/(totalcols);
        int col = (position+1) - row*totalcols - 1;
        
        if (col==-1)
        {
            row = row-1;
            col=totalcols-1;
        }
        return input[row][col];
    }
}



//time: O(log(m*n))
//space: O(1)