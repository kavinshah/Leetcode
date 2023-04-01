/*

[4,2,4,5,6]




*/


public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        int result=0;
        int left=0, right=0;
        HashSet<int> visited = new HashSet<int>();
        int currentSum=0;
            
        while(left<=right && right<nums.Length)
        {
            if(!visited.Contains(nums[right]))
            {
                currentSum+=nums[right];
                visited.Add(nums[right]);
                right++;
            }
            else
            {
                result=Math.Max(result, currentSum);
                currentSum-=nums[left];
                visited.Remove(nums[left]);
                left++;
            }
        }
        
        result=Math.Max(result, currentSum);
        return result;
        
    }
}

//time: O(N)
//space: O(M)