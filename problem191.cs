public class Solution {
    public int HammingWeight(uint n) {
        uint counter=0;
        while(n>0)
        {
            counter += n&1;
            n = n>>1;
        }
        return (int)counter;
    }
}

//time: O(logN)
//space: O(1)