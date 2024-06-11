/*

https://www.geeksforgeeks.org/problems/detect-cycle-in-a-directed-graph/1

Gotcha: 
Do not check cycles from visited nodes. So, once you visit a node, you can conclude that there are no cycles originating from that node

//{ Driver Code Starts
//Initial Template for C#

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

                var ip = Console.ReadLine().Trim().Split(' ');
                int V = int.Parse(ip[0]);
                int E = int.Parse(ip[1]);
                List<int>[] adj = new List<int>[V];
                for (int i = 0; i < V; i++)
                {
                    adj[i] = new List<int>();
                }
                for (int i = 0; i < E; i++)
                {
                    ip = Console.ReadLine().Trim().Split(' ');
                    int u = int.Parse(ip[0]);
                    int v = int.Parse(ip[1]);
                    adj[u].Add(v);
                }
                Solution obj = new Solution();
                var res = obj.isCyclic(V, adj);
                Console.WriteLine(res?1:0);
            }

        }
    }
}

// } Driver Code Ends


//User function Template for C#

class Solution
{
    //Complete this function
    //Function to detect cycle in a directed graph.
    HashSet<int> visited = new HashSet<int>();
    List<int>[] adj;
    public bool isCyclic(int V, List<int>[] adj)
    {
        //Your code here
        this.adj = adj;
        
        for(int i=0; i<adj.Count(); i++)
        {
            if(!visited.Contains(i))
            {
                visited.Add(i);
                if(CheckCycle(i, new HashSet<int>(){i}))
                {
                    return true;
                }
            }
        }
        
        //Console.WriteLine("Returning false");
        return false;
    }
    
    public bool CheckCycle(int current, HashSet<int> path)
    {
        foreach(int neighbour in adj[current])
        {
            if(path.Contains(neighbour))
            {
                return true;
            }
            
            if(!visited.Contains(neighbour))
            {
                path.Add(neighbour);
                if(CheckCycle(neighbour, path))
                {
                    //Console.WriteLine("{0}, {1}", neighbour, String.Join(",", path));
                    return true;
                }
                path.Remove(neighbour);
            }
        }
        
        visited.Add(current);
        
        return false;
    }
}


//time: O(V+E)
//Space: O(V)