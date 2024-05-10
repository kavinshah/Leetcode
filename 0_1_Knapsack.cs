//https://www.geeksforgeeks.org/problems/0-1-knapsack-problem0945/1
//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Numerics;
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
                int[] val = new int[N];
                int[] wt = new int[N];
                int K = Convert.ToInt32(Console.ReadLine());
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                val = Array.ConvertAll(elements.Split(), int.Parse);
                elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                wt = Array.ConvertAll(elements.Split(), int.Parse);
                Solution obj = new Solution();
                int res = obj.knapSack(K,wt,val, N);
                Console.Write(res+"\n");
          }

        }
    }
}

// } Driver Code Ends


//User function Template for C#

/*
n=3
w=4
v = 1   2   3
w = 4   5   1

v/w

1   2   4   5
5   4   8   6

1   4   
5   8

w=5
w = 1   2   4   5
v = 5   4   8   6

                            0,0,0
                        /     |     \
                    1,1,5   2,2,4   3,4,8
                /   |   \   
            2,3,9 3,5,1 x
        /   |   \   
    x       x   x

    1   2   4   5
5   
4
8
6



*/

class Solution
    {
        //Complete this function
        int[][] dp;
        int[] wt, val;
        public int knapSack(int W, int[] wt, int[] val,int n)
        {
            //Your code here
            this.wt=wt;
            this.val=val;
            this.dp = new int[n][];
            
            for(int i=0; i<n;i++){
                this.dp[i]=new int[W+1];
                for(int j=0; j<W+1; j++)
                    dp[i][j]=-1;
            }
            
            FindMaxValue(n-1, W);
            
            // for(int i=0; i<n; i++)
            //     Console.WriteLine(String.Join(",", dp[i]));
                
            return dp[n-1][W];
        }
        
        public int FindMaxValue(int index, int currentWeight){
            if(index==0){
                if(currentWeight>=wt[0])
                    dp[index][currentWeight] = val[0];
                else
                    dp[index][currentWeight] = 0;
                return dp[index][currentWeight];
            }
            
            if(dp[index][currentWeight] != -1)
                return dp[index][currentWeight];
            
            int taken = 0;
            int notTaken=FindMaxValue(index-1, currentWeight);
            if(currentWeight>=wt[index])
                taken = val[index] + FindMaxValue(index-1, currentWeight-wt[index]);
            dp[index][currentWeight] = Math.Max(taken, notTaken);
            return dp[index][currentWeight];
        }
    }
	
//time : O(NW)
//Space: O(NW)
