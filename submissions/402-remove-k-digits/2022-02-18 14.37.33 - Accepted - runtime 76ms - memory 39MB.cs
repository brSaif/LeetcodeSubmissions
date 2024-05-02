public class Solution {
    public string RemoveKdigits(string num, int k){
    
    if (num is null || num.Length == 0) return num;
    
    Stack<char> stk = new ();

    foreach(var c in num){
        while (stk.Count > 0 
            && k > 0 
            && c < stk.Peek())
        {
            stk.Pop();
            k--;
        }
        stk.Push(c);
    }

    while (stk.Count > 0 && k > 0){
        stk.Pop();
        k--;
    }

        StringBuilder sb = new ();
        foreach (var item in stk) sb.Append(item);

        var arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        string res = new string(arr).TrimStart('0');
        return res == "" ? "0" : res;
    }
}