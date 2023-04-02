/*

s = "00111"
ans=4


s= "00011"
ans=4


*/

public class Solution {
    int count0=0, count1=0;
    int result;
    int right=0, left=0;
    char prev='0';
        
    public int FindTheLongestBalancedSubstring(string s) {
        while(right<s.Length && left<=right)
        {
            if(s[right]=='0' && prev=='0')
            {
                count0++;
            }
            else if(s[right]=='1')
            {
                count1++;
            }
            else if(s[right]=='0' && prev=='1')
            {
                result=Math.Max(result, 2*Math.Min(count0, count1));
                count0=1;
                count1=0;
                left=right;
            }
            prev=s[right];
            right++;
        }
        result=Math.Max(result, 2*Math.Min(count0, count1));
        return result;
    }
}

//time: O(N)
//space: O(1)
//sliding window