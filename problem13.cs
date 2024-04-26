/*

LVIII
50 + 5 + 3 = 58

MCMXCIV
1000 + 900 + 90 + 4 = 1994

DCCCXCIX
i=0, prev=500
i=1, prev=100, curr=100, result = 500
i=2, prev=100, curr=100, result = 600
i=3, prev=100, curr=100, result = 700
i=4, prev=10, curr=10, result = 800
i=5, prev=100, curr=100, result = 790
i=6, prev=1, curr=1, result = 890
i=7, prev=10, curr=10, result = 889
i=8, result=899

*/


public class Solution {
    public int RomanToInt(string s) {
        int result=0;
        int prev=RomanToInt(s[0]);
        for(int i=1; i<s.Length; i++){
            int current = RomanToInt(s[i]);
            if(current>prev){
                result += -prev;
            } else {
                result += prev;
            }
            prev = current;
        }
        
        result+= prev;
        return result;
    }
    
    public int RomanToInt(char c){
        switch(c){
            case 'M':
                return 1000;
            case 'D':
                return 500;
            case 'C':
                return 100;
            case 'L':
                return 50;
            case 'X':
                return 10;
            case 'V':
                return 5;
            case 'I':
                return 1;
        }
        return 0;
    }
}

//time: O(N)
//space: O(1)