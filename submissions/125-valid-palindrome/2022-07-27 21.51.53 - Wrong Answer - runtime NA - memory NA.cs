public class Solution {
    public bool IsPalindrome(string s) {
        s.ToLower();
        
        int l = 0, h = s.Length -1;
        
        while (h > l){
            while(!Char.IsLetterOrDigit(s[h]) && h > 0) h--;
            while(!Char.IsLetterOrDigit(s[l]) && l < s.Length -1) l++;
            if (Math.Abs((int)s[h] - (int)s[l]) != 0 && 
                Math.Abs((int)s[h] - (int)s[l]) != 32) return false;
            h--;
            l++;
            
        }
        return true;
    }
}