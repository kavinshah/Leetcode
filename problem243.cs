public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        int distance=wordsDict.Length;
        List<int> d1=new List<int>();
        List<int> d2=new List<int>();
        
        for(int i=0; i<wordsDict.Length; i++)
        {
            if(wordsDict[i]==word1)
                d1.Add(i);
            
            if(wordsDict[i]==word2)
                d2.Add(i);
            
            if(d1.Count>0 && d2.Count>0)
                distance=Math.Min(distance, Math.Abs(d1[^1]-d2[^1]));
            
        }
        
        return distance;
        
    }
}

//Time: O(N)
//space: O(N)