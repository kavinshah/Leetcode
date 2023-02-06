public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] items1 = new int[26];
        int[] items2 = new int[26];
        int currentIndex = 0;
        int matchCount = 0;
        
        if(s1.Length > s2.Length){
            return false;
        }
        for(int i=0;i<s1.Length;i++){
            items1[s1[i]-'a'] += 1;
            items2[s2[i]-'a'] += 1;
        }
        
        for(int i=0; i<26; i++){
            if (items1[i]==items2[i]){
                matchCount++;
            }
        }
        
        currentIndex = s1.Length;
        while(currentIndex < s2.Length){
            if(matchCount==26){
                Console.WriteLine("{0}, {1}", matchCount, currentIndex);
                Console.WriteLine(String.Join(",", items2));
                return true;
            }
            items2[s2[currentIndex]-'a'] += 1;
            if(items2[s2[currentIndex]-'a'] == items1[s2[currentIndex]-'a'])
            {
                matchCount++;
            } else if (items2[s2[currentIndex]-'a'] == (items1[s2[currentIndex]-'a'] + 1)) {
                matchCount--;
            }
            
            items2[s2[currentIndex-s1.Length]-'a'] -= 1;
            if(items2[s2[currentIndex-s1.Length]-'a'] == items1[s2[currentIndex-s1.Length]-'a'])
            {
                matchCount++;
            } else if (items2[s2[currentIndex-s1.Length]-'a'] == (items1[s2[currentIndex-s1.Length]-'a'] - 1)) {
                matchCount--;
            }
            currentIndex++;
        }
        
        //Console.WriteLine(matchCount);
        
        return (matchCount==26);
    }
}

// time: O(N)
// space: O(1)