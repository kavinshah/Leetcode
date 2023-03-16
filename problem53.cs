/*

  0 1  2 3  4 5 6  7 8
[-2,1,-3,4,-1,2,1,-5,4]

= max(currsum+maxsum(0)) -- if currsum>0

= maxsum(1) -------------------------if currsum <0,

i=-1, currsum=0, maxsum=-inf
i=0, currsum =-2, maxsum=-2
i=1, currsum=1, maxsum=1
i=2, currsum=-2, maxsum=1
i=3, currsum=4, maxsum=4
i=4, currsum=3, maxsum=4
i=5, currsum=5, maxsum=5
i=6, currsum=6, maxsum=6
i=7, currsum=1, maxsum=6
i=8, currsum=5, masum=6




*/

public class Solution {
    int[] nums;
    int result, currsum;
    
    public int MaxSubArray(int[] nums) {
        this.nums=nums;
        this.currsum=Int32.MinValue;
        this.result=currsum;
        MaxSubArray(0);
        return result;
    }
    
    public void MaxSubArray(int index)
    {
        if(index>=nums.Length)
            return;
        currsum= nums[index] + Math.Max(currsum,0);
        result=Math.Max(currsum, result);
        MaxSubArray(index+1);
        return;
    }
}

//time: O(N)
//space: O(1)