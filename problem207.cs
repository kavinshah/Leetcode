/*

0   ->  1
1   ->  2
2   ->  3
3   ->  0


*/


public class Solution {
    Dictionary<int, List<int>> adjacencyMatrix;
    HashSet<int> visited, path, checkedNode;
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        adjacencyMatrix= new Dictionary<int, List<int>>();
        checkedNode = new HashSet<int>();
        
        foreach(int[] p in prerequisites)
        {
            if(!adjacencyMatrix.ContainsKey(p[1]))
                adjacencyMatrix[p[1]] = new List<int>();
            if(!adjacencyMatrix.ContainsKey(p[0]))
                adjacencyMatrix[p[0]] = new List<int>();
            adjacencyMatrix[p[1]].Add(p[0]);
        }
        
        foreach(var kvp in adjacencyMatrix)
        {
            path = new HashSet<int>();
            path.Add(kvp.Key);
            if(!Dfs(kvp.Key))
            {
                return false;
            }
            path.Remove(kvp.Key);
        }
        return true;
    }
    
    public bool Dfs(int node)
    {
        if(checkedNode.Contains(node))
            return true;
        
        foreach(int next in adjacencyMatrix[node])
        {
            if(path.Contains(next))
                return false;
            path.Add(next);
            if(!Dfs(next))
                return false;
            path.Remove(next);
        }
        checkedNode.Add(node);
        return true;
    }
}

//Time: O(N)
//space: O(N)
