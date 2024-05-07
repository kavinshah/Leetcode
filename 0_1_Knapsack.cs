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

*/

class Solution
    {
        //Complete this function
        int maxValue;
        int[] wt, val;
        int W;
        public int knapSack(int W, int[] wt, int[] val,int n)
        {
            //Your code here
            this.wt=wt;
            this.val=val;
            this.W = W;
            FindMaxValue(0, 0, 0);
            return maxValue;
        }
        
        public void FindMaxValue(int index, int currentWeight, int currentValue){
            if(index>=val.Length){
                return;
            }
            
            for(int i=index; i<wt.Length; i++){
                if((currentWeight+wt[i])>W){
                    continue;
                }
                
                maxValue=Math.Max(maxValue, currentValue+val[i]);
                FindMaxValue(i+1, currentWeight+wt[i], currentValue+val[i]);
            }
            
            return;
        } 
        
    }