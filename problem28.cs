public class Solution {
    string needle;
    string haystack;
    public int StrStr(string haystack, string needle) {
        this.needle=needle;
        this.haystack = haystack;
        
        for(int i=0; i<=haystack.Length-needle.Length; i++)
        {
            if(CheckNeedleInStack(i))
                return i;
        }
        
        return -1;
    }
    
    public bool CheckNeedleInStack(int start)
    {
        int index=0;
        while(index<needle.Length)
        {
            if(haystack[index+start]!=needle[index])
                return false;
            index++;
        }
        return true;
    }
}

//time: O(MN)
//space: O(1)