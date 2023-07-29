/*

n=1, k=6, target = 4
4

n=2, k=6, target=4
1-3,2-2,3-1

1-6,2-5,3-4,4-3,5-2,6-1

1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1
1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   2
1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   3
1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   4
1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   5
1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   6
1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   7

1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   1   2   1


*/


public class Solution {
    Dictionary<(int,int), int> memoization;
    int k;
    const int MODULO=1000000007;
    public int NumRollsToTarget(int n, int k, int target) {
        memoization = new Dictionary<(int,int), int>();
        this.k=k;
        return PossibleWays(n, target)%MODULO;
    }
    
    public int PossibleWays(int dice, int target)
    {
        if(dice==0)
        {
            if(target==0)
                return 1;
            else
                return 0;
        }
        
        if(memoization.ContainsKey((dice,target)))
            return memoization[(dice,target)];
        
        int returnval=0;
        for(int i=1; i<=k; i++)  
        {
            returnval=(returnval+PossibleWays(dice-1,target-i))%MODULO;
        }
        
        memoization[(dice,target)] = returnval;
        
        return returnval;
        
        
    }
}

// time: O(N*T*K)
// space: O(N*T)