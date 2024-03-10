public class MyQueue {
    Stack<int> stack1, stack2;
    
    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    
    public void Push(int x) {
        stack1.Push(x);
    }
    
    public int Pop() {
        int result=-1;
        while(stack1.Count > 1)
        {
            stack2.Push(stack1.Pop());
        }
        result = stack1.Pop();
        while(stack2.Count > 0)
        {
            stack1.Push(stack2.Pop());
        }
        return result;
    }
    
    public int Peek() {
        int result=-1;
        while(stack1.Count > 0)
        {
            result = stack1.Pop();
            stack2.Push(result);
        }
        while(stack2.Count > 0)
        {
            stack1.Push(stack2.Pop());
        }
        return result;
    }
    
    public bool Empty() {
        return stack1.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 
 Time: 
 Push : O(1)
 Pop : O(N)
 Peek : O(N)
 Empty: O(1)
 
 Space:
 Push : O(1)
 Pop : O(N)
 Peek : O(N)
 Empty: O(1)
 
 */
 