/*

https://www.geeksforgeeks.org/problems/find-the-number-of-islands/1

*/

//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {

                var ip = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(ip[0]);
                int m = int.Parse(ip[1]);
                char[][] grid = new char[n][];
                for (int i = 0; i < n; i++)
                {
                    grid[i] = new char[m];
                }
                for (int i = 0; i < n; i++)
                {
                    var ipp = Console.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        grid[i][j] = Convert.ToChar(ipp[j]);
                    }
                }
                Solution obj = new Solution();
                var res = obj.numIslands(grid);
                Console.WriteLine(res);
            }
        }
    }
}
// } Driver Code Ends


//User function Template for C#

class Solution
{
    //Complete this function
    //Function to find the number of islands.
    char[][] grid;
    int maxRow=0;
    int maxCol=0;
    public int numIslands(char[][] grid)
    {
        //Your code here
        //count the number of disjoint sets
        int result=0;
        this.grid = grid;
        this.maxRow = grid.Length;
        this.maxCol = grid[0].Length;
        
        for(int i=0; i<grid.Length; i++)
        {
            for(int j=0; j<grid[0].Length; j++)
            {
                if(this.grid[i][j]=='1')
                {
                    // Console.WriteLine("{0}, {1}, {2}", i, j, result);
                    Dfs(i, j);
                    result++;
                }
            }
        }
        return result;
    }
    
    public void Dfs(int row, int col)
    {
        if(row<0 || col<0 || row>=maxRow || col >= maxCol)
        {
            return;
        }
        
        if(grid[row][col] != '1')
            return;
        
        // Console.WriteLine("{0}, {1}, :{2}", row, col, grid[row][col]);
        
        grid[row][col] = '2';    
        
        Dfs(row+1, col);
        Dfs(row-1, col);
        Dfs(row, col+1);
        Dfs(row, col-1);
        Dfs(row+1, col+1);
        Dfs(row+1, col-1);
        Dfs(row-1, col+1);
        Dfs(row-1, col-1);
        return;
    }
}

//time: O(MN)
//space: O(M+N)