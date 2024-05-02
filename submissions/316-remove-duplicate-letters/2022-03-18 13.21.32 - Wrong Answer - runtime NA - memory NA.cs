public class Solution {
    public string RemoveDuplicateLetters(string s) {
        
        HashSet<char> seen = new();
        Stack<char> stk = new ();
        
        foreach (var c in s){
            if(seen.Add(c)) {
                if (stk.Any() && stk.Peek() < c){
                    var tmp =  stk.Pop();
                    stk.Push(c);
                    stk.Push(tmp);
                    continue;
                }
                
                stk.Push(c);
            }
        }
        var sb = new StringBuilder();
        while (stk.Any()){
            sb.Append(stk.Pop());
        }
        
        return sb.ToString();
    }
}