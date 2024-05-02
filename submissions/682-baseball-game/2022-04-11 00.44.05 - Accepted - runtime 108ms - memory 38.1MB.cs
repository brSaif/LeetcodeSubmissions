public class Solution {
    public int CalPoints(string[] ops) {
        int res = 0;
        Stack<int> stack = new Stack<int>();
        foreach(var c in ops)
        {
            int score = 0;        
            if(c == "+")
            {
                int prev1 = stack.Pop();
                int prev2 = stack.Pop();
                score = prev1 + prev2;
                stack.Push(prev2);
                stack.Push(prev1);
                stack.Push(score);
            }
            else if(c == "D")
            {
                score = 2 * stack.Peek();
                stack.Push(score);
            }
            else if(c == "C")
            {
                stack.Pop();
            }
            else
            {
                score = int.Parse(c);
                stack.Push(score);
            }
        }
        
        while(stack.Count > 0)
            res += stack.Pop();
        
        return res;
    }
}