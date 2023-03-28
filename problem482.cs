public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        StringBuilder result = new StringBuilder();
        int currentLength=0;
        for(int i=s.Length-1; i>-1; i--)
        {
            if(s[i]!='-')
            {
                result.Insert(0, Char.ToUpper(s[i]));
                currentLength++;
            }
            if(currentLength == k)
            {
                //append dash for in between groups
                result.Insert(0,'-');
                currentLength=0;
            }
        }
        
        if(result.Length>0 && result[0]=='-')
            result.Remove(0,1);
        
        return result.ToString();
    }
}

//time: O(N)
//space: O(1)