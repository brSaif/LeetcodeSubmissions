public class Solution {
    public int FirstUniqChar(string s) {
        IDictionary<char,int> ocurr = new Dictionary<char,int>();
        foreach(var c in s){
            if(!ocurr.ContainsKey(c)) ocurr.Add(c,1);
            else ocurr[c] += 1; 
        }
        
        foreach(var kvp in ocurr){
            if(kvp.Value == 1) return s.IndexOf(kvp.Key);
        }
        return -1;
    }
}