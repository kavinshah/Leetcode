/*

if n%3==0, should it be >n/3 or >=n/3?
-- >n/3. Refer eg. 1
*/


public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        List<int> result=new List<int>();
        int limit=((int)nums.Length/3) + 1;
        for(int i=0; i<nums.Length; i++)
        {
            if(!count.ContainsKey(nums[i]))
                count[nums[i]]=0;
            count[nums[i]]++;
        }
        
        foreach(var kvp in count)
        {
            if(count[kvp.Key]>=limit)
                result.Add(kvp.Key);
        }
        
        return result;
    }
}
//time: O(N)
//space: O(N)