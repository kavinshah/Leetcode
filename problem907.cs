public class Solution {
    public int SumSubarrayMins(int[] arr) {
        Stack<int> stack= new Stack<int>();
        long ModValue = 1000000007;
        long sumOfRange=0;
        for(int i=0; i<=arr.Length; i++){
            while(stack.Count>0 && (i==arr.Length || arr[stack.Peek()] >= arr[i])){
                int mid=stack.Pop();
                int left=stack.Count>0?stack.Peek():-1;
                int right=i;
                long range=(mid-left)*(right-mid)%ModValue;
                range = (range*arr[mid])%ModValue;
                sumOfRange=(sumOfRange+range)%ModValue;
                //Console.WriteLine("{0},{1}",i,sumOfRange);
            }
            stack.Push(i);
        }
        return (int)sumOfRange;
    }
}

//Time: O(N)
//Space: O(N)