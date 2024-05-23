/*

https://www.youtube.com/watch?v=oBt53YbR9Kk&t=5418s

Given a 2D grid, return the number of ways to travel from top left to bottom right corner.
You can only travel in right or down direction.

*/
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

/*

Given a 2D grid, return the number of ways to travel from top left to bottom right corner.
You can only travel in right or down direction.

*/
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Test(1,1);
        Test(2,3);
        Test(3,2);
        Test(3,3);
        Test(18, 18);
    }
    
    public static void Test(int row, int col)
    {
        GridTraveller s = new GridTraveller(row, col);
        Console.WriteLine(s.Travel());
    }
}

public class GridTraveller
{
    int maxRow, maxCol;
    long[][] dp;
    
    public GridTraveller(int row, int col)
    {
        this.maxRow = row-1;
        this.maxCol = col-1;
        this.dp = new long[row][];
        
        for(int i=0; i<row; i++)
        {
            this.dp[i] = new long[col];
        }
        this.dp[0][0]=1;
    }
    
    public long Travel()
    {
        for(int i=0; i<=maxRow; i++)
        {
            for(int j=0; j<=maxCol; j++)
            {
                if((i+1) <= maxRow)
                {
                    dp[i+1][j] += dp[i][j];
                }
                
                if((j+1) <= maxCol)
                {
                    dp[i][j+1] += dp[i][j];
                }
            }
        }
        
        return dp[maxRow][maxCol];
    }
}

//time: O(MN)
//Space: O(MN)