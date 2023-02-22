public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        //build a monotonically decreasing stack
        Stack<int> stack = new Stack<int>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        int[] result = new int[nums1.Length];
        
        for(int i=0; i<nums2.Length; i++)
        {
            while(stack.Count>0 && nums2[stack.Peek()]<nums2[i])
            {
                int prevSmaller = stack.Pop();
                map[nums2[prevSmaller]] = nums2[i];
            }
            stack.Push(i);
        }
        
        for(int i=0; i<nums1.Length; i++)
        {
            if(!map.TryGetValue(nums1[i], out result[i]))
            {
                result[i] = -1;
            }
        }
        return result;
    }
}

//time: O(N)
//space: O(N)