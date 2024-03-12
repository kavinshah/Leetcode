/*

length is always odd.

- check if is the single element
- if mid and mid-1 are same, go left single element because single element is in the left subarray
- else go right because single element is in right subarray

[1,1,2,3,3,4,4,8,8]

left=0, right=8, mid = 4, mid is even. mid and mid-1 are same. go left
left=0, right=3, mid = 1, mid is odd. mid and mid-1 are same. go right
left=2, right=3, mid = 2, mid is even. mid is the single element


[3,3,7,7,10,11,11]
left=0, right=6, mid=3, mid is odd. mid and mid-1 are same. go right
left=4, right=6, mid=5, mid is odd. mid and mid+1 are same. go left
left=4, right=4, mid=4. mid is the single element

*/

public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int left=0, right=nums.Length-1;
        
        if(nums.Length==1)
            return nums[0];
        
        while(left<=right)
        {
            int mid=(left+right)/2;
            int midElement = nums[mid];
            
            if(left==right)
                return midElement;
            
            if((right-left+1)==2)
            {
                if(left==0)
                    return nums[left];
                if(right==nums.Length-1)
                    return nums[nums.Length-1];
                
                if(nums[left-1]==nums[left])
                    return nums[right];
                else 
                    return nums[left];
                    
            }
                
            if(midElement!=nums[mid-1] && midElement != nums[mid+1])
                return midElement;
            
            if(mid>0 && mid%2==1 && midElement==nums[mid-1])
                left=mid+1;
            else if((mid+1)<nums.Length && mid%2==1 && midElement==nums[mid+1])
                right=mid-1;
            else if(mid>0 && mid%2==0 && midElement == nums[mid-1])
                right=mid-1;
            else if((mid+1)<nums.Length && mid%2==0 && midElement == nums[mid+1])
                left=mid+1;   
        }
        return -1;
    }
}

//time: O(log(N))
//space: O(1)
