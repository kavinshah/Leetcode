/*
 0 1 2 3 4
[5,6,7,8,9]



target=35-4=31

currsum=5, left=0, right=1, maxlength=-1
currsum=11,left=0, right=2, maxlength=-1
currsum=18,left=0, right=3, maxlength=-1
currsum=26,left=0, right=4, maxlength=-1
currsum=35,left=0, right=5, maxlength=-1

 0 1 2  3 4 5
[3,2,20,1,1,3]

target=30-10=20

currsum=3, left=0, right=1, maxlength=-1
currsum=5, left=0, right=2, maxlength=-1
currsum=25, left=0, right=3, maxlength=-1
currsum=22, left=1, right=3, maxlength=-1
currsum=20, left=2, right=3, maxlength=1
currsum=0, left=3, right=3, maxlength=1
currsum=1, left=3, right=4, maxlength=1
currsum=2, left=3, right=5, maxlength=1
currsum=5, left=3, right=6, maxlength=1

*/

public class Solution {
    public int MinOperations(int[] nums, int x) {
        long totalsum=0;
        int maxLength;
        
        foreach(int n in nums)
        {
            totalsum+=n;
        }
        
        if(x>totalsum) return -1;
        
        maxLength = MaxLengthSubarray(nums, totalsum-x);
        
        if(maxLength==-1)
            return -1;
        
        return nums.Length-maxLength;
        
    }
    
    public int MaxLengthSubarray(int[] nums, long target)
    {
        int maxLength=-1;
        int left=0, right=0;
        long currsum=0;
        
        while(right<nums.Length)
        {
            if(currsum<target)
            {
                currsum+=nums[right];
                right++;
            }
            else
            {
                currsum-=nums[left];
                left++;
            }
            
            if(currsum==target)
            {
                maxLength=Math.Max(maxLength, right-left);
            }
        }
        
        while(currsum>target)
        {
            currsum-=nums[left];
            left++;
            if(currsum==target)
                maxLength=Math.Max(maxLength, right-left);
        }
        
        return maxLength;
    }
}

//time: O(N)
//space: O(1)