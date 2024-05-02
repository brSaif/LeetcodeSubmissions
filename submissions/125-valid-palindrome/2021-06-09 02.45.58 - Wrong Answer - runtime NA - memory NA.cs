public class Solution {
    public bool IsPalindrome(string s) {
        IList<char> res = new List<char>();
        
        foreach(char c in s){
            if(Char.IsLetter(c) &&
              Char.IsDigit(c)){
                res.Add(c);
            }
        }
        
        string a = new string(res.ToArray());
        string b = new string(res.Reverse().ToArray());
        return a == b;
    }
}