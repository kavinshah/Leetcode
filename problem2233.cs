/*

[0 4]
increase the smallest number by k and find the product

[6 3 3 2]
increase 2 by 1

feels like using a min heap and use the smallest element increase it by 1.
time: O((N+k)logN)
space: O(N)
This is very mechanical

[6 3 3 2]
2   3   3   6
----------------------

Let's try in O(N) time.

[6 3 3 2]
6*3*3*2

*/

public class Solution {
    public int MaximumProduct(int[] nums, int k) {
        Array.Sort(nums);
        //Console.WriteLine(String.Join(",", nums));
        int curr=0;
        long product=1;
        while(k>0){
            while((curr+1)<nums.Length && nums[curr]==nums[curr+1]){
                curr++;
            }
            nums[curr]++;
            if((curr-1)>=0 && nums[curr]>nums[curr-1]){
                curr--;
            }
            k--;
        }
        //Console.WriteLine("{0}, {1}, {2}", String.Join(",", nums), k, curr);
        foreach(int n in nums){
            product=(product*n)%1000000007;
        }
        
        return (int)product;
    }
}

//time: O(N)
//Space: O(1)