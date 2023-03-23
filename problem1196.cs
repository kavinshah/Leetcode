public class MinHeap:IComparer<int>
{
    int IComparer<int>.Compare(int x, int y)
    {
        return (int)x-(int)y;
    }
}
public class Solution {
    public int MaxNumberOfApples(int[] weight) {
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>(weight.Length, new MinHeap());
        int currentcapacity=5000;
        int result=0;
        
        for(int i=0; i<weight.Length; i++)
        {
            queue.Enqueue(weight[i],weight[i]);
        }
        
        while(queue.Count>0)
        {
            int current=queue.Dequeue();
            if((currentcapacity-current)<0)
            {
                return result;
            }
            currentcapacity-=current;
            result++;
        }
        
        
        return result;
    }
}

//time: O(nlogn)
//space: O(N)