public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        int[] result = new int[k];
        
        foreach(int n in nums)
        {
            if(!counts.ContainsKey(n))
                counts[n]=0;
            counts[n]=counts[n]+1;
        }
        
        foreach(var kvp in counts)
        {
            minHeap.Enqueue(kvp.Key, kvp.Value);
            if(minHeap.Count > k)
                minHeap.Dequeue();
            //Console.WriteLine("{0}, {1}, {2}", kvp.Key, kvp.Value, minHeap.Peek());
        }
        
        while(minHeap.Count>0)
        {
            int maxElement=minHeap.Dequeue();
            result[minHeap.Count] = maxElement;
        }
        return result;
    }
}

//Time: O(N+KlogK)
//space: O(N)
