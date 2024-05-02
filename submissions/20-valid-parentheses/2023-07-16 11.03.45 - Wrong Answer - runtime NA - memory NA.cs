public class Solution {
    public bool IsValid(string s) {
        Stack<char> values = new ();

        foreach (var c in s){
            switch(c){
                case '[': values.Push(']');
                    break;
                case '{': values.Push('}');
                    break;
                case '(': values.Push(')');
                    break;
                default: 
                    if (values.Count > 0 && values.Pop() != c)
                    return false;
                    break;
            }
        }

        return values.Count == 0;
    }
}