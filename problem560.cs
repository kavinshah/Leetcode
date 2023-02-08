/*

[1 2 3 4 -7 3 3], k=3, complement={0:1}
i=0, currsum=1, complement={0:1, 1:0}, result=0
i=1, currsum=3, complement={0:1, 1:0, 3:1}, result=1
i=2, currsum=6, complement={0:1, 1:0, 3:1, 6:1}, result=2
i=3, currsum=10, complement={0:1, 1:0, 3:1, 6:1, 10:1}, result=2
i=4, currsum=3, complement={0:1, 1:0, 3:2, 6:1, 10:1}, result=3
i=5, currsum=6, complement={0:1, 1:0, 3:2, 6:2, 10:1}, result=5
i=6, currsum=9, complement={0:1, 1:0, 3:2, 6:2, 10:1, 9:1}, result=7

*/

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int currsum=0;
        int result=0;
        
        Dictionary<int, int> complement=new Dictionary<int, int>(20000);
        complement[0]=1;
        for(int i=0; i<nums.Length; i++){
            currsum+=nums[i];
            if(!complement.ContainsKey(currsum-k)){
                complement[currsum-k]=0;
            }
            result+=complement[currsum-k];
            if(!complement.ContainsKey(currsum)){
                complement[currsum]=0;
            }
            complement[currsum]++;
        }
        
        return result;
    }
}

//time: O(N)
//space: O(N)