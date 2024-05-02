public class Solution {
    public bool IsAnagram(string s, string t) {
        var s1 = s.ToCharArray();
        Array.Sort(s1);
        var t1 = t.ToCharArray();
        Array.Sort(t1);
        
        return s1.ToString() == t1.ToString();
    }
}