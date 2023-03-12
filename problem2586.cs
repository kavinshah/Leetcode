public class Solution {
    public int VowelStrings(string[] words, int left, int right) {
        int result=0;
        for(int i=left; i<=right; i++){
            if(IsVowel(words[i][0]) && IsVowel(words[i][words[i].Length-1]))
                result++;
        }
        
        return result;
    }
    
    public bool IsVowel(char input){
        return input=='a' || input == 'e' || input == 'i' || input == 'o' || input == 'u';
    }
}

//time: O(N)
//space: O(1)