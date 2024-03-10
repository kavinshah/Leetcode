public class MyStack {
    Queue<int> queue1, queue2;
    
    public MyStack() {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }
    
    public void Push(int x) {
        queue1.Enqueue(x);
    }
    
    public int Pop() {
        while(queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }
        
        int result = queue1.Dequeue();
        
        while(queue2.Count > 0)
        {
            queue1.Enqueue(queue2.Dequeue());
        }
        return result;
    }
    
    public int Top() {
        int result=-1;
        while(queue1.Count > 0)
        {
            result = queue1.Dequeue();
            queue2.Enqueue(result);
        }
        while(queue2.Count > 0)
        {
            queue1.Enqueue(queue2.Dequeue());
        }
        return result;
    }
    
    public bool Empty() {
        return queue1.Count==0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 
Time: 
 Push: O(1)
 Pop : O(N)
 Top : O(N)
 Empty : O(1)
 
Space:
Push : O(1)
Pop : O(N)
Top : O(N)
Empty : O(1)

 */