# Time: O(VE)
# Space: O(V)

#User function Template for python3

class Solution:
    # Function to construct and return cost of MST for a graph
    # represented using adjacency matrix representation
    '''
    V: nodes in graph
    edges: adjacency list for the graph
    S: Source
    '''
    def bellman_ford(self, V, edges, S):
        #code here
        distances = [pow(10,8) for i in range(V)]
        distances[S] = 0
        # print(edges)
        
        for i in range(V):
            costUpdated=False
            
            for e in edges:
                u=e[0]
                v=e[1]
                cost = e[2]
                
                if(distances[u]!=pow(10,8) and (distances[u]+cost) < distances[v]):
                    distances[v] = distances[u]+cost
                    costUpdated=True;
                    
                
            if not costUpdated:
                break
        
        for u,v,w in edges:
            if(distances[u]!=pow(10,8) and (distances[u]+w) < distances[v]):
                return [-1]
                
        return distances

#{ 
 # Driver Code Starts
#Initial Template for Python 3
import atexit
import io
import sys


if __name__ == '__main__':
    test_cases = int(input())
    for cases in range(test_cases):
        V,E = map(int,input().strip().split())
        edges = []
        for i in range(E):
            u,v,w = map(int,input().strip().split())
            edges.append([u,v,w])
        S=int(input())
        ob = Solution()
        
        res = ob.bellman_ford(V,edges,S)
        for i in res:
            print(i,end=" ")
        print()
# } Driver Code Ends