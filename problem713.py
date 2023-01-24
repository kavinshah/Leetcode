/*

-> result=-1
-> l=0, r=0
-> while(l<=r)
-> currsum=currsum*nums[r]
-> if currsum<k, result = result+1, r=r+1
-> else currsum = currsum/nums[l], l=l+1 and l<len(nums) also result=result + (r-l+1)

[10,5,2,6], k=100

l=-1, r=-1
l=0, r=0, product = 10, result = 1
l=0, r=1, product = 50, result = 2
l=0, r=2, product = 100, result = 2
l=1, r=2, product = 10, result = 4
l=1, r=3, product = 60, result = 5
l=1, r=4, exit
l=2, r=3, product = 12, result = 7
l=3, r=3, product = 6, result = 8

[10,5,2,6]

10
10 5
10 5 2 --
5 2    -- [5], [5,2]
5 2 6  -- []


*/

public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        
        if(k<=1)
        {
            return 0;
        }
        
        int result = 0;
        int l=0,r;
        long product=1;
        for(r=0; r<nums.Length; r++)
        {
            product=product*nums[r];
            while(product>=k)
            {
                product=(int)product/nums[l];
                l+=1;
            }
            result=result+r-l+1;
        }
        return result;
    }
}