/*

palindrome(start, end)
    
    for i in range(start, end)
        if(substring(start,i) is a palindrome)
            substring(start, i) + palindrome(i+1, end)


                            p(0, 2)
                |               |               |
            a, p(1,2)        aa, p(2,2)         aab, x
            |       |         |                 
        a, p(2,2)   ab, x     b, p(3,2)
        |                           |
        b, p(3,2)                   x
            |
            x

[[b]]
[[a,b]]
[[a,a,b]]
[[b]]
[[aa, b]]

                            p(0,3)
                |               |               |
            a, p(1,3)       aa, p(2,3)      aaa, p(3,3)
          |     |               |               |
    a, p(2,3)   aa, p(3,3)    a, p(3,3)         b
        |           |              |            
    a, p(3,3)       b              b
    |
    b
    
[[b]]
[[a, b]]
[[a,a,b]]
[[aa, b]]
[[a, aa, b], [a,a,a,b]] --- 1
[[b]]
[[a,b]]
[[aa,a,b]]  --- 2
[[b]]
[[aaa, b]] --- 3

[[a,aa,b], [a,a,a,b], [aa,a,b], [aaa, b]]



*/

public class Solution {
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> result = new List<IList<string>>();
        //Console.WriteLine(s);
        if(s.Length==0){
            result.Add(new List<string>());
            return result;
        }
        
        for(int i=0; i<s.Length; i++)
        {
            string substring = s.Substring(0, i+1);
            //Console.WriteLine("{0}, {1}", substring, CheckPalindrome(substring));
            if(CheckPalindrome(substring)){
                IList<IList<string>> partitionResultSet = Partition(s.Substring(i+1));
                //Console.WriteLine("{0}", partitionResultSet.Count);
                foreach(IList<string> item in partitionResultSet){
                    List<string> newitem = new List<string>(){substring};
                    newitem.AddRange(item);
                    result.Add(newitem);
                }
            }
        }
        return result;
    }
    
    public bool CheckPalindrome(string s){
        int i=0, j=s.Length-1;
        
        while(i<j){
            if(s[i]!=s[j])
                return false;
            i++;
            j--;
        }
        return  true;
    }
}

//time: O((2^N)*N) -- at every step, we either include the given character in the palindrome substring or not (Still need to verify this.) We also need O(K) time to check if the substring is a palindrome and O(N-K) time to copy remaining substring into the resultset which totals to O(N)
//space: O(k*x) -- x substrings of length k each