public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length != goal.Length)
            return false;
        return ((s+s).Contains(goal));
    }
}

//time: O(N^2)
//space: O(N)