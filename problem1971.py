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
        
        def DFS(vertex):
            nonlocal visited, destination, adj
            
            if vertex==destination:
                return True
            
            for neighbour in adj[vertex]:
                if neighbour not in visited:
                    visited.add(neighbour)
                    found=DFS(neighbour)
                    if found:
                        return True
                    
            return False
            
        
        #build adj list
        if source==destination:
            return True
        adj=defaultdict(set)
        visited=set()
        
        for e in edges:
            adj[e[0]].add(e[1])
            adj[e[1]].add(e[0])
        
        #print(adj)
        
        #perform DFS
        return DFS(source)