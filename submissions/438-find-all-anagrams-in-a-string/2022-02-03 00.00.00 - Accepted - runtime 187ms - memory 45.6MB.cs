public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        
        if (s == null) return result;
        
        var window = new Dictionary<char, int>();
        int count = 0;
        int uniqueLetters = 0;
        
        foreach (var c in p) {
            if (!window.ContainsKey(c)) {
                window[c] = 0;
                uniqueLetters++;
            }
            window[c]++;
        }
        
        for (int i = 0; i < s.Length; i++) {
            char last = s[i];
            int toRemoveIdx = i - p.Length;
            if (toRemoveIdx >= 0) {
                if (window.ContainsKey(s[toRemoveIdx])) {
                    if (window[s[toRemoveIdx]] == 0) count--;
                    window[s[toRemoveIdx]]++;
                }
            }
            if (window.ContainsKey(last)) {
                window[last]--;
                if (window[last] == 0) count++;
            }
            if (count == uniqueLetters) result.Add(i - p.Length + 1);          
        }
        
        return result;
    }
}