/*

*/


public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        Stack<int> stack = new Stack<int>();
        int[] result=new int[nums1.Length];
        
        for(int i=0; i<nums2.Length; i++)
        {
            while(stack.Count>0 && stack.Peek()<nums2[i])
            {
                int current=stack.Pop();
                map[current]=nums2[i];
            }
            stack.Push(nums2[i]);
        }
        
        while(stack.Count>0)
        {
            map[stack.Pop()]=-1;
        }
        
        for(int i=0; i<nums1.Length; i++)
        {
            result[i]=map[nums1[i]];
        }
        return result;
    }
}

//time: O(N)
//space: O(N)