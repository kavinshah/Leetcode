public class Solution {
    Dictionary<int,int> memoization;
    public Solution()
    {
        memoization=new Dictionary<int,int>();
    }
    
    public int Fib(int n) {
        
        if(n<=1)
            return n;
        
        if(memoization.ContainsKey(n))
            return memoization[n];
        
        memoization[n]=Fib(n-1)+Fib(n-2);
        return memoization[n];
    }
}

//time: O(N)
//space: O(N)