/*



*/

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> romanToInt = new Dictionary<string, int>();
        int i=0;
        int result=0;
        
        romanToInt.Add("IV", 4);
        romanToInt.Add("IX", 9);
        romanToInt.Add("XL", 40);
        romanToInt.Add("XC", 90);
        romanToInt.Add("CD", 400);
        romanToInt.Add("CM", 900);
        romanToInt.Add("I", 1);
        romanToInt.Add("V", 5);
        romanToInt.Add("X", 10);
        romanToInt.Add("L", 50);
        romanToInt.Add("C", 100);
        romanToInt.Add("D", 500);
        romanToInt.Add("M", 1000);
        
        while(i<s.Length)
        {
            string current = s[i].ToString();
            if((i+1)<s.Length && romanToInt.ContainsKey(s[i].ToString() + s[i+1].ToString()))
            {
                result += romanToInt[s[i].ToString() + s[i+1].ToString()];
                i+=2;
            } else {
                result += romanToInt[s[i].ToString()];
                i+=1;
            }
        }
        return result;
    }
}

//time: O(N)
//space: O(1)