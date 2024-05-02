public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var s1 = s.ToCharArray(); 
        Array.Sort(s1);
        var s2 = t.ToCharArray();
        Array.Sort(s2);
        return new string(s1) == new string(s2);
    }
}