/*

3 => 11
1 => 01
     10
     
0   =>  000000
31  =>  011111
    =>  011111 = 5
*/

public class Solution {
    public int HammingDistance(int x, int y) {
        int xor=x^y;
        int result=0;
        while(xor>0)
        {
            result+=xor%2;
            xor=xor/2;
        }
        return result;
    }
}

//time: O(log N)
//space: O(1)
