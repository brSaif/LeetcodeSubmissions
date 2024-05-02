public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int hash1 = 0, hash2 = 0;
        foreach(var c in s)
            hash1 += (int) c * 7;

        foreach(var c in t)
            hash2 += (int) c * 7;
        
        return hash1 == hash2;

    }
}