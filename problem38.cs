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
            says[i] = CountAloud(previousSay);
        }
        return says[n];
    }
    
    public string CountAloud(string number){
        int prev = Int32.Parse(number[0].ToString());
        int count = 1;
        int current;
        StringBuilder result = new StringBuilder();
        
        for(int i=1; i<number.Length; i++){
            current = Int32.Parse(number[i].ToString());
            if (prev == current) {
                count++;
            } else {
                result = result
                    .Append(count)
                    .Append(prev);
                count = 1;
                prev=current;
            }
        }
        result = result
                .Append(count)
                .Append(prev);
        //Console.WriteLine("\t{0} => {1}", number, result);
        return result.ToString();
    }
}

//Time: O(Nk)
//Space: O(Nk)