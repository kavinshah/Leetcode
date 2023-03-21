public class Solution {
    public bool CheckValidGrid(int[][] grid) {
        //simple graph traversal on each direction
        int nextrow=0;
        int nextcol=0;
        int maxRow=grid.Length;
        int maxCol=grid[0].Length;
        int currentVal=1;
        int maxVal=maxRow*maxRow;
        
        if(grid[0][0] != 0)
            return false;
        
        while(currentVal<maxVal)
        {
            if((nextrow-1)>=0 && (nextcol-2)>=0 && grid[nextrow-1][nextcol-2] == currentVal)
            {
                currentVal++;
                nextrow=nextrow-1;
                nextcol=nextcol-2;
            }
            else if ((nextrow-2)>=0 && (nextcol-1)>=0 && grid[nextrow-2][nextcol-1] == currentVal)
            {
                currentVal++;
                nextrow=nextrow-2;
                nextcol=nextcol-1;
            }
            else if((nextrow-2)>=0 && (nextcol+1)<maxCol && grid[nextrow-2][nextcol+1] == currentVal)
            {
                currentVal++;
                nextrow=nextrow-2;
                nextcol=nextcol+1;
            }
            else if ((nextrow-1)>=0 && (nextcol+2)<maxCol && grid[nextrow-1][nextcol+2] == currentVal)
            {
                currentVal++;
                nextrow=nextrow-1;
                nextcol=nextcol+2;
            }
            else if((nextrow+1)<maxRow && (nextcol-2)>=0 && grid[nextrow+1][nextcol-2] == currentVal)
            {
                currentVal++;
                nextrow=nextrow+1;
                nextcol=nextcol-2;
            }
            else if((nextrow+2)<maxRow && (nextcol-1)>=0 && grid[nextrow+2][nextcol-1] == currentVal)
            {
                currentVal++;
                nextrow=nextrow+2;
                nextcol=nextcol-1;
            }
            else if((nextrow+2)<maxRow && (nextcol+1)<maxCol && grid[nextrow+2][nextcol+1] == currentVal)
            {
                currentVal++;
                nextrow=nextrow+2;
                nextcol=nextcol+1;
            }
            else if((nextrow+1)<maxRow && (nextcol+2)<maxCol && grid[nextrow+1][nextcol+2] == currentVal)
            {
                currentVal++;
                nextrow=nextrow+1;
                nextcol=nextcol+2;
            }
            else
            {
                //Console.WriteLine("{0},{1},{2}", currentVal, nextrow, nextcol);
                return false;
            }
        }
        
        return true;
    }
}

/*
[[24,11,22,17, 4],
 [21,16, 5,12, 9],
 [6, 23,10, 3,18],
 [15,20, 1, 8,13],
 [0,  7,14,19, 2]]
 
 [[8,3,6],
  [5,0,1],
  [2,7,4]]
 
*/

//time: O(N^2)
//space: O(1)