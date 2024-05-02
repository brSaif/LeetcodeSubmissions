public class Solution {
    public bool WordPattern(string pattern, string s) {
        var arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int lc = pattern.Length, wc = arr.Length;
        
        if (wc != lc) 
            return false;
        
        var dic = new Dictionary<char, string>();
        for(int i = 0; i < lc ; i++){
            if (!dic.ContainsKey(pattern[i])) dic.Add(pattern[i], arr[i]);
            else if (dic.ContainsKey(pattern[i]) && (dic[pattern[i]] == arr[i]))
                continue;
            else 
                return false;
        }
        
        return true;
    }
}