public class Solution {
    public bool IsPalindrome(string s) {
        
        // Check length first
        if (s.Length == 1) return true;

        // Check for nul or empty
        if (string.IsNullOrWhiteSpace(s)) return false;

        int hi = s.Length -1, lo = 0;

        while(hi > lo){
            // Forward indexes if not a valid letter or digit
            while(!Char.IsLetterOrDigit(s[hi]) && hi > 0) hi --;
            while(!Char.IsLetterOrDigit(s[lo]) && lo < s.Length - 1) lo ++;

            // If indexes overlapped return true.
            if(hi < lo)
                return true;

            // Short circuit if the two characters are not matching.
            if (Char.ToLower(s[hi]) != Char.ToLower(s[lo]))
                return false;

            // Forward indexes
            hi--;
            lo++;
        }

        return true;
    }
}