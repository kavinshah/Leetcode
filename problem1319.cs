/*

n-1 connections for n nodes



*/

public class Solution {
    HashSet<int> visited;
    int[][] connections;
    List<List<int>> adjList;
    
    public int MakeConnected(int n, int[][] connections) {
        // not enough cables
        if((n-1) > connections.Length)
            return -1;
        
        //find number of disconnected components
        int result=0;
        visited = new HashSet<int>();
        adjList = new List<List<int>>();
        this.connections = connections;
        
        for(int i=0; i<n; i++)
            adjList.Add(new List<int>());
        
        //create adjacency list
        foreach(int[] c in connections)
        {
            int v1=c[0];
            int v2=c[1];
            
            adjList[v1].Add(v2);
            adjList[v2].Add(v1);
        }
        
        //perform dfs
        for(int i=0; i<n; i++)
        {
            if(visited.Contains(i))
                continue;
            visited.Add(i);
            Dfs(i);
            result++;
        }
        
        return result-1;
    }
    
    public void Dfs(int node)
    {
        foreach(int neighbor in adjList[node])
        {
            if(!visited.Contains(neighbor))
            {
                visited.Add(neighbor);
                Dfs(neighbor);
            }
        }
        return;
    }
}

//time: O(V+E)
//space:  O(V+E)