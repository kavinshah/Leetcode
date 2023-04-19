public class Solution {
    public int Reverse(int x) {
        bool negative=false;
        int prev=0;
        int reversed=0;
        
        if(x<0)
        {
            x=-x;
            negative=true;
        }
        
        while(x>0)
        {
            if(((Int32.MaxValue-prev)/9) < prev)
                return 0;
            
            reversed=prev*10+x%10;
            x=x/10;
            prev=reversed;
        }
        
        if(negative)
            reversed=-reversed;
        return reversed;
    }
}

//Time: O(LogN/10)
//Space: O(1)