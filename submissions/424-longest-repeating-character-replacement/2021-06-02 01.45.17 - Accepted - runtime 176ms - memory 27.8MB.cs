public class Solution {
    public int CharacterReplacement(string s, int k) {
        IDictionary<char,int> count = new Dictionary<char,int>();
        int result = 0;
        int left = 0 ;
        int maxF = 0;
        for(int i = 0; i < s.Length; i++){
            if(count.ContainsKey(s[i])){
                count[s[i]]++;
            }else {count.Add(s[i],1); }
            
            while(((i - left +1) - count.Values.Max() ) > k){
                count[s[left]] -=  1;
                left += 1;
            }
            result = Math.Max(result,i - left + 1);
        }
        
        
        
        return result;
    }
}