public class Solution {
    string needle;
    string haystack;
    public int StrStr(string haystack, string needle) {
        this.needle=needle;
        this.haystack = haystack;
        int[] lps = ComputeLps(needle);
        //Console.WriteLine(String.Join(",", lps));
        //return -1;
        return FindNeedleInHaystack(haystack, needle, lps);
    }
    
    public int[] ComputeLps(string needle)
    {
        int[] lps = new int[needle.Length];
        int index=1;
        int previousLps = 0;
        
        while(index<needle.Length) {
            if(needle[previousLps]==needle[index]) {
                previousLps+=1;
                lps[index]=previousLps;
                index++;
            } else if(previousLps==0){
                lps[index]=0;
                index++;
            } else{
                previousLps = lps[previousLps-1];
            }
        }
        return lps;
    }
    
    public int FindNeedleInHaystack(string haystack, string needle, int[] lps)
    {
        int i=0;
        int j=0;
        
        while(i<haystack.Length && j<needle.Length){
            
            if(haystack[i]==needle[j]){
                i++;
                j++;
            } else if(j==0) {
                i+=1;
            } else {
                j = lps[j-1];
            }
        }
        
        if(j==needle.Length)
            return i-needle.Length;
        return -1;
    } 
}

//Time: O(M+N)
//Space: O(1)
