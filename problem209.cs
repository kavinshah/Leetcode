/*
 0 1 2 3 4 5
[2,3,1,2,4,3]

left=0, right=0, currsum=0
left=0, right=1, currsum=2
left=0, right=2, currsum=5
left=0, right=3, currsum=6
left=0, right=4, currsum=8, minlength=4
left=1, right=4, currsum=6, minlength=4
left=1, right=5, currsum=10, minlength=4
left=2, right=5, currsum=7, minlength=3
left=3, right=5, currsum=6, minlength=3
left=3, right=6, currsum=9, minlength=3

left=4, right=6, currsum=7, minlength=3
left=5, right=6, currsum=3, minlength=2

*/

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left=0, right=0;
        int minLength=Int32.MaxValue, currsum=0;
        
        while(right<nums.Length)
        {
            if(currsum < target)
            {
                currsum+=nums[right];
                right++;
            }
            else
            {
                currsum-=nums[left];
                left++;
            }
            if(currsum>=target)
            {
                minLength=Math.Min(minLength, right-left);
            }
        }
        
        while(currsum>=target)
        {
            minLength=Math.Min(minLength, right-left);
            currsum-=nums[left];
            left++;
        }
        
        if(minLength==Int32.MaxValue)
            return 0;
        return minLength;
    }
}

// time: O(N)
// space: O(1)