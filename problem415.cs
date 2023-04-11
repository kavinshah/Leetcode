public class Solution {
    public string AddStrings(string num1, string num2) {
        char[] input1=num1.Reverse().ToArray();
        char[] input2=num2.Reverse().ToArray();
        StringBuilder result=new StringBuilder();
        int carry=0;
        int length=Math.Min(input1.Length, input2.Length);
        int counter=0;
        // Console.WriteLine(String.Join(",",input1));
        // Console.WriteLine(String.Join(",",input2));
        
        for(;counter<length; counter++)
        {
            int r = Int32.Parse(input1[counter].ToString())+Int32.Parse(input2[counter].ToString())+carry;
            // Console.WriteLine("input[counter1]:" + Int32.Parse(input1[counter].ToString()));
            // Console.WriteLine("input[counter2]:" + Int32.Parse(input2[counter].ToString()));
            carry=r/10;
            r=r%10;
            result.Insert(0,r);
            //Console.WriteLine(result.ToString());
        }
        //Console.WriteLine(result.ToString());
        while(counter<input1.Length)
        {
            int res=Int32.Parse(input1[counter].ToString())+carry;
            carry=res/10;
            res=res%10;
            result.Insert(0,res);
            counter++;
        }
        //Console.WriteLine(result.ToString());
        while(counter<input2.Length)
        {
            int res=Int32.Parse(input2[counter].ToString())+carry;
            carry=res/10;
            res=res%10;
            result.Insert(0,res);
            counter++;
        }
        //Console.WriteLine(result.ToString());
        if(carry>0)
            result.Insert(0,carry);
        
        return result.ToString();
        
    }
}

//time: O(M+N)
//space: O(M+N)