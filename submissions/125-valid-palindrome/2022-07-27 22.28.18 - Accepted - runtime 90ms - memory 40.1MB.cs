public class Solution {
    public bool IsPalindrome(string s) {
        
        int l = 0, h = s.Length -1;
        s.ToLower();

        while (h > l){
            while(!Char.IsLetterOrDigit(s[h]) && h > 0) h--;
            while(!Char.IsLetterOrDigit(s[l]) && l < s.Length -1) l++;
            if (l > h) return true;
            if (Char.ToLower(s[h]) != Char.ToLower(s[l])) return false;
            h--;
            l++;
            
        }
        return true;
    }
}