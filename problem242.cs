public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] counts = new int[26];
        
        if(s.Length!=t.Length)
            return false;
        
        for(int i=0; i<s.Length; i++)
        {
            counts[s[i]-'a']++;
            counts[t[i]-'a']--;
        }
        
        for(int i=0; i<26; i++)
        {
            if(counts[i]!=0)
                return false;
        }
        
        return true;
        
    }
}

//Time: O(N)
//space: O(1)
