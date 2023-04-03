/*



*/

public class Solution {
    int top;
    int[] cost;
    Dictionary<int,int> memoize;
    
    public int MinCostClimbingStairs(int[] cost) {
        top=cost.Length;
        this.cost=cost;
        memoize = new Dictionary<int, int>();
        return Math.Min(Climb(0), Climb(1));
        
    }
    
    public int Climb(int currentFloor)
    {
        if(currentFloor>=top)
            return 0;
        
        if(memoize.ContainsKey(currentFloor))
            return memoize[currentFloor];
        
        memoize[currentFloor]= cost[currentFloor] + Math.Min(Climb(currentFloor+1), Climb(currentFloor+2));
        
        return memoize[currentFloor];
    }
    
}

//time: O(N)
//space: O(N)