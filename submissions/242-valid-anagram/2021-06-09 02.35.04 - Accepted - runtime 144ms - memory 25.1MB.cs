public class Solution {
    public bool IsAnagram(string s, string t) {
        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        string strs = new string(sArr);
        string strt = new string(tArr);
        return strs == strt;
    }
}