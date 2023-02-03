public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] items1 = new int[26];
        int[] items2;
        int currentIndex = 0;
        if(s1.Length > s2.Length){
            return false;
        }
        for(int i=0;i<s1.Length;i++){
            items1[s1[i]-'a'] += 1;
        }
        while(currentIndex < s2.Length){
            items2=new int[26];
            int end = Math.Min(s2.Length, currentIndex+s1.Length);
            for(int i=currentIndex; i<end; i++){
                items2[s2[i]-'a'] += 1;
            }
            if (Compare(items1, items2)){
                return true;
            }
            currentIndex++;
        }
        return false;
    }
    
    public bool Compare(int[] x, int[] y)
    {
        for(int i =0; i<26;i++){
            if(x[i]!=y[i]){
                return false;
            }
        }
        return true;
    }
}

// time: O(MN)
// space: O(M+N)