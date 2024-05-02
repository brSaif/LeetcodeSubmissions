public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int res = s[0] ^ t[0];
        for(int i = 1; i < s.Length; i++){
            res ^= s[i] ^ t[i];
        }
        
        return res == 0;

    }
}