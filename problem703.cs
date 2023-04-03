public class KthLargest {
    PriorityQueue<int,int> queue;
    int k;
    public KthLargest(int k, int[] nums) {
        this.k=k;
        this.queue=new PriorityQueue<int,int>();
        foreach(int n in nums)
            queue.Enqueue(n,n);
        
        while(queue.Count>k)
            queue.Dequeue();
    }
    
    public int Add(int val) {
        queue.Enqueue(val,val);
        if(queue.Count>k)
            queue.Dequeue();
        return queue.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
 
 //time: O(NLogN) for constructor and O(1) for Add()
 //space: O(1) for both the constructor and Add()