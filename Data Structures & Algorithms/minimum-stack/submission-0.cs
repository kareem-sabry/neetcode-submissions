public class MinStack {
    private Stack<int> mainStack;
    private Stack<int> minStack;
    public MinStack() {
        minStack = new Stack<int>();
        mainStack = new Stack<int>();
    }
    
    public void Push(int val) {
        mainStack.Push(val);

        if(minStack.Count == 0)
        {
            minStack.Push(val);
        }
        else{
            int current = minStack.Peek();
            minStack.Push(Math.Min(current,val));
        }
    }
    
    public void Pop() {
        mainStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
