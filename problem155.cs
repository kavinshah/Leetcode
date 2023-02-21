public class MinStack {
    Stack<(int, int)> minimum;
    Stack<int> stack;
    public MinStack() {
        stack = new Stack<int>();
        minimum = new Stack<(int, int)>();
        minimum.Push((Int32.MaxValue, 1));
    }
    
    public void Push(int val) {
        (int Val, int Count) top = minimum.Peek();
        if(top.Val>val)
        {
            minimum.Push((val, 1));
        }
        else if(top.Val==val)
        {
            (int Val, int Count) curr = minimum.Pop();
            minimum.Push((curr.Val, curr.Count+1));
        }
        stack.Push(val);
        
        // Console.WriteLine("After Push: {0}", val);
        // Print();
        return;
    }
    
    public void Pop() {
        int popped = stack.Pop();
        (int Val, int Count) currmin = minimum.Peek();
        if(popped==currmin.Val)
        {
            minimum.Pop();
            if(currmin.Count > 1){
                minimum.Push((currmin.Val, currmin.Count-1));
            }
        }
        // Console.WriteLine("After Pop:");
        // Print();
        return;
    }
    
    public int Top() {
        int top = stack.Peek();
        // Console.WriteLine("After Top:");
        // Print();
        return top;
    }
    
    public int GetMin() {
        (int Val, int Count) currMin = minimum.Peek();
        // Console.WriteLine("After GetMin:");
        // Print();
        return currMin.Val;
    }
    
    public void Print()
    {
        foreach(var s in stack)
        {
            Console.WriteLine(s);
        }
        return;
    }
}

//optimized space approach
//Time: O(1) for each operation
//Space: O(N)

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */