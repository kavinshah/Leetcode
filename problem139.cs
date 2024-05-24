public class Solution {
    string s;
    IList<string> wordDict;
    int[] dp;
    public bool WordBreak(string s, IList<string> wordDict) {
        this.s = s;
        this.wordDict = wordDict;
        this.dp = new int[s.Length];
        return FindSegment(0);
    }
    
    public bool FindSegment(int index)
    {
        if(index==s.Length)
        {
            return true;
        }
        
        if(dp[index]!=0)
        {
            return dp[index]==1?true:false;
        }
        
        StringBuilder sb = new StringBuilder();
        for(int i=index; i<s.Length; i++)
        {
            sb.Append(s[i]);
            if(!wordDict.Contains(sb.ToString()))
            {
                continue;
            }
            if(FindSegment(i+1))
            {
                dp[index]=1;
                return true;
            }
        }
        
        dp[index]=-1;
        return false;
    }
}