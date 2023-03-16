/*

monotonic stack:-
-- when you find larger elements on the top of stack, pop the top
-- the first loop calculates the maximum height based on nearest smaller bars. This loop only calculates the area bounded by stack top and current smallest bar.

-- the second loop keep the end of array fixed and calculates the total area bounded by top of stack and end of array. This is required since we need to find out the area bounded by all the smaller bars on the stack.


2 1 2

    ____    ____
    |   |___|   |
    |   |   |   |
------------------------


*/


public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int result=0;
        Stack<int> stack = new Stack<int>();
        stack.Push(0);
        
        for(int i=0; i<heights.Length; i++)
        {
            
            while(stack.Count>1 && heights[stack.Peek()]>heights[i])
            {
                int popped=stack.Pop();
                result=Math.Max(result, heights[popped]*(i-stack.Peek()-1));
            }
            stack.Push(i);
        }
        
        while(stack.Count>1)
        {
            int popped=stack.Pop();
            result=Math.Max(result, heights[popped]*(heights.Length-stack.Peek()-1));
        }
        
        return result;
    }
}
