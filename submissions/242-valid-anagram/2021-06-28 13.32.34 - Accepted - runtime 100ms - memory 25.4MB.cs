public class Solution {
    public bool IsAnagram(string s, string t) {
        var s1 = s.ToCharArray();
        var t1 = t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(t1);
        string str1 = new string(s1);
        string str2 = new string(t1);
        return str1 == str2;
    }
}