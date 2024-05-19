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
    public int spanningTree(int V, ref List<List<List<int>>> adj)
    {
        // code here
        List<(int, int, int)> edges = new List<(int, int, int)>();
        DisjointSet ds = new DisjointSet(adj.Count);
        int totalCost=0;
        
        for(int i=0; i<V; i++)
        {
            foreach(List<int> e in adj[i])
            {
                edges.Add((i, e[0], e[1]));
            }
        }
        
        edges.Sort(delegate((int,int,int) a, (int,int,int) b){
            return a.Item3.CompareTo(b.Item3);
        });
        
        foreach(var edge in edges)
        {
            int parent1 = ds.FindParent(edge.Item1);
            int parent2 = ds.FindParent(edge.Item2);
            
            if(parent1 != parent2)
            {
                ds.UnionByRank(edge.Item1, edge.Item2);
                totalCost += edge.Item3;
            }
        }
        return totalCost;
    }
}

class DisjointSet
{
    int[] parent, rank;
    
    public DisjointSet(int v)
    {
        parent = new int[v];
        rank = new int[v];
        
        for(int i=0; i<v; i++)
        {
            parent[i]=i;
        }
    }
    
    public int FindParent(int v)
    {
        if(v==parent[v])
        {
            return v;
        }
        
        int p = FindParent(parent[v]);
        parent[v] = p;
        return p;
    }
    
    public void UnionByRank(int u, int v)
    {
        int parent1 = parent[u];
        int parent2 = parent[v];
        
        if(parent1 == parent2)
            return;
            
        if(rank[parent1] > rank[parent2]) {
            parent[parent2] = parent1;
        } else if(rank[parent1] < rank[parent2]) {
            parent[parent1] = parent2;
        } else {
            parent[parent2] = parent1;
            rank[parent1] = rank[parent1]+1;
        }
        return;
    }
}
