/*

seems like dutch flag problem
 0 1 2 3 4 5
[2,0,2,1,1,0]

left=0, right=5, nums=[2,0,2,1,1,0]
left=1, right=4, nums=[0,0,2,1,1,2]
left=2, right=4, nums=[0,0,2,1,1,2]
left=3, right=4, nums=[0,0,1,1,2,2]
left=3, right=3, nums=[0,0,1,1,2,2]


[2,0,2,1,1,0,1,2,0]

left=0, right=8, curr=0, nums=[2,0,2,1,1,0,1,2,0]
left=0, right=7, curr=0, nums=[0,0,2,1,1,0,1,2,2]
left=1, right=7, curr=1, nums=[0,0,2,1,1,0,1,2,2]
left=2, right=7, curr=2, nums=[0,0,2,1,1,0,1,2,2]
left=2, right=6, curr=2, nums=[0,0,2,1,1,0,1,2,2]
left=2, right=6, curr=2, nums=[0,0,1,1,1,0,2,2,2]
left=2, right=6, curr=3, nums=[0,0,1,1,1,0,2,2,2]
left=2, right=6, curr=4, nums=[0,0,1,1,1,0,2,2,2]
left=2, right=6, curr=5, nums=[0,0,1,1,1,0,2,2,2]
left=3, right=6, curr=6, nums=[0,0,0,1,1,1,2,2,2]


*/

public class Solution {
    public void SortColors(int[] nums) {
        int left=0, right=nums.Length-1;
        int curr=0;
        
        while(curr<=right)
        {
            if(nums[curr]==0)
            {
                //swap left and curr
                int temp=nums[left];
                nums[left]=nums[curr];
                nums[curr]=temp;
                //move both to right
                left++;
                curr++;
            }
            else if(nums[curr]==2)
            {
                //swap right and curr
                int temp=nums[curr];
                nums[curr]=nums[right];
                nums[right]=temp;
                //move right
                right--;
            }
            else
            {
                //move curr to right
                curr++;
            }
        }
        
    }
}

//time: O(N)
//space: O(1)