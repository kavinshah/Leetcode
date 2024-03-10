public class Solution {
    public string ReverseWords(string s) {
        Stack<string> result = new Stack<string>();
        foreach(string word in s.Trim().Split(" "))
        {
            if(word.Length>0)
                result.Push(word);
        }
        return String.Join(" ", result);
    }
}

//time: O(MN)
//Space: O(MN)