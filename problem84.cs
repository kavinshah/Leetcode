public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
        stack.Push(-1);
        int result=0;
        
        for(int i=0; i<heights.Length; i++)
        {
            while(stack.Count>1 && heights[stack.Peek()] > heights[i])
            {
                int ht = heights[stack.Pop()];
                int width = i-stack.Peek()-1;
                result=Math.Max(result, width*ht);
            }
            stack.Push(i);   
        }
        
        while(stack.Count>1)
        {
            int ht=heights[stack.Pop()];
            int width=heights.Length-stack.Peek()-1;
            result=Math.Max(result, ht*width);
        } 
        return result;
    }
}

//time: O(N)
//space: O(N)