/*

                        -1,0,22
                    /   |       |           \
                0,1,21  1,5,17  2,11,11
            
                        
                                    0,0,11
                    /           |                  |            \
            1,1,10          2,2,9               3,3,8        4,5,6
    /          |     |        /    \               |            |
2,3,8       3,4,7  4,6,5  3,5,6 4,7,4           4,8,3           x
   /    \     |      |       |      |              |
3,6,5 4,8,3   4,9,2  x    4,11,0    x              x 
  |      |      |           |
4,11,0   x      x           x
  |
  x

               [4,4,4,4,4,4,4,4,8,8,8,8,8,8,8,8,12,12,12,12,12,12,12,12,16,16,16,16,16,16,16,16,20,20,20,20,20,20,20,20,24,24,24,24,24,24,24,24,28,28,28,28,28,28,28,28,32,32,32,32,32,32,32,32,36,36,36,36,36,36,36,36,40,40,40,40,40,40,40,40,44,44,44,44,44,44,44,44,48,48,48,48,48,48,48,48,52,52,52,52,52,52,52,52,56,56,56,56,56,56,56,56,60,60,60,60,60,60,60,60,64,64,64,64,64,64,64,64,68,68,68,68,68,68,68,68,72,72,72,72,72,72,72,72,76,76,76,76,76,76,76,76,80,80,80,80,80,80,80,80,84,84,84,84,84,84,84,84,88,88,88,88,88,88,88,88,92,92,92,92,92,92,92,92,96,96,96,96,96,96,96,96,97,99]
               
[2,2,3,4,5] = 16
[[2],[2,2],[2,2,3],[2,2,3,4],[2,2,3,4,5],[2]]


[2,3,4]
{[2],[2,3], [2,4], [2,3,4],[3],[3,4],[4]}


[2,2,3,4,5] = 16
target=8

i=0, sums = {0, 2, }
i=1, sums = {0, 2, 4}
i=2, sums = {0, 2, 4, 3,5,7}
i=3, sums = {0, 2, 4, 3, 5, 7, 4, 6, 8, 7, 9, 11}

               


*/

public class Solution {
    int target=0;
    HashSet<int> sums = new HashSet<int>(){0};
    public bool CanPartition(int[] nums) {
        foreach(int n in nums)
            target += n;
        
        if(target%2 == 1)
            return false;
        target=(int)(target/2);
        
        for(int i=0; i<nums.Length; i++){
            HashSet<int> newSums = new HashSet<int>();
            foreach(int s in sums){
                //Console.WriteLine(s+nums[i]);
                if((s+nums[i]) > target)
                    continue;
                if((s+nums[i])==target)
                    return true;
                newSums.Add((s+nums[i]));
            }
            
            foreach(int ns in newSums)
                sums.Add(ns);
        }
        return false;
    }
}


//time: O(n*sum(nums))
//space: O(sum(nums))