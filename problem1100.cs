public class Solution {
    public int NumKLenSubstrNoRepeats(string s, int k) {
        
        if(s.Length < k)
            return 0;
        
        IDictionary<char, int> visited=new Dictionary<char, int>();
        int count=0;
        
        for(int i=0; i<k; i++)
        {
            if(!visited.ContainsKey(s[i]))
            {
                visited.Add(s[i], 0);
            }
            visited[s[i]]++;
        }
        if(visited.Count==k)
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
            
            if(visited[s[i-k]]==0)
            {
                visited.Remove(s[i-k]);
            }
            if(visited.Count == k)
            {
                count++;
            }
        }
        return count;
    }
}

//time: O(N)
//space: O(N)