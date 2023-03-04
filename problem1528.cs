public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] result = new char[indices.Length];
        
        for(int i=0; i<indices.Length; i++)
        {
            result[indices[i]] = s[i];
        }
        
        return String.Join("", result);
    }
}

// Time: O(N)
//Space: O(1)