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
*/

public class Solution {
    Dictionary<int, Node> map=new Dictionary<int, Node>();
    HashSet<int> visited = new HashSet<int>();
    
    public Node CloneGraph(Node node) {
        
        if(node==null)
            return null;
        
        if(node.neighbors==null)
            return new Node(node.val);
        
        CreateGraph(node);
        
        // visited=new HashSet<int>(){node.val};
        // Print(map[node.val]);
        
        return map[node.val];
    }
    
    public void CreateGraph(Node node)
    {
        Node currentNode;
        if(!map.ContainsKey(node.val))
        {
            map[node.val]=new Node(node.val);
        }
        currentNode = map[node.val];
        
        foreach(Node neighbor in node.neighbors)
        {
            Node ourNeighbor;
            if(!map.ContainsKey(neighbor.val))
            {
                map[neighbor.val] = new Node(neighbor.val);
            }
            ourNeighbor=map[neighbor.val];
            
            if(!currentNode.neighbors.Contains(ourNeighbor))
            {
                currentNode.neighbors.Add(ourNeighbor);
            }
        }
        
        foreach(Node n in node.neighbors)
        {
            if(!visited.Contains(n.val))
            {
                visited.Add(n.val);
                CreateGraph(n);
            }
        }
        return;
    }
    
    // public void Print(Node node)
    // {
    //     Console.WriteLine("Visiting:" + node.val);
    //     foreach(Node n in node.neighbors)
    //     {
    //         Console.Write(n.val + "->");
    //     }
    //     Console.WriteLine();
    //     foreach(Node n in node.neighbors)
    //     {
    //         if(!visited.Contains(n.val))
    //         {
    //             visited.Add(n.val);
    //             Print(n);
    //         }
    //     }
    // }
}

//time:O(V+E)*E
//space: O(V+E)