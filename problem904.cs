/*

[1,2,1]

num1=1, count1=2
num2=2, count2=1


[0,1,2,2]
num1=2, count1=1
num2=1, count2=0
result=3

[1,2,3,2,2]
num1=1, count1=0
num2=2, count2=2
result=4


*/


public class Solution {
    public int TotalFruit(int[] fruits) {
        int left=0, right=0;
        int result=0;
        int? num1=null;
        int? num2=null;
        int count1=0, count2=0;
        
        while(left<=right && right<fruits.Length)
        {
            if(num1!=null && fruits[right]==num1)
            {
                count1++;
                right++;
            }
            else if(num2!=null && fruits[right]==num2)
            {
                count2++;
                right++;
            }
            else if(count1==0)
            {
                num1=fruits[right];
                count1++;
                right++;
            }
            else if(count2==0)
            {
                num2=fruits[right];
                count2++;
                right++;
            }
            else
            {
                result=Math.Max(result, count1+count2);
                if(fruits[left]==num1)
                {
                    count1--;
                }
                else
                {
                    count2--;
                }
                left++;
            }
        }
        
        result=Math.Max(result, count1+count2);
        
        return result;
        
        
    }
}

//time: O(N)
//space: O(1)