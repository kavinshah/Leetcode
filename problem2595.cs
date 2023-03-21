public class Solution {
    public int[] EvenOddBit(int n) {
        bool flag=true;
        int odd=0, even=0;
        while(n>0)
        {
            int lastbit=n&1;
            n=n>>1;
            if(flag)
                even+=lastbit;
            else
                odd+=lastbit;
            flag=!flag;
        }
        return new int[]{even, odd};
    }
}

//time: O(logN)
//space: O(1)