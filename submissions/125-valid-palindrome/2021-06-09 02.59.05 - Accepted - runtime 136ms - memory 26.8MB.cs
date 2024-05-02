public class Solution {
    public bool IsPalindrome(string str) {
        IList<char> res = new List<char>();
        var s = str.ToLower();
        foreach(char c in s){
            if(Char.IsLetter(c) ||
              Char.IsDigit(c)){
                res.Add(c);
            }
        }
        
        string a = new string (res.ToArray());
        string b = new string (res.Reverse().ToArray());
        Console.WriteLine(a);
        Console.WriteLine(b);
        return a == b;
    }
}