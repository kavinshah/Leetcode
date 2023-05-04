public class Solution {
    IList<string> result=new List<string>();
    int n;
    public IList<string> GenerateParenthesis(int n) {
        this.n=n;
        Generate("", 0, 0);
        return result;
    }
    
    public void Generate(string current, int open, int close)
    {
        if(open==n && close==n)
        {
            result.Add(current);
            return;
        }
        if(open<n)
        {
            Generate(current+"(", open+1, close);
        }
        if(close<open)
        {
            Generate(current+")", open, close+1);
            return;
        }
    }
}

//Time: O(2^n)
//Space: O(2^n)