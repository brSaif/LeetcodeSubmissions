public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        
        int len = pushed.Length;
        Stack<int> stk = new();
        
        int j = 0;
        foreach (var x in pushed){
            stk.Push(x);
            while (stk.Any() && j < len && stk.Peek() == popped[j]){
                stk.Pop();
                j++;
            }
        }
        
        return j == len;
    }
}