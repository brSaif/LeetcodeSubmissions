public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length <= 2) return true;
        int l = 0, h = s.Length -1;
        s.ToLower();

        while (h > l){
            while(!Char.IsLetterOrDigit(s[h]) && h > 0) h--;
            while(!Char.IsLetterOrDigit(s[l]) && l < s.Length -1) l++;
            int tmp = Math.Abs((int)s[h] - (int)s[l]);
            if (tmp != 0 && 
                tmp != 32) return false;
            h--;
            l++;
            
        }
        return true;
    }
}