public class Solution {
    public string MinRemoveToMakeValid(string s) {
        if (s is null || s == string.Empty)
            return s;
        
        var arr = s.ToCharArray();
        s = Helper(arr, '(', ')');
        arr = s.ToCharArray();
        Array.Reverse(arr);
        s = Helper(arr, ')', '(');
        arr = s.ToCharArray();
        Array.Reverse(arr);
    
        return new string(arr);
    }

    private string Helper(char[] arr, char lCheck, char rCheck){
        
        int count = 0;
        var sb = new StringBuilder();
        
        foreach(var c in arr){
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

