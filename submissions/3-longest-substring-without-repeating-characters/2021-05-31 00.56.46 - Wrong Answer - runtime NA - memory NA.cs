public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // Two Pointers pattern, O(n) complexity
        int res = 0;
        int left = 0;
        IDictionary<char,int> charSet = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++){
            while(charSet.ContainsKey(s[i])){
                charSet.Remove(s[i]);
                left = i;
            }
            charSet.Add(s[i],i);
            res = Math.Max(res, i - left +1);
            
        }
        
        return res;
    }
}