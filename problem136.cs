public class Solution {
    public int SingleNumber(int[] nums) {
        int xor=nums[0];
        for(int i=1; i<nums.Length; i++)
            xor=xor^nums[i];
        
        return xor;
    }
}
