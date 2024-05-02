public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        while(left < right){
            while(!Char.IsLetterOrDigit(s[left]) && left < right)
                left++;
            while(!Char.IsLetterOrDigit(s[right]) && left < right)
                right--;
            
            if(Char.ToLower(s[left]) != Char.ToLower(s[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
}