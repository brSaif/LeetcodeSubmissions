public class Solution {
    public bool IsAnagram(string s, string t) {
        var sortedSTrs = s.ToCharArray();
        var sortedTTrs = t.ToCharArray();
        Array.Sort(sortedSTrs);
        Array.Sort(sortedTTrs);
        return new string(sortedSTrs) == new string(sortedTTrs);
    }
}