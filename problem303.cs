public class NumArray {
    int[] nums;
    public NumArray(int[] nums) {
        this.nums = nums;
        for(int i=1; i<nums.Length; i++)
            this.nums[i] += this.nums[i-1];
    }
    
    public int SumRange(int left, int right) {
        if(left==0)
            return nums[right];
        return nums[right]-nums[left-1];
    }
}
/*

Time: O(1)

Space: O(N)
*/

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */