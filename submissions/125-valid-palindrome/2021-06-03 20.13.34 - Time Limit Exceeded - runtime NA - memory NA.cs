public class Solution {
    public bool IsPalindrome(string s) {
        string str = "";
        Stack<char> chrset = new Stack<char>();
        string res ="" ;
        // Use the Char Class to check if its letter
        foreach(char c in s.ToLower()){
            if(Char.IsLetter(c) || Char.IsDigit(c)){
                chrset.Push(c);
                str += c;
            }
        }
        
        while(chrset.Count > 0){
            res += chrset.Pop();
        }
        Console.WriteLine(str);
        Console.WriteLine(res);
        return res == str;
    }
}