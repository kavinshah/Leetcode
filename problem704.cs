public class Solution {
    public int Search(int[] nums, int target) {
        int mid;
        int low=0, high=nums.Length-1;
        
        while(high>=low){
            mid=(low+high)/2;
            if(nums[mid]==target)
                return mid;
            
            if(nums[mid]>target)
                high=mid-1;
            else
                low=mid+1;
        }
        return -1;
    }
}