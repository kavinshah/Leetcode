/* Maybe there is an improvement 
https://leetcode.com/problems/cheapest-flights-within-k-stops/discuss/5162245/Bellman-Ford-Algorithm-Implementation-or-Clear-solution-description
*/
public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        int[][] costs = new int[n][];
        int i=0;
        
        for(i=0; i<costs.Length; i++)
        {
            costs[i] = Enumerable.Repeat(Int32.MaxValue, k+2).ToArray();
        }
        
        costs[src] = Enumerable.Repeat(0, k+2).ToArray();
        
        i=0;
        while(i<n){
            bool updated =  false;
            foreach(int[] e in flights){
                int v1 = e[0];
                int v2 = e[1];
                int c = e[2];
                
                for(int stop=0; stop<=k; stop++){
                    if(costs[v1][stop] != Int32.MaxValue
                        && costs[v2][stop+1] > (costs[v1][stop]+c)){
                        //Console.WriteLine("{0}, {1}, {2}", costs[v2][stop+1], costs[v1][stop], c);
                        costs[v2][stop+1] = costs[v1][stop] + c;
                        updated = true;
                    }
                }
            }
            
            i++;
            
            if(!updated)
                break;
        }
        
        int min = Int32.MaxValue;
        foreach(int c in costs[dst])
            min = Math.Min(min, c);
        
        if(min==Int32.MaxValue)
            return -1;
        return min;
    }
}


/*

Traditional Bellman Ford will fail for the following case:
4
[[0,1,1],[0,2,5],[1,2,1],[2,3,1]]
0
3
1

There is only one vertex V connected to the destination, which is updated to the shortest with stops=K before we even get a chance to update the destination using V. Hence, we get the cost = inf for destination in this case even when the correct answer is 6

So, we need to use 2-D array of cost for k stops for each vertex


Time: O(V.E.K)
Space: O(VK)

*/