public class Solution {
    public bool IsPalindrome(string s) {
        
        if (s.Length == 1) return true;

        if (string.IsNullOrWhiteSpace(s)) return false;

        int hi = s.Length -1, lo = 0;

        while(hi > lo){
            while(!Char.IsLetterOrDigit(s[hi]) && hi > 0) hi --;
            while(!Char.IsLetterOrDigit(s[lo]) && lo < s.Length - 1) lo ++;

            if(hi < lo)
                return true;

            if (Char.ToLower(s[hi]) != Char.ToLower(s[lo]))
                return false;

            hi--;
            lo++;
        }

        return true;
    }
}