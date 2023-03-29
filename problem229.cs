/*

if n%3==0, should it be >n/3 or >=n/3?
-- >n/3. Refer eg. 1
*/


public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int? val1=null, val2=null;
        int count1=0, count2=0;
        List<int> result=new List<int>();
        int limit=((int)nums.Length/3) + 1;
        
        for(int i=0; i<nums.Length; i++)
        {
            if(val1!=null && val1==nums[i])
            {
                count1++;
            }
            else if(val2!=null && val2==nums[i])
            {
                count2++;
            }
            else if(count1==0)
            {
                val1=nums[i];
                count1++;
            }
            else if(count2==0)
            {
                val2=nums[i];
                count2++;
            }
            else // this condition is very important for test cases: 7,7,8,8,9,3,9,3,9,3,9,3
            {
                count1--;
                count2--;
            }
        }
        
        count1=0;
        count2=0;
        
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]==val1)
            {
                count1++;
            }
            else if(nums[i]==val2)
            {
                count2++;
            }
        }
        
        //Console.WriteLine($"{val1},{val2}, {count1}, {count2}");
        
        if(count1>=limit)
            result.Add(val1??0);
        if(count2>=limit)
            result.Add(val2??0);
        
        return result;
    }
}

//time: O(N)
//space: O(1)