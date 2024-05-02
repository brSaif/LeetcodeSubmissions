public class Solution {
    public bool IsAnagram(string s, string t) {
        Stack<char> stk = new Stack<char>();
        if(s.Length != t.Length) return false;
        foreach(char c in s){
            stk.Push(c);
        }
        foreach(char d in t){
            if(!stk.Contains(d)) return false;
        }
        
        return true;
    }
}