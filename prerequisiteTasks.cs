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
	public bool isPossible(int N,int P, List<Tuple<int, int>> prerequisites)
	{
		//Your code here
		int[] indegree = new int[N];
		Queue<int> queue = new Queue<int>();
		HashSet<int> visited = new HashSet<int>();
		List<List<int>> adj = new List<List<int>>();
		
		for(int i=0; i<N; i++)
			adj.Add(new List<int>());
		
		foreach(Tuple<int, int> t in prerequisites)
		{
			indegree[t.Item1]++;
			adj[t.Item2].Add(t.Item1);
		}
		
		for(int i=0; i<N; i++)
		{
			if(indegree[i]==0 && !visited.Contains(i))
			{
				queue.Enqueue(i);
				visited.Add(i);
			}
		}
		
		while(queue.Count>0)
		{
			int current = queue.Dequeue();
			
			foreach(int n in adj[current])
			{
				indegree[n] -= 1;
				if(indegree[n]==0 && !visited.Contains(n))
				{
					queue.Enqueue(n);
					visited.Add(n);
				}
			}
			
			if(visited.Count == N)
				return true;
			
		}
		
		return visited.Count==N;
		
		
		
	}
}