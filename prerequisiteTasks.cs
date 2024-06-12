/*

https://www.geeksforgeeks.org/problems/prerequisite-tasks/1?itm_source=geeksforgeeks&itm_medium=article&itm_campaign=bottom_sticky_on_article

Using Topological Sort

Time: O(V+E)
Space: O(V+E)

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
                int N = Convert.ToInt32(Console.ReadLine());
                int P = Convert.ToInt32(Console.ReadLine());
                var prerequisites = new List<Tuple<int, int>>();
                for (int i = 0; i < P; i++)
                {
                    var ip = Console.ReadLine().Trim().Split(' ');
                    prerequisites.Add(new Tuple<int, int>(Convert.ToInt32(ip[0]), Convert.ToInt32(ip[1])));
                }
                Solution obj = new Solution();
                var res = obj.isPossible(N, P, prerequisites);
                if(res == true){
                    Console.Write("Yes");
                }
                else{
                    Console.Write("No");
                }
                Console.Write("\n");
            }
        }
    }
}
// } Driver Code Ends


//User function Template for C#

class Solution
{
	//Complete this function
	List<List<int>> adj;
	HashSet<int> visited;
	public bool isPossible(int N,int P, List<Tuple<int, int>> prerequisites)
	{
		//Your code here
		visited = new HashSet<int>();
		adj = new List<List<int>>();
		
		for(int i=0; i<N; i++)
			adj.Add(new List<int>());
		
		foreach(Tuple<int, int> t in prerequisites)
		{
			adj[t.Item2].Add(t.Item1);
		}
		
		//check for cycles
		for(int i=0; i<N; i++)
		{
			if(!visited.Contains(i))
			{
				visited.Add(i);
				if(CheckCycles(i, new HashSet<int>(){i}))
				{
					//Console.WriteLine("printing false: {0}", i);
					return false;
				}
			}
		}
		return true;
	}
	
	public bool CheckCycles(int node, HashSet<int> path)
	{
		foreach(int n in adj[node])
		{
			
			if(path.Contains(n)){
				return true;
			}
			
			if(!visited.Contains(n))
			{
				path.Add(n);
				if(CheckCycles(n, path)){
					//Console.WriteLine("printing false: {0}", n);
					return true;
				}
				path.Remove(n);
			}
		}
		
		visited.Add(node);
		return false;
	}
	
}