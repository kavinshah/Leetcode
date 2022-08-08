/*

1,2,3,4

1,2,6,24

1*24,1*12,2*4,6

i=3, currp=1, prefix=[1,2,6,24], res = [0,1*12,2*1*4,6*1]


*/   

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int currentproduct = 1;
        int[] prefix = new int[nums.Count()];
        int[] result = new int[nums.Count()];
        prefix[0]=nums[0];
        for(int i=1; i<nums.Length; i++)
        {
            prefix[i]=prefix[i-1]*nums[i];
            //Console.WriteLine("{0}, {1}", i, prefix[i]);
        }
        
        for(int i= nums.Count()-1; i>=1; i--)
        {
            result[i]=prefix[i-1]*currentproduct;
            //Console.WriteLine("{0}, {1}, {2}, {3}", i, result[i], currentproduct, prefix[i-1]);
            currentproduct*=nums[i];
        }
        result[0]=currentproduct;
        return result;
    }
}