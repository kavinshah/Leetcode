public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        Dictionary<string, int> hashmap = new Dictionary<string,int>();
        List<string> result=new List<string>();
        
        foreach(string s in s1.Split(' '))
        {
            if(!hashmap.ContainsKey(s))
                hashmap[s]=0;
            hashmap[s]++;
        }
        
        foreach(string s in s2.Split(' '))
        {
            if(!hashmap.ContainsKey(s))
                hashmap[s]=0;
            hashmap[s]++;
        }
        
        foreach(var kvp in hashmap)
        {
            if(hashmap[kvp.Key] == 1)
            {
                result.Add(kvp.Key);
            }
        }
        
        return result.ToArray();
    }
}

//time: O(N)
//space: O(N)

