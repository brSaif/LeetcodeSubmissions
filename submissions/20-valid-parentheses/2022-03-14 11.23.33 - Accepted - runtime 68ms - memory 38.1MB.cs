public class Solution {
    public bool IsValid(string s) {
        var stk = new Stack<char>();
        foreach (var b in s){
            switch (b) {
                case '{' : stk.Push('}');
                    break;
                case '(' : stk.Push(')');
                    break;
                case '[' : stk.Push(']');
                    break;
                default : if (!stk.Any() || stk.Pop() != b) return false;
                    break;
            }
        }
        return stk.Count == 0;
    }
}