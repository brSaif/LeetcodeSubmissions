public class Solution {
    public bool IsPalindrome(string str) {
        int low = 0;
        int hight = str.Length - 1;

        while (hight > low)
        {
            while (low < hight && !char.IsLetterOrDigit(str[low]))
            {
                low++;
            }
            
            while (low < hight && !char.IsLetterOrDigit(str[hight]))
            {
                hight--;
            }

            if (char.ToLower(str[low]) != char.ToLower(str[hight]))
                return false;

            low++;
            hight--;
        }
        
        return true;
    }
}