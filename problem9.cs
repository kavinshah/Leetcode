/*

121

1111001

64+32+16+8+1
120

tempx = 1111001, y=0
tempx = 111100, y=1
tempx = 11110, y=10
tempx = 1111, y=100
tempx = 111, y=1001
tempx = 11, y=10011
tempx = 1, y=10011

*/


public class Solution {
    public bool IsPalindrome(int x) {
        int y=0;
        int tempx=x;
        
        if(x<0)
            return false;
        
        while(tempx>0)
        {
            y=y*10+tempx%10;
            tempx=tempx/10;
            //Console.WriteLine($"{x}, {tempx}, {y}");
        }
        
        return x==y;
    }
}

//Time: O(LogN base 10)
//Space: O(1)