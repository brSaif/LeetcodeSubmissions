public class Solution {
    public bool ValidPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;
        while (i < j){
            if (s[i] != s[j])
                return (IsValidPalindrome(s, i, j - 1) || IsValidPalindrome(s, i + 1, j));
            
            i++;
            j--;
        }
        return true;
    }
    
    private bool IsValidPalindrome(string s, int i, int j){
        while (i < j){
            if (s[i] != s[j])
                return false;
            i++;
            j--;
        }
        
        return true;
    }
}