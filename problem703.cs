/*

1. use a max heap
2. store each element as its complement. so that max heap behaves as a min heap with k largest elements in the heap.
3. the top of the heap stores the kth largest element

OR
simply use array and sort it and keep inserting into it.

*/



public class KthLargest {
    int[] queue;
    int k;
    
    public KthLargest(int k, int[] nums) {
        this.queue=new int[k];
        for(int i=0; i<k;i++)
            queue[i]=Int32.MinValue;
        this.k=k;
        Array.Sort(nums);
        Array.Reverse(nums);
        
        Array.Copy(nums,queue,Math.Min(k,nums.Length));
        //Print();
    }
    
    public int Add(int val) {        
        //Console.WriteLine("Adding:" + val);
        int i=-1;
        int prev;
        while(++i<queue.Length)
        {
            if(queue[i]<val)
                break;
        }
        //Console.WriteLine("after finding the index:"+i);
        while(i<queue.Length)
        {
            int temp=queue[i];
            queue[i++]=val;
            val=temp;
        }
        
        //Print();
        return queue[queue.Length-1];
    }
    
    public void Print()
    {
        Console.WriteLine(String.Join(",", queue));
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
 
 //time: O(NLogN) for constructor and O(N) for Add()
 //space: O(1) for constructor and O(1) for Add()