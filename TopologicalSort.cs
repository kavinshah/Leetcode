/*
https://www.geeksforgeeks.org/problems/topological-sort/1

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
        bool check(int V, List<int> res, List<List<int>> adj)
        {
            if(V!=res.Count) return false;
            List<int> map = new List<int>();
            for (int i = 0; i < V+1; i++) map.Add(-1);
            for (int i = 0; i < V; i++)
            {
                map[res[i]] = i;
            }
            for (int i = 0; i < V; i++)
            {
                foreach (int v in adj[i])
                {
                    if (map[i] > map[v]) return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            GFG g = new GFG();
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var ip = Console.ReadLine().Trim().Split(' ');
                int E = int.Parse(ip[0]);
                int V = int.Parse(ip[1]);
                List<List<int>> adj = new List<List<int>>();
                for (int i = 0; i < V; i++)
                {
                    adj.Add(new List<int>());
                }
                for (int i = 0; i < E; i++)
                {
                    ip = Console.ReadLine().Trim().Split(' ');
                    int u = int.Parse(ip[0]);
                    int v = int.Parse(ip[1]);
                    adj[u].Add(v);
                }
                Solution obj = new Solution();
                var res = obj.topoSort(V, adj);
                Console.WriteLine(g.check(V, res, adj) ? 1 : 0);
            }
        }
    }
}

// } Driver Code Ends


//User function Template for C#

/*

0 - 2
1 - 1
2 - 1
3 - 2
4 - 0
5 - 0

[2 1 1 2 0 0]

5 4 0 1 2 3 

curr = 5, [1 1 0 2 0 0]
curr = 4, [0 0 0 2 0 0]
curr = 0, [0 0 0 2 0 0]
curr = 1, [0 0 0 1 0 0]
curr = 2, [0 0 0 0 0 0]
curr = 3, [0 0 0 0 0 0]

[2 1 1 2 0 0]

5 4 2 1 3 0

curr = 5, [1 1 0 2 0 0]
curr = 4, [0 0 0 2 0 0]
curr = 2, [0 0 0 1 0 0]
curr = 1, [0 0 0 0 0 0]
curr = 3, [0 0 0 0 0 0]
curr = 0, [0 0 0 0 0 0]

*/

class Solution
{
    //Function to return list containing vertices in Topological order. 
    public List<int> topoSort(int V, List<List<int>> adj)
    {
        //code here
        
        //find the indegree of each vertices
        
        
        //1. pick the vertex with indegree = 0 and mark it visited
        
        //2. update indegree of the neighbors of current vertex
        
        //3. repeat 1 and 2 till we have visited all vertices
        
        int[] indegree = new int[V];
        Queue<int> queue = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();
        List<int> result = new List<int>();
        
        for(int i=0; i<V; i++)
        {
            foreach(int n in adj[i])
            {
                indegree[n]+=1;
            }
        }
        
        for(int i=0; i<V; i++)
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
            result.Add(current);
            
            if(adj[current]==null)
                continue;
            
            foreach(int n in adj[current])
            {
                indegree[n]-=1;
                
                if(indegree[n]==0 && !visited.Contains(n))
                {
                    visited.Add(n);
                    queue.Enqueue(n);
                }
            }
        }
        
        return result;
    }
}
