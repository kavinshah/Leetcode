/*

123

25
11001

//convert the number to string and reverse it. conver the string back to an int and return it. 


*/

public class Solution {
    public int Reverse(int x) {
        int pop = 0;
        int rev = 0;
        while(x!=0){
            pop=x%10;
            x=x/10;
            
            if(rev>Int32.MaxValue/10 
               || rev < Int32.MinValue/10
               || (rev==Int32.MaxValue/10 && pop>7)
               || (rev==Int32.MinValue/10 && pop<-8))
                return 0;
            rev=rev*10+pop;
        }
        return rev;
    }
}