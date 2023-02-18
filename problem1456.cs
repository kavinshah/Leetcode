public class Solution {
    public int MaxVowels(string s, int k) {
        int count=0;
        int maxresult=0;
        HashSet<char> vowels = new HashSet<char>(){'a', 'e','i','o','u'};
        
        for(int i=0; i<k; i++)
        {
            if(vowels.Contains(s[i]))
            {
                count++;
            }
        }
        maxresult=count;
        for(int i=k; i<s.Length; i++)
        {
            
            if(vowels.Contains(s[i-k]))
            {
                count--;
            }
            
            if(vowels.Contains(s[i]))
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