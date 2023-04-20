public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        int p1=0, p2=wordsDict.Length-1;
        int distance=wordsDict.Length;
        
        for(int i=0; i<wordsDict.Length; i++)
        {
            if(wordsDict[i]!=word1)
                continue;
            for(int j=0; j<wordsDict.Length; j++)
            {
                if(wordsDict[j]==word2)
                    distance=Math.Min(distance, Math.Abs(i-j));
            }
        }
        
        return distance;
        
    }
}

//Time: O(N^2)
//space: O(1)