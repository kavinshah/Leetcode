/*

[1,4,3,2]

sort the numbers and then add up alternate numbers starting from index n-2 all the way to 0 skipping 1 number
[4,3],[1,2]
3+1=4

[6,2,6,5,1,2]
[6,6],[5,2],[2,1]
6+2+1=9

Time = nlogn+n=O(nlogn)

----------------------------------------------------------

max heap

construction : nlogn
summing: nlogn
time: O(nlogn)




*/

public class Solution {
    public int ArrayPairSum(int[] nums) {
        int sum=0;
        Array.Sort(nums);
        //Console.WriteLine(String.Join(",", nums));
        for(int i=0;i<nums.Length; i+=2){
            sum+=nums[i];
        }
        return sum;
    }
}