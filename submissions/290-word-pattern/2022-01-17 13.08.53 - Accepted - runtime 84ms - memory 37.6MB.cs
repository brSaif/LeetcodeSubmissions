public class Solution {
     public bool WordPattern(string pattern, string str) {
        string[] words = str.Split();
        Dictionary<char,string> patWords = new Dictionary<char,string>();
        Dictionary<string,char> wordPatterns = new Dictionary<string,char>();
        
        if(words.Length != pattern.Length)
        {
            return false;
        }
        
        string val = null;
        char patval = ' ';
        for(int i = 0; i < pattern.Length; i++)
        {
            if(patWords.TryGetValue(pattern[i], out val))
            {
                if(words[i] != val)
                {
                    return false;
                }
            }
            else
            {
                if(wordPatterns.TryGetValue(words[i], out patval))
                {
                    if(pattern[i] != patval)
                    {
                        return false;
                    }                    
                }
                else
                {
                    wordPatterns.Add(words[i], pattern[i]);
                }
                
                patWords.Add(pattern[i], words[i]);
            }                
        }
        
        return true;
    }
}