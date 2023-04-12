public class Solution {
    int result=0;
    string longestString="";
    string s;
    
    public string LongestPalindrome(string s) {
        this.s=s;
        for(int i=0; i<s.Length; i++)
        {
            for(int j=i+result; j<s.Length; j++)
            {
                if(IsPalinrome(i,j) && (j-i+1)>result)
                {
                    longestString=s.Substring(i,j-i+1);
                    result=j-i+1;
                }
            }
        }
        return longestString;
    }
    
    public bool IsPalinrome(int start, int end)
    {
        while(start<=end)
        {
            if(s[start]!=s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }
}

// len=5.
// eg. aaaaa
//i=0, total=5, 1+2+3+4+5
//i=1, total=0
//i=2, total=0
//i=3, total=0
//i=4, total=0

//eg=abcde
// i=0, total=5. 1+1+1+1+1
// i=1, total=4. 1+1+1+1
// i=2, total=3. 1+1+1
// i=3, total=2. 1+1
// i=4, total=1. 1

//I think the time complexity is O(N^2) but looking at the code there are 3 loops and it leads to O(N^3)

//Time: O(N^2)
//space: O(1)