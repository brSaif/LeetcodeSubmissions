public class Solution {
    public string ReverseWords(string s) {
        int start = 0;
        char[] strArr = s.ToCharArray();
        for(int i = 0;i < s.Length; i++){
            if(s[i] == ' '){
                ReverseChars(strArr, start, i );
                start = i+1;
            }
            
            if(i == s.Length -1){
                ReverseChars(strArr, start, s.Length);
                start = i+1;
            }
            
        }
        
        return new string(strArr);
    }
    
    public void ReverseChars(char[] str,int start, int end){
        Array.Reverse(str, start, end - start);
    }
}