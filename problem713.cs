public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        int left=0, right=0;
        long total=1;
        int result=0;
        
        if(k<=1) return 0;
        
        while(right<nums.Length)
        {
            if(total<k)
            {
                total=total*nums[right];
                right++;
            }
            else
            {
                total=total/nums[left];
                left++;
            }
            
            if(total<k)
                result += (right-left);   
        }
        
        while(total>k && left<nums.Length)
        {
            total=total/nums[left];
            left++;
            if(total<k)
                result+=right-left;
        }
        return result;
    }
}

//time: O(N)
//space: O(1)