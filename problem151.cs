public class Solution {
    public string ReverseWords(string s) {
        char[] input = new char[s.Length];
        char? prev=null;
        int inputLength = 0;
        
        //format the string
        for(int i=0; i<s.Length; i++)
        {
            if((prev==null && s[i]!= ' ')
               || (s[i]>='A' && s[i]<='Z')
               || (s[i]>='a' && s[i]<='z')
               || (s[i]>='0' && s[i]<='9')) {
                input[inputLength] = s[i];
                inputLength++;
            }
            else if(s[i]==' ' && prev!=null && prev!=' ') {
                input[inputLength] = s[i];
                inputLength++;
            }
            prev=s[i];
        }
        
        if(input[inputLength-1]==' ')
            inputLength=inputLength-1;
        
        //Console.WriteLine("{0}, {1}", String.Join("", input), inputLength);
        
        //reverse the string
        for(int i=0; i<inputLength/2; i++)
        {
            char temp = input[inputLength-1-i];
            input[inputLength-1-i] = input[i];
            input[i] = temp;
        }
        
        //Console.WriteLine(String.Join("", input));
        
        //reverse the words
        int start=0, end;
        for(int i=0; i<inputLength; i++)
        {
            if(input[i] != ' ')
                continue;
            
            end=i-1;
            
            while(start<end)
            {
                char temp = input[start];
                input[start] = input[end];
                input[end] = temp;
                start++;
                end--;
            }
            start=i+1;
        }
        
        end=inputLength-1;
        while(start<end)
        {
            char temp = input[start];
            input[start] = input[end];
            input[end] = temp;
            start++;
            end--;
        }
        
        return String.Join("", input.Take(inputLength));
        
    }
}


//Time: O(N)
//Space: O(1) -- considering that the string is mutable
//    : O(N) -- if the string is immutable
