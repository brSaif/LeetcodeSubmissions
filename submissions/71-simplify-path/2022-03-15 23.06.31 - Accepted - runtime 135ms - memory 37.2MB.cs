public class Solution {
    public string SimplifyPath(string path) {
        
        string[] words = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        Stack<string> stk = new();

        foreach (var w in words){
            switch (w) {
                case "." : continue;
                    break;
                case "..": if (stk.Any()) stk.Pop();
                    break;
                default : stk.Push(w);
                    break;
            }
        }
        
        if (stk.Count == 0) return "/";
        
        var sb = new StringBuilder();
        while (stk.Any()){
            sb.Insert(0, stk.Pop());
            sb.Insert(0, "/");
        }
        
        return sb.ToString();
    }
}