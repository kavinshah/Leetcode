public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        Dictionary<int, int> nextGreatest = new Dictionary<int, int>();
        Stack<int> monotonicStack = new Stack<int>();
        int current = nums2.Length-1;
        
        while(current>=0)
        {
            while(monotonicStack.Count>0 && monotonicStack.Peek() <= nums2[current])
            {
                monotonicStack.Pop();
            }
            nextGreatest.Add(nums2[current], monotonicStack.Count>0?monotonicStack.Peek():-1);
            monotonicStack.Push(nums2[current]);
            current--;
        }
        
        for(int i=0; i<nums1.Length; i++)
        {
            result[i] = nextGreatest[nums1[i]];
        }
        
        return result;
    }
}

//time: O(N)
//Space: O(N)
