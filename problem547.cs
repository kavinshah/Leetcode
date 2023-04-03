/*

basically use some algo to find number of components.


*/


public class Solution {
    List<HashSet<int>> components;
    int[][] isConnected;
    
    public int FindCircleNum(int[][] isConnected) {
        components=new List<HashSet<int>>();
        this.isConnected=isConnected;
        
        for(int i=0; i<isConnected.Length; i++)
        {
            for(int j=0; j<isConnected.Length; j++)
            {
                if(isConnected[i][j]==1)
                {
                    //Console.WriteLine($"{i}, {j}");
                    
                    //find component of i
                    int iComponent=FindComponent(i);
                    //find component of j
                    int jComponent=FindComponent(j);
                    
                    //Console.WriteLine($"{iComponent}: {jComponent}");
                    
                    //if i=null and j=null then add them into a new component
                    if(iComponent==-1 && jComponent==-1)
                    {
                        HashSet<int> newComponent=new HashSet<int>(){i,j};
                        components.Add(newComponent);
                    }
                    
                    //if i=null, then add into j
                    else if(iComponent==-1)
                    {
                        components[jComponent].Add(i);
                    }
                    
                    //if j=null, then add into i
                    else if(jComponent==-1)
                    {
                        components[iComponent].Add(j);
                    }
                    
                    //else club both the components and add the new component into the list  only if they are already not part of same component
                    else if(iComponent!=jComponent)
                    {
                        HashSet<int> iH=components[iComponent];
                        HashSet<int> jH=components[jComponent];
                        components.RemoveAt(iComponent);
                        jH.UnionWith(iH);
                    }
                }
            }
        }
        
        return components.Count;
    }
    
    public int FindComponent(int node)
    {
        for(int i=0; i<components.Count; i++)
        {
            if(components[i].Contains(node))
                return i;
        }
        
        return -1;
    }
}

//time: O(N^2)
//space: O(N)