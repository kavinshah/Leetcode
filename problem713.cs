/*

k=100
10 5 2 6

10  5   2   6

i=0;currprod=10;count=1;start=0
i=1;currprod=50;count=3;start=0
i=2;currprod=10;count=5;start=1
i=3;currprod=60;count=8;start=1

k=0
1 2 3

i=0;currprod=1;start=0;count=0

*/

public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        
        if(k==0)
            return 0;
        long currprod=1;
        int count=0;
        int start=0;
        for(int i=0; i<nums.Length; i++){
            currprod*=nums[i];
            while(currprod>=k && start<=i){
                currprod=currprod/nums[start++];
            }
            if(start<=i){
                count+=(i-start+1);
            }
            //Console.WriteLine("i={0},currprod={1},count={2},start={3}",i,currprod,count,start);
        }
        return count;
    }
}

//time: O(N)
//space: O(1)