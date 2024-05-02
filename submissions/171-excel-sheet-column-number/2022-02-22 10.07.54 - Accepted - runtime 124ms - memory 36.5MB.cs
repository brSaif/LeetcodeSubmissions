public class Solution {
    public int TitleToNumber(string columnTitle) {
        if (columnTitle == null || columnTitle == string.Empty)
            return 0;
        
        int res = 0;
        
        for (int i = columnTitle.Length - 1; i > -1; i--)
        {
            res += (columnTitle[i] - 'A' + 1) * (int)Math.Pow(26, columnTitle.Length - 1 - i);
        }
        
        return res;
    }
    
}