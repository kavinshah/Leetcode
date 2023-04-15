/*

stack1.top will contain the front of the queue
stack1.bottom will contain the back the queue.

[1]
push 2
[1 2]

[2 1]

stack2 is the temporary queue;

stack1 = [1], stack2=[]
push stack1 = [1], stack2 = [2]
push stack1 = [1], stack2 = [2 3]
push stack1 = [1], stack2 = [2 3 4]
push stack1 = [1], stack2 = [2 3 4 5]
push stack1 = [1], stack2 = [2 3 4 5 6]
pop stack1 = [], stack2 = [2 3 4 5]
pop stack1 = [5 4 3 2], stack2 = []


*/
public class MyQueue {
    Stack<int> stack1,stack2;
    public MyQueue() {
        stack1=new Stack<int>();
        stack2=new Stack<int>();
    }
    
    public void Push(int x) {
        stack2.Push(x);
    }
    
    public int Pop() {
        if(stack1.Count==0)
        {
            MoveElements();
        }
        return stack1.Pop();
    }
    
    public int Peek() {
        if(stack1.Count==0)
        {
            MoveElements();
        }
        return stack1.Peek();
    }
    
    public bool Empty() {
        return stack1.Count==0 && stack2.Count==0;
    }
    
    private void MoveElements()
    {
        while(stack2.Count>0)
            stack1.Push(stack2.Pop());
    }
}

//Push() = O(1)
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