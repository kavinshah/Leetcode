public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int low=0, high=nums.Length-1, mid;
        mid=(int)((low+high)/2);
        while(low<=high)
        {
            mid=(int)((low+high)/2);
            if(nums[mid]==target)
                return mid;
            else if(nums[mid]>target)
                high=mid-1;
            else
                low=mid+1;
        }
        
        if(target>nums[mid])
            return mid+1;
        return mid;
    }
}

/*
[1,3,5,6], 7
low=0, high=3, mid=1
low=2, high=3, mid=2
low=3, high=3, mid=3
low=4, high=3, mid=3
ans=4, expected=4

[1,3,5,6], 0
low=0, high=3, mid=1
low=0, high=0, mid=0
low=0, high=-1, mid=0
ans=0, expected=0

[1,3,5,6], 2
low=0, high=3, mid=1
low=0, high=0, mid=0
low=1, high=0, mid=0
ans=1, expected=1

[1,3,5,7], 6
low=0, high=3, mid=1
low=2, high=3, mid=2
low=3, high=3, mid=3
low=3, high=2, mid=
ans=3, expected=3

[1,3,5,7], 2
low=0, high=3, mid=1
low=0, high=0, mid=0
low=1, high=0, mid=0
ans=1, expected=1

[1,3,5,7], 4
low=0, high=3, mid=1
low=2, high=3, mid=2
low=2, high=1, mid=2
ans=2, expected=2


*/