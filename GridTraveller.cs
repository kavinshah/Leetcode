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
        Test(2,3);
        Test(3,3);
        Test(18, 18);
    }
    
    public static void Test(int row, int col)
    {
        GridTraveller s = new GridTraveller(row, col);
        Console.WriteLine(s.Travel(0, 0));
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
            for(int j=0; j<col; j++)
            {
                this.dp[i][j] = -1;
            }
        }
    }
    
    public long Travel(int row, int col)
    {
        if(row == maxRow && col == maxCol)
        {
            return 1;
        }
        
        if(row > maxRow || col > maxCol)
        {
            return 0;
        }
        
        if(dp[row][col] != -1)
        {
            return dp[row][col];
        }
        
        dp[row][col] = Travel(row+1, col) + Travel(row, col+1);
        return dp[row][col];
    }
}

//time: O(MN)
//Space: O(MN)