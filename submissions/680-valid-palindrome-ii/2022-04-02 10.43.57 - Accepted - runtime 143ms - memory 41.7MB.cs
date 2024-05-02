public class Solution {
    public bool ValidPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;
        
        while(i < j){
            if (s[i] != s[j])
                return IsValidPalindrome(s, i + 1, j) || IsValidPalindrome(s, i, j - 1);
            
            i++;
            j--;
        }
        
        return true;
    }
    
    private bool IsValidPalindrome (string s , int start, int end){
        while (start < end){
            if (s[start] != s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }
}