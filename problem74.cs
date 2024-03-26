/*



*/


public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        foreach(int[] row in matrix)
        {
            if(target>=row[0] && target<=row[row.Length-1])
            {
                foreach(int item in row)
                {
                    if(item == target)
                        return true;
                }
            }
        }
            
        return false;
    }
}

//time: m*Log(n)
//space: O(1)