public class Solution {
    public bool IsSubsequence(string s, string t) {
        int j = 0;
        for (int i = 0; i < t.Length; i++)
            if (j < s.Length && s[j] == t[i]) j++;
        return j == s.Length;
    }
}