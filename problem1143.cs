/*


    a   b   c   d   e

a   1   1   1   1   1
c   1   1   2   2   2
e   1   1   1   1   3
    
    0 1 2 3 4 5 6 7 8
    j m j k b k j k v
    0 0 0 0 0 0 0 0 0
b 0 0 0 0 0 1 1 1 1 1 0
s 0 0 0 0 0 1 1 1 1 1 1
b 0 0 0 0 0 1 1 1 1 1 2
i 0 0 0 0 0 1 1 1 1 1 3
n 0 0 0 0 0 1 1 1 1 1
i 0 0 0 0 0 1 1 1 1 1
n 0 0 0 0 0 1 1 1 1 1
m 0 0 1 1 1 1 1 1 1 1

                                    0,0
                            /                                   \
                        1+(1,1)--3                              1,0
                /                                 \
            1,2--1                                  2,1 -- 2
        /       \               /                           \
    1,3         2,2           1+(2,2) --2                  1+(3,1) -- 2
    |         /    \           /    \                       /       \
    0       2,3     3,2       2,3   3,2   --1              3,2        4,1  
            |       /   \       |   /   \               /   \       /   \
            0      3,3  4,2--1  0   3,3 4,2             3,3   4,2   4,2 5,1
                    |   /      \      |  /      \         |     |   |    |
                    0 1+(4,3) 1+(5,2) 0 1+(4,3) 1+(5,3)   0     1   1    0
                        |       |          |       |
                        0       0          0       0
                        
*/

public class Solution {
    int[][] dp;
    string text1, text2;
    public int LongestCommonSubsequence(string text1, string text2) {
        this.text1 = text1;
        this.text2 = text2;
        dp = new int[text1.Length][];
        for(int i=0; i<text1.Length; i++)
            dp[i]= Enumerable.Repeat(-1, text2.Length).ToArray();
        
        FindLongestCommonSubsequence(0,0);
        
        // for(int i=0; i<text1.Length; i++)
        //     Console.WriteLine(String.Join(",", dp[i]));
        
        return dp[0][0];
    }
    
    public int FindLongestCommonSubsequence(int index1, int index2){
        if(index1>=text1.Length || index2>=text2.Length){
            return 0;
        }
        
        if(dp[index1][index2]!=-1)
            return dp[index1][index2];
        
        int left,right;
        
        if(text1[index1] == text2[index2]){
            dp[index1][index2] = 1+FindLongestCommonSubsequence(index1+1, index2+1);
        }
        else{
            left = FindLongestCommonSubsequence(index1+1, index2);
            right = FindLongestCommonSubsequence(index1, index2+1);
            dp[index1][index2] = Math.Max(left, right);
        }
        return dp[index1][index2];
    }
    
}

//time: O(MN)
//space: O(MN+M+N) -- O(M+N) for the recursive stack and O(MN) for the dp storage