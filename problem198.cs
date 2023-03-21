public class Solution {
    Dictionary<int, int> memoization = new Dictionary<int, int>();
    int[] nums;
    public int Rob(int[] nums) {
        this.nums = nums;
        return helper(0);
    }
    
    public int helper(int index)
    {
        if(index>=nums.Length)
        {
            return 0;
        }
        
        if(memoization.ContainsKey(index))
        {
            return memoization[index];
        }
        
        memoization[index] = Math.Max(nums[index]+helper(index+2), helper(index+1));
        return memoization[index];
    }
}
//time: O(N)
//space: O(N)