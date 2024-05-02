public class Solution {
    public bool IsPalindrome(string s) {
         string str = s.ToLower();
        int left = 0;
        int right = s.Length -1 ;
        while(left <  right){
            while(!Char.IsLetter(str[left]) && !Char.IsDigit(str[left])) left++;
            while(!Char.IsLetter(str[right]) && !Char.IsDigit(str[right])) right--;
            if(str[left] == str[right]){
                                             
                left ++;
                right --;
            }else{
                Console.WriteLine("left = "+str[left] );
                Console.WriteLine("right = "+str[right]);
                return false;
            }
            
            
        }
        
        return true;
    }
}