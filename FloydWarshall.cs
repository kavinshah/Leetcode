//{ Driver Code Starts
//Initial Template for C#
/*

https://www.geeksforgeeks.org/problems/implementing-floyd-warshall2042/1

*/

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
                int N = Convert.ToInt32(Console.ReadLine());
                List<List<int>> matrix = new List<List<int>>();
                for (int i = 0; i < N; i++)
                {
                    matrix.Add(new List<int>());
                }
                for (int i = 0; i < N; i++)
                {
                    var elements = Console.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i].Add(int.Parse(elements[j]));
                    }
                }
                Solution obj = new Solution();
                obj.shortest_distance(matrix);
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(matrix[i][j] + " ");
                    }
                    Console.Write("\n");
                }
            }

        }
    }


}
// } Driver Code Ends


//User function Template for C#

class Solution
    {
        //Complete this Function
        public void shortest_distance(List<List<int>> matrix)
        {
            // Your code here
            //int INF = int.MaxValue; //initialize INF as maximum integer value.
            int n = matrix.Count; //get the size of the matrix.
    
            //replace all -1 with INF in the matrix.
            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    if(matrix[i][j] == -1)
                        matrix[i][j] = Int32.MaxValue;
                }
            }
    
            //perform Floyd-Warshall algorithm to find shortest distances.
            for (int k = 0; k < n; ++k) {
                for (int i = 0; i < n; ++i) {
                    for (int j = 0; j < n; ++j) {
                        if (matrix[i][k] != Int32.MaxValue && matrix[k][j] != Int32.MaxValue 
                        && (matrix[i][k] + matrix[k][j]) < Int32.MaxValue)
                            matrix[i][j] = Math.Min(matrix[i][j], matrix[i][k] + matrix[k][j]); 
                    }
                }
            }
    
            //replace all INF with -1 in the matrix.
            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    if(matrix[i][j] >= Int32.MaxValue)
                        matrix[i][j] = -1;
                }
            }
        }
    }