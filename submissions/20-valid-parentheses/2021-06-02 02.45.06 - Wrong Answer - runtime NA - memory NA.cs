public class Solution {
    public bool IsValid(string s) {
        IDictionary<char,int> p = new Dictionary<char,int>();
         p.Add('(' , 0 );
        p.Add(')',0);
        p.Add('{',0 );
        p.Add('}',0);
        p.Add('[',0 );
        p.Add(']',0 );
        for(int i = 0; i < s.Length ;i ++){
            p[s[i]]++;
        }
        
        if(p['('] == p[')']
          && p['{'] == p['}']
          && p['['] == p[']']){
            return true;
        }
        
        return false;
    }
}