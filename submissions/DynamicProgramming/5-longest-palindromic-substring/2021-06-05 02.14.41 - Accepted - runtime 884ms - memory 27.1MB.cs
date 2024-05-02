public class Solution {
    int lo = 0;
    int max = 0;
    public string LongestPalindrome(string s) {
        
        if(s.Length==1)
		{
            return s;
		}
        
        for (int i = 0; i < s.Length-1; i++)
        {
            extend(s, i, i);
            extend(s, i, i + 1);
        }

        return s.Substring(lo, max);
        
    }
    
    public void extend(string s, int i, int j)
    {
        while(i < s.Length && j >= 0&&s.Substring(i, 1).Equals(s.Substring(j, 1)))
        {
            i++;
            j--;
        }

        if (max < i - j - 1)
        {
            lo = j + 1;
            max = i - j - 1;
        }
    }
}