/*

2/3n+2
you can have only 2 elements that appear more than n/3 times in the array

[3,2,3,3,5,4,3,5,2]

first=3
count1=1
second, count2=0;
first=3, count1=1, second=2, count2=1
first=3, count1=2, second=2, count2=1
first=3, count1=3, second=2, count2=1
first=3, count1=3, second=2, count2=1
first=3, count1=3, second=2, count2=0
first=3, count1=3, second=4, count2=1
first=3, count1=4, second=4, count2=1
first=3, count1=4, second=4, count2=0
first=3, count1=4, second=2, count2=1


total=9
min=9/3=3

[3,2,3,3,2,2,3,5,2]
first=3, count1=1, second=2, count2=1
first=3, count1=2, second=2, count2=1
first=3, count1=3, second=2, count2=1
first=3, count1=3, second=2, count2=1



*/

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        IList<int> result = new List<int>();
        int? first=null, second=null;
        int count1=0, count2=0;
        
        for(int i=0; i<nums.Length; i++)
        {
            if(count1==0 && (second==null || nums[i]!=second))
            {
                first=nums[i];
                count1=1;
            }
            else if(count2==0 && (first==null || nums[i]!=first))
            {
                second=nums[i];
                count2=1;
            }
            else if(nums[i]==first)
            {
                count1++;
            }
            else if(nums[i]==second)
            {
                count2++;
            }
            else
            {
                count1--;
                count2--;
            }
        }
        
        count1=0;
        count2=0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]==first)
                count1++;
            if(nums[i]==second)
                count2++;
        }
        
        if(count1 > (int)(nums.Length/3))
            result.Add((int)first);
        
        if(count2 > (int)(nums.Length/3))
            result.Add((int)second);
        
        return result;
    }
}

//time:O(N)
//space: O(1)