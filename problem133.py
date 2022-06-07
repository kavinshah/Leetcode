"""
# Definition for a Node.
class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []

"""
class Solution:
    def cloneGraph(self, node: 'Node') -> 'Node':
        
        if not node:
            return None
        
        adjList = defaultdict(set)
        visited=set()
        stack = []
        stack.append(node)
        while(stack):
            current=stack.pop()
            adjList[current.val]=set()
            for neighbor in current.neighbors:
                adjList[current.val].add(neighbor.val)
                if neighbor.val not in visited:
                    visited.add(neighbor.val)
                    stack.append(neighbor)
        
        #print(adjList)
        result = {}
        for k in adjList.keys():
            result[k] = Node(k,[])
            
        for k in adjList.keys():
            result[k].neighbors = [result[n] for n in adjList[k]]
        
        return result[node.val]