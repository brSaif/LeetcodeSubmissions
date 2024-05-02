public class Solution {
    public bool IsPalindrome(string s) {
        var len = s.Length;
        int h = len - 1;
        int l = 0;

        while(h > l)
        {
            while(!Char.IsLetterOrDigit(s[l]) && l < h)
                l++;

            while(!Char.IsLetterOrDigit(s[h]) && h > l)
                h--;

            if (Char.ToLower(s[l]) != Char.ToLower(s[h]))
                return false;

            l++;
            h--;
        }

        return true;
    }
}