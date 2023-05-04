public class Solution {
    IList<string> result=new List<string>();
    int n;
    public IList<string> GenerateParenthesis(int n) {
        this.n=n;
        Generate(new StringBuilder(), 0, 0);
        return result;
    }
    
    public void Generate(StringBuilder current, int open, int close)
    {
        if(open==n && close==n)
        {
            result.Add(current.ToString());
            return;
        }
        if(open<n)
        {
            Generate(current.Append("("), open+1, close);
            current.Remove(current.Length-1,1);
        }
        if(close<open)
        {
            Generate(current.Append(")"), open, close+1);
            current.Remove(current.Length-1,1);
        }
    }
}

//Time: O(2^n)
//Space: O(2^n)