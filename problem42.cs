public class Solution {
    public int Trap(int[] height) {
        int[] leftMax = new int[height.Length];
        int[] rightMax = new int[height.Length];
        int currMax=0;
        int result=0;
        
        for(int i=0; i<height.Length; i++)
        {
            leftMax[i]=currMax;
            currMax=Math.Max(currMax, height[i]);
        }
        
        currMax=0;
        for(int i=height.Length-1; i>=0; i--)
        {
            rightMax[i]=currMax;
            currMax=Math.Max(currMax, height[i]);
        }
        
        // Console.WriteLine(String.Join(",",leftMax));
        // Console.WriteLine(String.Join(",",rightMax));
        
        for(int i=0; i<height.Length; i++)
        {
            result += Math.Max(0, Math.Min(leftMax[i], rightMax[i]) - height[i]);
        }
        return result;
    }
}

// 3 pass and constant space
//time: O(N)
//space: O(N)