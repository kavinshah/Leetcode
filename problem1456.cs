public class Solution {
    public int MaxVowels(string s, int k) {
        int count=0;
        int maxresult=0;
        for(int i=0; i<k; i++)
        {
            if(s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u')
            {
                count++;
            }
        }
        maxresult=count;
        for(int i=k; i<s.Length; i++)
        {
            
            if(s[i-k]=='a' || s[i-k]=='e' || s[i-k]=='i' || s[i-k]=='o' || s[i-k]=='u')
            {
                count--;
            }
            
            if(s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u')
            {
                count++;
            }
            maxresult=Math.Max(maxresult, count);
        }
        
        return maxresult;
    }
}

//time: O(N)
//space: O(1)