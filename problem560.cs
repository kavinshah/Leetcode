/*

[1,1,1]
currsum=0, {0:1}
currsum=1, {0:1, 1:1}, count=0
currsum=2, {0:2, 1:1}, count=1
currsum=3, {0:2, 1:2}, count=2

[1,2,3]
currsum=0, count=0, {0:1}
currsum=1, count=0, {0:1, 1:1}
currsum=3, count=1, {0:2, 1:0, 2:0}
currsum=6, count=3, {0:3, 1:0, 2:0}

[1 2 3], k=3
complement={2:0}, [1]
complement={2:0, 0:1}, [1  3]
complement={2:0, 0:1, }, [1  3]

*/

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int currsum=0;
        int result=0;
        
        Dictionary<int, int> frequency=new Dictionary<int, int>(10000);
        frequency[0]=1;
        for(int i=0; i<nums.Length; i++){
            currsum+=nums[i];
            if(!frequency.ContainsKey(currsum-k)){
                frequency[currsum-k]=0;
            }
            result+=frequency[currsum-k];
            if(!frequency.ContainsKey(currsum)){
                frequency[currsum]=0;
            }
            frequency[currsum]++;
        }
        
        return result;
    }
}

//time: O(N)
//space: O(N)