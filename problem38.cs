/*

1 => 1 => "1"
2 => one 1 => "11"
3 => two one => 21
4 => one two one one => 1211
5 => one one one two two one => 111221
6 => three one two two one one => 312211
7 => one three one one two two two one => 13112221







*/


public class Solution {
    Dictionary<int, string> says = new Dictionary<int, string>();
    public string CountAndSay(int n) {
        says[1] = "1";
        
        for(int i=2; i<=n; i++)
        {
            string previousSay = says[i-1];
            string words = ConvertToWords(previousSay);
            says[i] = ConvertToDigits(words);
            //Console.WriteLine("{0} => {1}", i, says[i]);
        }
        return says[n];
    }
    
    public string ConvertToWords(string number){
        int prev = Int32.Parse(number[0].ToString());
        int count = 1;
        int current;
        StringBuilder result = new StringBuilder();
        
        for(int i=1; i<number.Length; i++){
            current = Int32.Parse(number[i].ToString());
            if (prev == current) {
                count++;
            } else {
                result = result.Append(" ")
                    .Append(CountToWord(count))
                    .Append(" ")
                    .Append(prev);
                count = 1;
                prev=current;
            }
        }
        result = result.Append(" ")
                .Append(CountToWord(count))
                .Append(" ")
                .Append(prev);
        //Console.WriteLine("\t{0} => {1}", number, result);
        return result.ToString();
    }
    
    public string ConvertToDigits(string input){
        string[] words = input.Split(" ");
        StringBuilder result = new StringBuilder();
        foreach(string word in words){
            if(word!= "" || word!= " ") {
                result = result
                    .Append(WordToCount(word));
            }
        }
        return result.ToString();
    }
    
    public string CountToWord(int number){
        switch(number){
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
        }
        return number.ToString();
    }
    
    public string WordToCount(string word) {
        switch(word){
            case "one":
                return "1";
            case "two":
                return "2";
            case "three":
                return "3";
            case "four":
                return "4";
            case "five":
                return "5";
            case "six":
                return "6";
            case "seven":
                return "7";
            case "eight":
                return "8";
            case "nine":
                return "9";
            default:
                return word;
        }
    }
}

//Time: O(Nk)
//Space: O(Nk)