public class Solution {
    public int Trap(int[] height) {
        int[] leftmax = new int[height.Length];
        int[] rightmax = new int[height.Length];
        leftmax[0]=0;
        int currMax=0;
        int result=0;
        
        for(int i=1; i<height.Length; i++)
        {
            currMax=Math.Max(currMax, height[i-1]);
            leftmax[i]=currMax;
        }
        
        currMax=0;
        rightmax[rightmax.Length-1]=0;
        for(int i=height.Length-2; i>=0; i--)
        {
            currMax=Math.Max(currMax, height[i+1]);
            rightmax[i]=currMax;
        }
        
        //Console.WriteLine(String.Join(",", leftmax));
        //Console.WriteLine(String.Join(",", rightmax));
        result=0;
        
        for(int i=0; i<height.Length; i++)
        {
            int diff = Math.Min(leftmax[i], rightmax[i])-height[i];
            if(diff>0)
            {
                result+=diff;
            }
        }
        return result;
    }
}

//Time: O(N)
//Space: O(N)