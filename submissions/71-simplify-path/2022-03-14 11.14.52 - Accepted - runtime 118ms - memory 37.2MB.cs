public class Solution {
    public string SimplifyPath(string path) {
        var words = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var stk = new Stack<string>();
        foreach (var w in words){
            switch (w){
                case ".." :
                    if (stk.Any()) stk.Pop();
                    break;
                case "." : 
                    break;
                default : stk.Push(w);
                    break;
            }
        }
        
        if (stk.Count == 0) return "/";
        
        StringBuilder sb = new ();
        while (stk.Any()){
            sb.Insert(0,stk.Pop());
            sb.Insert(0,'/');

        }
        return sb.ToString();
    }
}