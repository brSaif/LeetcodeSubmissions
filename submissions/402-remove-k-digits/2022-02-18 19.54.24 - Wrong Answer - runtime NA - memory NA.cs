public class Solution {
    public string RemoveKdigits(string num, int k) {
        
        if (num is null || num == "") return num;
        
        Stack<char> stk = new ();
        
        foreach(var c in num){
            while (stk.Count > 0 
                   && k > 0 
                   && stk.Peek() > c){
                stk.Pop();
                k--;
            }
            stk.Push(c);
        }
        
        while (stk.Count > 0 && k > 0) 
            stk.Pop();
        
        StringBuilder sb = new ();
        foreach (var n in stk) sb.Append(n);
        var arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        var str = new string(arr);
        return str == "" ? "0" : str; 
    }
}