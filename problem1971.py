"""

it is a DFS/BFS problem
Go figure

         5  6  2
          \ | /
         8--4--3
          / | \
      9--0  1--7


"""
from collections import defaultdict, deque
class Solution:
    def validPath(self, n: int, edges: List[List[int]], source: int, destination: int) -> bool:
        
        def findparent(vertex):
            nonlocal parent
            if parent[vertex]==vertex:
                return vertex
            return findparent(parent[vertex])
        
        def makegroup(vertex1, vertex2):
            nonlocal parent
            parent1=findparent(vertex1)
            parent2=findparent(vertex2)
            parent[parent1]=parent2
            
        parent=[i for i in range(n)]
        for e in edges:
            makegroup(e[0], e[1])
            
        return findparent(source)==findparent(destination)
        
            