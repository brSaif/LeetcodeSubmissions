public class Solution {
    public string SimplifyPath(string path) {
        var split = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var st = new Stack<string>();
        foreach (var s in split)
        {
            if (s.Equals("."))
                continue;
            else if (s.Equals("..") && st.Count > 0)
                st.Pop();
            else if (!s.Equals(".."))
                st.Push(s);
        }
        
        if (st.Count == 0)
            return "/";
        
        var sb = new StringBuilder();
        while (st.Count > 0)
        {
            sb.Insert(0, st.Pop());
            sb.Insert(0, '/');
        }
        
        return sb.ToString();
    
    }
}