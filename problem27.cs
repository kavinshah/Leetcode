/*

[3,2,2,3], val=3

k=0, right=3, nums=[3,2,2,3]
k=0, right=2, nums=[3,2,2,3]
k=0, right=1, nums=[2,2,3,3]
k=1, right=1, nums=[2,2,3,3]
k=2, right=1, nums=[2,2,3,3]

*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int right=nums.Length-1;
        int k=0;
        while(k<=right)
        {
            if(nums[k]==val)
            {
                int temp=nums[right];
                nums[right]=nums[k];
                nums[k]=temp;
                right--;
            }
            else
            {
                k++;
            }
        }
        
        return k;
    }
}

//time: O(N)
//space: O(1)
