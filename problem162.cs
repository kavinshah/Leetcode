public class Solution {
    public int FindPeakElement(int[] nums) {
        return BinarySearch(nums,0,nums.Length-1);
    }
    
    public int BinarySearch(int[] nums, int l, int r)
    {
        if(l==r)
            return l;
        int mid=(l+r)/2;
        if(nums[mid]>nums[mid+1])
            return BinarySearch(nums, l, mid);
        return BinarySearch(nums, mid+1, r);
    }
}

//time: O(logN)
//space: O(1)