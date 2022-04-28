"""

it is a DFS/BFS problem
Go figure

         5  6  2
          \ | /
         8--4--3
          / | \
      9--0  1--7


"""
from collections import defaultdict
class Solution:
    def validPath(self, n: int, edges: List[List[int]], source: int, destination: int) -> bool:
        #build adj list
        if source==destination:
            return True
        adj=defaultdict(set)
        
        for e in edges:
            adj[e[0]].add(e[1])
            adj[e[1]].add(e[0])
        
        #print(adj)
        
        #traverse DFS. start with start vertex and end at destination vertex
        stack = [source]
        visited = set()
        visited.add(source)
        while(stack):
            current = stack.pop()
            #print(current)
            for neighbour in adj[current]:
                if neighbour==destination:
                    return True
                if neighbour not in visited:
                    stack.append(neighbour)
                    visited.add(neighbour)
                
        return False