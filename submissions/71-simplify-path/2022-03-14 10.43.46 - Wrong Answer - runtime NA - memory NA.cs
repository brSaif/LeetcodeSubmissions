public class Solution {
    public string SimplifyPath(string path) {
        var items = path.Split('/');
        StringBuilder sb = new();
        foreach (var w in items){
            if (w == "." || w == ".."){
                sb.Clear();
                continue;
            }
            if (string.IsNullOrWhiteSpace(w)) continue;
            sb.AppendFormat("/{0}", w);
        }
        return sb.ToString().Length == 0 ? "/" : sb.ToString();
    }
}