public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        Stack<int> stack = new Stack<int>();
        int[] result = new int[nums.Length];
        
        for(int i=0; i<result.Length; i++)
        {
            result[i]=-1;
        }
        
        for(int index=0; index<nums.Length*2; index++)
        {
            int i=index%nums.Length;
            while(stack.Count>0 && nums[stack.Peek()] < nums[i])
            {
                int popped = stack.Pop();
                result[popped]=nums[i];
            }
            stack.Push(i);
        }
        
        return result;
    }
}

//time: O(N)
//space O(N)