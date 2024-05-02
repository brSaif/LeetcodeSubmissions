public class Solution {
    public string LongestPalindrome(string s) {
        if(string.IsNullOrEmpty(s)) return "";
        int start = 0;
        int end = 0;
        int len =0;
        for(int i=0; i < s.Length;i++){
            int len1 = expendAroundTheCenter(s,i,i);
            int len2 = expendAroundTheCenter(s,i,i+1);
            len = Math.Max(len1,len2);
            Console.WriteLine("len1 : "+len1+" len2 : "+len2+" len : "+len);
            if(len > end - start){
                start = i - (len -1) /2;
                end = i + len /2;
                Console.WriteLine("start : "+start+" end : "+end);
            }
        }
        return s.Substring(start );
    }
    
    public int expendAroundTheCenter(string s, int left, int right){
        int l = left;
        int r = right;
        while(l >= 0 && r < s.Length && s[l] == s[r] ){
            l --;
            r++;
        }
        
        return r - l - 1; 
    }
}