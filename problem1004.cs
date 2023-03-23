public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left=0;
        int right=0;
        int maxCount=0;
        int currCount=0;   
            
        while(left<=right && right<nums.Length)
        {
            if(nums[right]==1){
                currCount++;
                maxCount=Math.Max(currCount, maxCount);
                right++;
            }
            else if(left==right && k==0)
            {
                right++;
                left++;
            }
            else
            {
                if(k>0)
                {
                    k--;
                    currCount++;
                    maxCount=Math.Max(currCount, maxCount);
                    right++;
                }
                else
                {
                    if(nums[left]==0)
                    {
                        k++;
                    }
                    currCount--;
                    left++;
                }
            }
        }
        maxCount=Math.Max(maxCount, currCount);
        return maxCount;
        
    }
}

//time: O(N)
//space: O(1)