public class Solution {
    public bool CheckString(string s) {
        char init = 'a';
        foreach(var c in s){
            if (c == 'a' && init == 'b') return false;
            init = c;
        }
        return true;
    }
}