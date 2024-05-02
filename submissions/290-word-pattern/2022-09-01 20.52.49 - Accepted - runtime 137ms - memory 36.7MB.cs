public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        var str = s.Split(" ");
        if (pattern.Length != str.Length)
            return false;
        Dictionary<char, string> dicPattern = new Dictionary<char, string>();
        Dictionary<string, char> dicStr = new Dictionary<string, char>();
        for(int i = 0; i<pattern.Length; i++)
        {

            if (!dicPattern.ContainsKey(pattern[i]))
            {
                dicPattern.Add(pattern[i], str[i]);
                if (dicStr.ContainsKey(str[i]))
                {
                    return false;
                }
                dicStr.Add(str[i], pattern[i]);
            }
            else
            {
                if (str[i] != dicPattern[pattern[i]] || dicStr[str[i]] != pattern[i])
                {
                    return false;
                }
            }
        }
        return true;
    }
}