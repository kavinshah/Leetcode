/*

How to use a monotonic stack?

-- go from left to right
-- pop smaller elements from the top
-- 
          0 1 2 3 4 5 6 7 8 9 10 11 
height = [0,1,0,2,1,0,1,3,2,1,2, 1]

          0 1 2 3 4 5 6 7 8 9 10 11 
height = [0,1,0,2,1,0,1,3,2,1,2, 1]

i=0, stack=[0], total=0
i=1, stack=[1], popped=0, heightval=, length=, total=0
i=2, stack=[1,2], popped=, heightval=, length=, total=0
i=3, stack=[1], popped=2, heightval=1, length=1, total=1
i=3, stack=[3], popped=1, heightval=, length=, total=1
i=4, stack=[3,4], popped=, heightval=, length=, total=1
i=5, stack=[3,4,5], popped=, heightval=, length=, total=1
i=6, stack=[3,4,6], popped=5, heightval=1, length=1, total=2
i=7, stack=[3,4], popped=6, heightval=0, length=2, total=2
i=7, stack=[3], popped=4, heightval=1, length=3, total=5
i=7, stack=[7], popped=3, heightval=, length=, total=5
i=8, stack=[7,8], popped=, heightval=, length=, total=5
i=9, stack=[7,8,9], popped=, heightval=, length=, total=5
i=10, stack=[7,8], popped=9, heightval=1, length=1, total=7
i=11, stack=[7,8,11], popped=9, heightval=1, length=1, total=7

class Solution(object):
    def trap(self, height):
        """
        :type height: List[int]
        :rtype: int
        """
        stack = []
        total = 0
        
        for i in range(len(height)):
            while len(stack) > 0 and height[stack[-1]] < height[i]:
                poppedIdx = stack.pop()
                
                if len(stack) == 0:
                    b6eak
                    
                heightVal = min(height[stack[-1]], height[i]) - height[poppedIdx]
                length = i - stack[-1] - 1
                total += heightVal * length
            
            stack.append(i)
        
        return total

*/


public class Solution {
    public int Trap(int[] height) {
        int result=0;
        Stack<int> stack = new Stack<int>();
        for(int i=0; i<height.Length; i++)
        {
            while(stack.Count>0 && height[stack.Peek()] < height[i])
            {
                int popped=stack.Pop();
                if(stack.Count==0)
                    break;
                int ht=Math.Min(height[i], height[stack.Peek()])-height[popped];
                int length=i-stack.Peek()-1;
                result += ht*length;
            }
            stack.Push(i);
        }
        return result;
    }
}

// 1 pass and linear space
//time: O(N)
//space: O(N)