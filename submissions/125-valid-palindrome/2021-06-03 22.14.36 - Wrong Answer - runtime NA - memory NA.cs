public class Solution {
    public bool IsPalindrome(string s) {
         string str = s.ToLower();
        int left = 0;
        int right = s.Length -1 ;
        while(left <  right){
            while(!Char.IsLetter(str[left]) && 
                  !Char.IsDigit(str[left]) &&
                  left < right) left++;
            while(!Char.IsLetter(str[right]) && 
                  !Char.IsDigit(str[right]) &&
                  right > 0) right--;
            
            if(left == s.Length - 1) return true;  
            
            if(str[left] == str[right]){
                                             
                left ++;
                right --;
                continue;
            }
            
            return false;
                 
            
        }
        
        return true;
    }
}