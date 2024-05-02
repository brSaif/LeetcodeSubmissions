public class Solution {
    public void ReverseString(char[] s) {
        int len = s.Length -1;
        for(int i = 0; i < len/2 ; i++){
            char tmp = s[i];
            s[i] = s[len -i];
            s[len -i] = tmp;
        }
    }
}