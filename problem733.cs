/*

Take care of the edge case :-
when color is same as image[sr][sc]

*/

public class Solution {
    int[][] result;
    int startColor, targetColor;
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        if(color == image[sr][sc])
            return image;
        
        this.result = image;
        this.startColor = image[sr][sc];
        this.targetColor = color;
        
        Dfs(sr, sc);
        return result;
    }
    
    public void Dfs(int row, int col)
    {
        result[row][col] = targetColor;
        
        if((row+1)<result.Length && result[row+1][col] == startColor)
            Dfs(row+1, col);
        
        if((row-1)>=0 && result[row-1][col] == startColor)
            Dfs(row-1, col);
        
        if((col+1)<result[0].Length && result[row][col+1] == startColor)
            Dfs(row, col+1);
        
        if((col-1)>=0 && result[row][col-1] == startColor)
            Dfs(row, col-1);
        
    }   
}

//Time: O(MN)
//Space: O(M+N)