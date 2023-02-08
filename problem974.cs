/*

[4 5 0 -2 -3 1]

negative numbers and so cannot use sliding window approach
lets use prefix approach. Not sure how that works though

[4] [4 5]

*/

public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int count=0;
        int currsum=0;
        Dictionary<int, int> frequency = new Dictionary<int, int>(100000);
        frequency[0]=1;
        int mod;
        foreach(int num in nums){
            currsum+=num;
            mod=((currsum%k)+k)%k;
            if(!frequency.ContainsKey(mod)){
                frequency[mod]=0;
            }
            count+=frequency[mod];
            frequency[mod]++;
        }
        return count;
    }
}

//time: O(N)
//space: O(N)