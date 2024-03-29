/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}

visited=[1,2]
nodes = {
1:2,
2:
}
                            [1]
                        /       \

*/

public class Solution {
    Dictionary<int, Node> nodes;
    HashSet<int> visited;
    public Node CloneGraph(Node node) {
        
        if(node == null)
            return null;
        
        nodes = new Dictionary<int, Node>();
        visited = new HashSet<int>();
        visited.Add(node.val);
        Dfs(node);
        
        //PrintGraph(nodes[node.val]);
        
        return nodes[node.val];
    }
    
    public void Dfs(Node node)
    {
        if(node==null)
            return;
        
        if(!nodes.ContainsKey(node.val))
            nodes[node.val] = new Node(node.val);
        
        foreach(Node n in node.neighbors)
        {
            if(!nodes.ContainsKey(n.val))
                nodes[n.val] = new Node(n.val);
            
            if(!nodes[node.val].neighbors.Contains(nodes[n.val]))
                nodes[node.val].neighbors.Add(nodes[n.val]);
            
            if(!nodes[n.val].neighbors.Contains(nodes[node.val]))
                nodes[n.val].neighbors.Add(nodes[node.val]);
            
            if(!visited.Contains(n.val))
            {
                visited.Add(n.val);
                Dfs(n);
            }
        }
        
        return;
    }
    
    void PrintGraph(Node node)
    {
        Queue<Node> queue=new Queue<Node>();
        HashSet<int> visited = new HashSet<int>();
        
        queue.Enqueue(node);
        visited.Add(node.val);
        
        while(queue.Count>0)
        {
            Node current = queue.Dequeue();
            foreach(Node neighbor in current.neighbors)
            {
                if(!visited.Contains(neighbor.val))
                {
                    visited.Add(neighbor.val);
                    queue.Enqueue(neighbor);
                }
            }
        }
        return;
    }
}

//time: O(N)
//space: O(N)