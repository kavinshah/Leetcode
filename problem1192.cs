/*

                        0------2 
                         \     |
                           \   |
                             \ |
                               1----3----4
                                    |   /
                                    |  /
                                    | /
                                     5


0,1,1,0,0,0
1,0,1,1,0,0
1,1,0,0,0,0
0,1,0,0,1,1
0,0,0,1,0,1
0,0,0,1,1,0

remove and adge and perform dfs

time: (v+e)e ---- this will TLE
Let's go something in O(v+e)

Tarjan's Algorithm
Time: O(V+E)
Space: O(V)

--------------------------------------------


*/

public class Solution {
    Dictionary<int, List<int>> adjList;
    HashSet<int> visited;
    List<IList<int>> result;
    int[] minimumCost;
    
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) {
        adjList = new Dictionary<int, List<int>>();
        result = new List<IList<int>>();
        visited=new HashSet<int>();
        
        minimumCost=new int[n];
        
        for(int i=0; i<n; i++)
            minimumCost[i]=Int32.MaxValue;
        
        foreach(var c in connections)
        {
            if(!adjList.ContainsKey(c[0]))
                adjList[c[0]]=new List<int>();
            adjList[c[0]].Add(c[1]);
            if(!adjList.ContainsKey(c[1]))
                adjList[c[1]]=new List<int>();
            adjList[c[1]].Add(c[0]);
        }
        
        // foreach(var kvp in adjList)
        // {
        //     Console.Write(kvp.Key+":");
        //     Console.WriteLine(String.Join(",", kvp.Value));
        // }
        
        visited.Add(connections[0][0]);
        Dfs(connections[0][0], connections[0][0], 1);
        return result;
    }
    
    public void Dfs(int node, int parent, int timestamp)
    {
        int cost=timestamp;
        
        minimumCost[node]=cost;
        foreach(int neighbor in adjList[node])
        {
            if(!visited.Contains(neighbor))
            {
                visited.Add(neighbor);
                Dfs(neighbor, node, timestamp+1);
                
                //check if the edge is a bridge
                if(minimumCost[neighbor]>minimumCost[node])
                    result.Add(new List<int>(){node, neighbor});
            }
            if(neighbor!=parent)
                cost=Math.Min(cost, minimumCost[neighbor]);
        }
        minimumCost[node]=cost;
    }
}

//time: O(V+E)
//space: O(V)
