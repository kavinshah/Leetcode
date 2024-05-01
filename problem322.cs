public class Solution {
    public int CoinChange(int[] coins, int V) {
        uint[] table = Enumerable.Repeat(UInt32.MaxValue, V+1).ToArray();
        int M = coins.Length;
        
        table[0]=0;

        for(int i=1; i<=V; i++){
            for(int j=0; j<M; j++){
                if(i>=coins[j] && table[i-coins[j]]!=UInt32.MaxValue){
                    table[i] = Math.Min(table[i], 1+table[i-coins[j]]);
                }
            }
        }

        if(table[V]==UInt32.MaxValue)
            return -1;
        
        return (int)table[V];
    }
}

//time: O(M*V)
//space: O(V)