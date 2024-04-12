/*

[2,3,2]

i=0, max=2
i=1, max=3
i=2, max=2

[1,2,3,1]
i=0, max=1
i=1, max=2
i=2, max=4
i=3, max=4

[1,2,3,2,4]
i=0, max=1
i=1, max=2
i=2, max=4
i=3, max=4
i=4, max=4+4-1, 4=7

[1,2,3,2,4]


[9,5,3,4]
    [4,9,5,3] = 12
    [5,3,4,9] = 12

maybe use a hashset of elements in the set for i-1 and i-2 indexes
[1,2,3,2,4,6]
i=0, max=1, hashset=0
i=1, max=2, hashset=1
i=2, max=4, hashset=0,2
i=3, max=4, hashset=[(0,2), (1,3)]
i=4, max=8, hashet=0,2,4
i=5, max=10, hashset=1,3,5

dp[i] = max(d[i-1], dp[i-2]+nums[i]) --- when i<nums.Length
      = max(dp[i-1], dp[i-2]+nums[i]) -- when dp[i-2] does not contain first element
      = max(dp[i-1], dp[i-2]+nums[i]-nums[0]) --- when dp[i-2] contains the first element
      = nums[0]                        -- when i=0
      = max(nums[0], nums[1])          -- when i=1
      

[2,2,4,3,2,5]
 0 1 2 3 4 5

dp(5, yes) = dp(4, yes), dp(3, no)+5 = 6, 5+5 = 10
dp(4, yes) = dp(3, yes), dp(2, yes)+2 = 5, 6 = 6
dp(3, yes) = dp(2, yes), dp(1, yes)+3 = 4,5 = 5
dp(2, yes) = dp(1, yes), dp(0, no)+4 = 4
dp(1, yes) = 2
dp(0, no) = 0
dp(1, no) = 2
dp(2, no) = dp(1, no), dp(0, no)+4 = 2,4 = 4
dp(3, no) = dp(2, no), dp(1, no)+3 = 4, 5 = 5
dp(2, no) = dp(1, no), dp(0, no)+4 = 2, 4 = 4


[1,2,3,1]
 0 1 2 3
 
dp(3, yes) = dp(2, yes), dp(1, no)+1 = 4, 2+1 = 4
dp(2, yes) = dp(1, yes), dp(0, yes)+3 = 2, 4 = 4
dp(1, yes) = 2
dp(0, yes) = 1
dp(1, no) = 2


*/

public class Solution {
    Dictionary<(int, bool), int> maxAmount = new Dictionary<(int, bool), int>();
    int[] nums;
    public int Rob(int[] nums) {
        
        if(nums.Length==1)
            return nums[0];
        if(nums.Length==2)
            return Math.Max(nums[0], nums[1]);
        
        this.nums = nums;
        maxAmount[(0, true)]=nums[0];
        maxAmount[(0, false)]=0;
        maxAmount[(1, true)] = Math.Max(nums[0], nums[1]);
        maxAmount[(1, false)] = nums[1];
        return Math.Max(FindHouses(nums.Length-2, true), FindHouses(nums.Length-3, false)+nums[nums.Length-1]);
    }
    
    public int FindHouses(int index, bool includeFirstElement)
    {
        if(index<0)
            return 0;
        
        if(maxAmount.ContainsKey((index, includeFirstElement)))
            return maxAmount[(index, includeFirstElement)];
        
        maxAmount[(index, includeFirstElement)] = Math.Max(FindHouses(index-1, includeFirstElement), FindHouses(index-2, includeFirstElement)+nums[index]);
        
        return maxAmount[(index, includeFirstElement)];
         
    }
    
}

//Time: O(N)
//Space: O(N)
