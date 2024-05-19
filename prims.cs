//{ Driver Code Starts
//Initial Template for C#

//https://www.geeksforgeeks.org/problems/minimum-spanning-tree/1

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
                int V = int.Parse(ip[0]);
                int E = int.Parse(ip[1]);
                List<List<List<int>>> adj = new List<List<List<int>>>();
                for (int i = 0; i < V; i++)
                {
                    adj.Add(new List<List<int>>());
                }
                for (int i = 0; i < E; i++)
                {
                    ip = Console.ReadLine().Trim().Split(' ');
                    int u = int.Parse(ip[0]);
                    int v = int.Parse(ip[1]);
                    int w = int.Parse(ip[2]);

                    adj[u].Add(new List<int>() { v, w });
                    adj[v].Add(new List<int>() { u, w });
                }
                Solution obj = new Solution();
                var res = obj.spanningTree(V, ref adj);
                Console.WriteLine(res);
            }
        }
    }
}

// } Driver Code Ends




//User function Template for C#

class Solution
{
    //Function to find sum of weights of edges of the Minimum Spanning Tree.
    int[] distances;
    HashSet<int> visited;
    public int spanningTree(int V, ref List<List<List<int>>> adj)
    {
        // code here
        distances = Enumerable.Repeat(Int32.MaxValue, V).ToArray();
        visited = new HashSet<int>();
        distances[0]=0;
        int totalCost = 0;
        
        while(visited.Count < V)
        {
            int vertex = GetMinimum();
            visited.Add(vertex);
            totalCost += distances[vertex];
            //Console.WriteLine("{0}, {1}", vertex, distances[vertex]);
            foreach(List<int> edge in adj[vertex])
            {
                int v = edge[0];
                int cost = edge[1];
                if(visited.Contains(v))
                    continue;
                distances[v] = Math.Min(distances[v], cost);
            }
        }
        return totalCost;
    }
    
    public int GetMinimum()
    {
        int minimum=-1;
        for(int i=0; i<distances.Length; i++)
        {
            if(!visited.Contains(i))
            {
                if(minimum==-1)
                {
                    minimum = i;
                }
                else if(distances[i] < distances[minimum])
                {
                    minimum = i;
                }
            }
        }
        return minimum;
    }
}
