public class Solution {
    string input;
    int longestSubstringLength = 0;
    string longestSubstring="";
    
    public string LongestPalindrome(string s) {
        input = s;
        
        for(int i=0; i<s.Length; i++)
        {
            for(int j=s.Length-i; j>longestSubstringLength; j--)
            {
                if(CheckPalindrome(i, j))
                {
                    longestSubstringLength = Math.Max(longestSubstringLength, j);
                    longestSubstring = input.Substring(i, j);
                    break;
                }
            }
        }
        return longestSubstring;
    }

    public bool CheckPalindrome(int startIndex, int length)
    {
        int endIndex = startIndex+length-1;
        
        while(startIndex<=endIndex)
        {
            if(input[startIndex]!=input[endIndex])
                return false;
            startIndex++;
            endIndex--;
        }
        return true;
    }

}

//time: O(N^2*K) -- N=length of input, K=length of longest palindrome
//space: O(1)
