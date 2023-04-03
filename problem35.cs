/*

[1,3,5,9], 7
mid=9, mid

[1,3,5,9],2
mid=1, mid+1




*/    

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int low=0, high=nums.Length-1;
        int mid=(low+high)/2;
        while(low<=high)
        {
            mid=(low+high)/2;
            if(nums[mid]==target)
                return mid;
            
            if(nums[mid]>target)
                high=mid-1;
            else
                low=mid+1;
        }
        
        return low;
    }
}

//time: O(log N)
//space: O(1)