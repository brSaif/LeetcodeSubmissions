public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var arr = s.ToCharArray();
        s = Helper(arr, '(', ')');
        arr = s.ToCharArray();
        Array.Reverse(arr);
        s = Helper(arr, ')', '(');
        arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    
    private string Helper (char[] s, char lCheck, char rCheck){
        int count = 0;
        var sb = new StringBuilder();
        foreach (var c in s){
            if (c == lCheck)
                count++;
            else if (c == rCheck)
                count--;
            
            if (count >= 0)
                sb.Append(c);
            else 
                count = 0;
        }
        
        return sb.ToString();
    }
}