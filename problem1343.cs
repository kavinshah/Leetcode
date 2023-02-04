public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        double currentSum=0;
        double average=0;
        int count=0;
        
        for(int i=0; i<k; i++){
            currentSum+=arr[i];
        }
        
        if(currentSum >= threshold*k){
            count++;
        }
        
        for(int i=k; i<arr.Length; i++){
            currentSum += arr[i];
            currentSum -= arr[i-k];
            if(currentSum >= threshold*k){
                count++;
            }
        }
        return count;
        
    }
}

//time= O(N)
//space=O(1)