public class Solution {
    public int BalancedStringSplit(string s) {
        int balanceCount=0;
        int count=0;
        
        foreach(char c in s)
        {
            if(c=='R')
                balanceCount++;
            else
                balanceCount--;
            
            if(balanceCount==0)
                count++;
        }
        return count;
    }
}

//time: O(N)
//space: O(1)