/*

link: https://www.geeksforgeeks.org/problems/implementing-dijkstra-set-1-adjacency-matrix/1


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
                int V = int.Parse(ip[0]);
                int f = int.Parse(ip[1]);
                List<List<int>>[] adj = new List<List<int>>[V];
                for (int i = 0; i < V; i++)
                {
                    adj[i] = new List<List<int>>();
                }
                for (int i = 0; i < f; i++)
                {
                    ip = Console.ReadLine().Trim().Split(' ');
                    int u = int.Parse(ip[0]);
                    int v = int.Parse(ip[1]);
                    int w = int.Parse(ip[2]);
                    adj[u].Add(new List<int> { v, w });
                    adj[v].Add(new List<int> { u, w });
                }
                int S = Convert.ToInt32(Console.ReadLine());
                Solution obj = new Solution();
                var res = obj.dijkstra(V, adj, S);
                foreach (int i in res)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
// } Driver Code Ends


//User function Template for C#

class Solution
{
    //Complete this function
    //Function to find the shortest distance of all the vertices
    //from the source vertex S.
    int[] distances;
    HashSet<int> visited;
    List<int> result = new List<int>();
    int vertices;
    public List<int> dijkstra(int V, List<List<int>>[] adj, int S)
    {
        // Code here
        distances = Enumerable.Repeat(Int32.MaxValue, V).ToArray();
        visited = new HashSet<int>();
        vertices = V;
        
        distances[S] = 0;
        
        while(visited.Count<V)
        {
            int vertex = GetNextNearest();
            visited.Add(vertex);
            
            for(int i=0; i<adj[vertex].Count; i++)
            {
                int neighbour = adj[vertex][i][0];
                if(!visited.Contains(neighbour))
                {
                    distances[neighbour] = Math.Min(distances[neighbour],
                                            distances[vertex] + adj[vertex][i][1]);
                }
            }
        }
        
        result = distances.ToList();
        return result; 
    }
    
    public int GetNextNearest()
    {
        int min=-1;
        
        for(int i=0; i<vertices; i++)
        {
            if(!visited.Contains(i))
            {
                if(min==-1)
                {
                    min = i;
                }
                else if(distances[i]<distances[min])
                {
                    min = i;
                }
            }
        }
        return min;
    }
    
    
}

//time : O(VE)
//space: O(V)