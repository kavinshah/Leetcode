/*

a=2
b=2

a=2
b=1

a=4
b=4
c=4
d=4

aabaabaab

a=6
b=3
true

aabaab
a=4
b=2

abba




*/


public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        
        StringBuilder sb=new StringBuilder("");
        for(int i=0; i<s.Length; i++)
        {
            sb=sb.Append(s[i]);
            int j=i+1;
            int counter=0;
            while((j+sb.Length)<=s.Length)
            {
                string local=s.Substring(j, sb.Length);
                if(!sb.Equals(local))
                    break;
                j=j+sb.Length;
                counter++;
            }
            if(j==s.Length && counter>0)
                return true;
        }
        return false;
    }
}

//time: O(kM^2)
//space: O(k)