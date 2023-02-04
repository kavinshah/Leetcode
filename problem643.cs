public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double totalSum=0.0;
        double average = 0.0;
        for(int i=0; i<k;i++){
            totalSum+=nums[i];
        }
        average = (double)totalSum/k;
        for(int i=k; i<nums.Length; i++) {
            totalSum += nums[i];
            totalSum -= nums[i-k];
            average = Math.Max(average, (double)totalSum/k);
        }
        
        return average;
    }
}

//Time: O(n)
//space: O(1)