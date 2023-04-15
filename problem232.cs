/*

stack1.top will contain the front of the queue
stack1.bottom will contain the back the queue.

[1]
push 2
[1 2]

[2 1]

stack2 is the temporary queue;

stack1 = [1]
stack2 = []

*/
public class MyQueue {
    Stack<int> stack1,stack2;
    public MyQueue() {
        stack1=new Stack<int>();
        stack2=new Stack<int>();
    }
    
    public void Push(int x) {
        stack2=new Stack<int>();
        while(stack1.Count>0)
            stack2.Push(stack1.Pop());
        stack2.Push(x);
        while(stack2.Count>0)
            stack1.Push(stack2.Pop());
        return;
    }
    
    public int Pop() {
        return stack1.Pop();
    }
    
    public int Peek() {
        return stack1.Peek();
    }
    
    public bool Empty() {
        return stack1.Count==0;
    }
}

//Push() = O(N)
//Pop() = O(1)
//Peek() = O(1)
//Empty() = O(1)

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */