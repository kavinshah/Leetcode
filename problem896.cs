public class Solution {
    public bool IsMonotonic(int[] nums) {
        int store=0;
        
        for(int i=0; i<nums.Length-1; i++)
        {
            int c = nums[i].CompareTo(nums[i+1]);
            if(c!=0)
            {
                if(c!=store && store!=0)
                {
                    return false;
                }
                store=c;
            }
        }
        
        return true;
        
    }
}