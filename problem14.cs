public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int counter = 0;
        List<char> result=new List<char>();
        
        while(counter < strs[0].Length)
        {
            char current = strs[0][counter];
            for(int i=1; i<strs.Length; i++)
            {
                if(counter>=strs[i].Length || strs[i][counter] != current)
                    return String.Join("", result);
            }
            result.Add(current);
            counter++;
        }
        
        return String.Join("", result);
    }
}

//time : O(MN)
//space: O(N)