/*

[2,2,1,1,1,2,2]


*/


public class Solution {
    public int MajorityElement(int[] nums) {
        int last = nums[0];
        int count=1;
        
        for(int i=1; i<nums.Length; i++)
        {
            if(nums[i] == last)
            {
                count++;
            }
            else if(count>0)
            {
                count--;
            }
            else
            {
                last=nums[i];
                count=1;
            }
        }
        return last;
        
    }
}

//time: O(N)
//space: O(1)