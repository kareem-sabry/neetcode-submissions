public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens == null || tokens.Length < 0) return 0;
        Stack<int> stack = new Stack<int>();
        int sum = 0;
        foreach(string token in tokens)
        {
            if(int.TryParse(token,out int number))
            {
                stack.Push(number);
            }
            else
            {
                int b = stack.Pop();  // 2nd Operand 
                int a = stack.Pop();  // 1st Operand
                switch(token)
                {
                    case "+" : stack.Push(a+b); break;
                    case "-" : stack.Push(a-b); break;
                    case "*" : stack.Push(a*b); break;
                    case "/" : stack.Push(a/b); break;
                };
            }    
        }
        return stack.Pop();
    }
}
