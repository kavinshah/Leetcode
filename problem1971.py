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
        #build adj list
        if source==destination:
            return True
        adj=defaultdict(set)
        visited=set()
        for e in edges:
            adj[e[0]].add(e[1])
            adj[e[1]].add(e[0])
        #print(adj)
        
        #perform BFS
        queue=deque()
        queue.append(source)
        visited=set()
        visited.add(source)
        while(queue):
            current=queue.popleft()
            for neighbour in adj[current]:
                if neighbour==destination:
                    return True
                if neighbour not in visited:
                    visited.add(neighbour)
                    queue.append(neighbour)
                    
        return False