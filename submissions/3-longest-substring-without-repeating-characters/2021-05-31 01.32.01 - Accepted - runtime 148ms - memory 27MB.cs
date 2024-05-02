public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int res = 0;
        int left = 0;
        IDictionary<char,int> charSet = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++){
            while(charSet.ContainsKey(s[i])){
                charSet.Remove(s[left]);
                left += 1;
            }
            charSet.Add(s[i],i);
            Console.Write(i +" + left " + left);
            res = Math.Max(res, i - left +1);
            
        }
        
        return res;
    }
}