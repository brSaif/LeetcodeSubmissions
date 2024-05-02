public class Solution {
    public bool IsPalindrome(string s) {
        
        if (s.Length == 1) return true;
        if (String.IsNullOrWhiteSpace(s)) return false;

        int h = s.Length - 1, l = 0;
        while(h > l){
            while(!Char.IsLetterOrDigit(s[h])) { h--; }
            while(!Char.IsLetterOrDigit(s[l])) { l++; }
            if (Char.ToLower(s[h]) != Char.ToLower(s[l]))
                return false;
            h--;
            l++;
        }

        return true;
    }
}