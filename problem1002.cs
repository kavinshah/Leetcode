public class Solution {
    public IList<string> CommonChars(string[] words) {
        int[][] counts = new int[words.Length][];
        IList<string> result=new List<string>();
        
        for(int i=0; i<words.Length; i++)
        {
            counts[i]=new int[26];
            foreach(char c in words[i])
            {
                counts[i][c-'a']++;
            }
        }
        
        for(int i=0; i<26; i++)
        {
            int minCount=Int32.MaxValue;
            for(int j=0; j<words.Length; j++)
            {
                minCount=Math.Min(minCount, counts[j][i]);
            }
            
            for(int j=0; j<minCount;j++)
            {
                char currentChar = (char)(i+'a');
                result.Add(currentChar.ToString());
            }
        }
        
        return result;
    }
}

//time: O(MN)
//space: O(M)