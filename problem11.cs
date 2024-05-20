/*

max_area = length * breadth
height = min(a, b)
beadth = b-a
b>a

brute force: O(N^2) -- TLE


10^8 = 10^3 * 10^3 * 10^2 = 2^10 * 2^10 * 2^7 = 2^27

-------------------------

max_area = length * breadth
height = min(a, b)
beadth = b-a
b>a

8*(6-1)= 40
7*(8-1) = 49

(8-0) * min(1,7)
8*1

left=0, right=8, res = 8
left=1, right=8, res = 7*7 = 49
left = 2, right=8, res = 6 * 6 = 36
left = 3, right = 


2*7=14

 0  1   2  3  4  5   6  7  8   
[2, 3, 20, 40, 3,50,25, 4, 1]


left=0, right=8, area = 8
left=0, right=7, area = 14
left= 1, right=7, area = 18
left = 2, right=7, area = 20
left= 2, right=6, area = 80
left= 3, right=6, area = 75
left=3, right=5, area = 80




*/


public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = Int32.MinValue;
        int left=0, right=height.Length-1;
        
        while(left<right)
        {
            int breadth = Math.Min(height[left], height[right]);
            int length = right-left;
            maxArea = Math.Max(maxArea, length*breadth);
            
            if(height[left]>height[right])
            {
                right--;
            } else
            {
                left++;
            }
            
        }
        
        return maxArea;
    }
}

//time: O(N)
//Space: O(1)