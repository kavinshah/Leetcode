/*



[1,3,4,2]
i=0, stack=[0],  prefix=[-1,-1,-1,-1]
i=1, stack=[1],  prefix=[1,-1,-1,-1]
i=2, stack=[2],   prefix=[1,2,-1,-1]
i=3, stack=[2,3],   prefix=[1,2,-1,-1]


*/

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Stack<int> stack = new Stack<int>();
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();
        int[] result=new int[nums1.Length];
        for(int i=0; i<nums2.Length; i++){
            while(stack.Count>0 && stack.Peek()<nums2[i]){
                nextGreater[stack.Pop()]=nums2[i];
            }
            stack.Push(nums2[i]);
        }
        
        while(stack.Count>0){
            nextGreater[stack.Pop()]=-1;
        }
        
        for(int i=0; i<nums1.Length; i++){
            result[i]=nextGreater[nums1[i]];
        }
        
        return result;
    }
}

//Time: O(N)
//space: O(N)