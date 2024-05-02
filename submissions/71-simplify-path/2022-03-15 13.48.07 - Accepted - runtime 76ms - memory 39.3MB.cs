public class Solution {
    public string SimplifyPath(string path) {
        var words = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var stack = new Stack<string>();
        foreach (var w in words){
            switch (w){
                case "." : continue;
                    break;
                case ".." : if(stack.Any()) stack.Pop();
                    break;
                default : stack.Push(w);
                    break;
            }
        }
        
        if (stack.Count == 0) return "/";
        
        var sb = new StringBuilder();
        while (stack.Any()){
            sb.Insert(0, stack.Pop());
            sb.Insert(0, '/');
        }
        
        return sb.ToString();
    }
}