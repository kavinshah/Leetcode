/*

[1,1,0] => [0,1,1] => [1,0,0]

*/


public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int[][] result = new int[image.Length][];
        
        for(int i=0; i<image.Length; i++)
        {
            result[i]=new int[image.Length];
            int max=image.Length-1;
            for(int j=0; j<image.Length; j++)
            {
                if(image[i][max-j] == 1)
                    result[i][j]=0;
                else
                    result[i][j]=1;
            }
        }
        
        return result;
    }
}

//time: O(N^2)
//space: O(1)