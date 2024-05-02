public class Solution {
    public int CountSubstrings(string s) {
        int res = 0;
        for(int i = 0; i < s.Length ; i++){
            res += countPali(s,i,i);
            res += countPali(s,i,i+1);
        }
        
        return res;
    }
    
    public int countPali(string s, int left, int right){
        int ans = 0;
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            ans ++;
            left--;
            right++;
        }
        return ans;
    }
}