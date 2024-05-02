public class Solution {
    public string MinRemoveToMakeValid(string s) {
        if (s is null || s == string.Empty)
            return s;
        
        Stack<(char c, int i)> stk = new();
        char[] a = s.ToArray();
        
        for (int i = 0; i < s.Length; i++){
            if (s[i] == ')' && stk.Any() && stk.Peek().c == '(')
                stk.Pop();
            else if (s[i] == '(' || s[i] == ')')
                stk.Push((s[i], i));
        }
        
        while (stk.Any())
            a[stk.Pop().i] = ' ';
        
        return new string(a).Replace(" ", string.Empty);
    }
}