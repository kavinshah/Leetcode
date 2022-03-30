public class Solution {
    public bool IsMonotonic(int[] nums) {
        int prev=nums[0];
        bool flag=true;
        
        foreach(int n in nums)
        {
            if(n<prev)
            {
                flag=false;
                break;
            }
            prev=n;
        }
        
        if(!flag)
        {
            prev=nums[0];
            foreach(int n in nums)
            {
                if(n>prev)
                {
                    return false;
                }
                prev=n;
            }
            
            return true;
        }
        return flag;
    }
}