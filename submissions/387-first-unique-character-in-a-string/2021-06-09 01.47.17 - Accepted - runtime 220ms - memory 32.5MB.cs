public class Solution {
    public int FirstUniqChar(string s) {
        IDictionary<char,int> count = new Dictionary<char,int>();
        for(int i = 0; i < s.Length ; i++){
            if(!count.ContainsKey(s[i])){
                count.Add(s[i],1);
                continue;
            }
            
            count[s[i]]++;
        }
        
        foreach(var c in count){
            if(c.Value == 1) return s.IndexOf(c.Key);
        }
        
        return -1;
    }
}