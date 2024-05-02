public class Solution {
    public bool IsValid(string s) {
        
        var stk = new Stack<char>();
        
        foreach (var c in s){
            switch (c){
                case '{' : stk.Push('}');
                    break;
                case '(' : stk.Push(')');
                    break;
                case '[' : stk.Push(']');
                    break;
                default : 
                    if (stk.Count == 0 || stk.Pop() != c) return false;
                    break;
            }
        }
        
        return stk.Count == 0;
    }
}