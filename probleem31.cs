/*

-> swap the lower order digit with the first higher order digit smaller than the lower order digit.
-> The high order digit must be also the lowest possible higher order digit.


123 => 132
541 => 145
319 => 391
352 => 523
3524 => 3542
3542 => 4235
35486 => 35648
35482 => 35824

*/

public class Solution {
    public void NextPermutation(int[] nums) {
        int low=-1, high=-1;
        Stack<int> monotonicStack = new Stack<int>();
        int[] previousSmaller = new int[nums.Length];
        previousSmaller[0]=-1;
        monotonicStack.Push(0);
        
        for(int i=1; i<nums.Length; i++){
            while(monotonicStack.Count>0 && nums[monotonicStack.Peek()] >= nums[i])
                monotonicStack.Pop();
            if(monotonicStack.Count>0)
                previousSmaller[i] = monotonicStack.Peek();
            else
                previousSmaller[i]=-1;
            monotonicStack.Push(i);
        }
        
        //Console.WriteLine("Previous Smaller: {0}", String.Join(",", previousSmaller));
        
        for(int i=nums.Length-1; i>=0; i--){
            if(previousSmaller[i]>low){
                low=previousSmaller[i];
                high=i;
            }
        }
        
        if(low==-1 && high==-1){
            Array.Sort(nums);
            return;
        }
        
        int temp = nums[low];
        nums[low]=nums[high];
        nums[high]=temp;
        
        low=low+1;
        
        //Console.WriteLine("{0}, {1}", low, nums.Length-low);
        Array.Sort(nums, low, nums.Length-low);
        return;
    }
}

//time: O(N)
//Space: O(N)