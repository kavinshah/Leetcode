public class Solution {
    public int NumKLenSubstrNoRepeats(string s, int k) {
        
        if(s.Length < k)
            return 0;
        
        Dictionary<char, int> visited=new Dictionary<char, int>();
        int count=0;
        
        for(int i=0; i<k; i++)
        {
            if(!visited.ContainsKey(s[i]))
            {
                visited.Add(s[i], 0);
            }
            visited[s[i]]++;
        }
        if(CheckCounts(visited))
        {
            count++;
        }
        for(int i=k; i<s.Length; i++)
        {
            visited[s[i-k]]--;
            if(!visited.ContainsKey(s[i]))
            {
                visited.Add(s[i], 0);
            }
            visited[s[i]]++;
            
            if(CheckCounts(visited))
            {
                count++;
            }
        }
        
        return count;
    }
    
    public bool CheckCounts(IDictionary<char, int> visited)
    {
        foreach(char c in visited.Keys)
        {
            if(visited[c]>1)
            {
                return false;
            }
        }
        
        return true;
    }
}

//time: O(N)
//space: O(N)