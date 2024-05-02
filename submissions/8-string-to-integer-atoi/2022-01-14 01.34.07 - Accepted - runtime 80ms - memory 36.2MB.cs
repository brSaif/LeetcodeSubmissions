public class Solution {
    public int MyAtoi(string s)
    {
        long ans = 0;
        var isNegative = false;

        var prefix = s.SkipWhile(c => Char.IsWhiteSpace(c)).TakeWhile(c => !Char.IsDigit(c));
        if (prefix.Any(c => Char.IsLetter(c) || c == '.') || prefix.Count() > 1)
        {
            return 0;
        }
        else if (prefix.Count() == 1 && prefix.First() == '-')
        {
            isNegative = true;
        }

        var digits = s.SkipWhile(c => !Char.IsDigit(c)).TakeWhile(c => Char.IsDigit(c));
        if (isNegative)
        {
            foreach (var c in digits)
            {
                ans = ans * 10 - (c - '0');
                if (ans < int.MinValue) return int.MinValue;
            }
        }
        else
        {
            foreach (var c in digits)
            {
                ans = ans * 10 + (c - '0');
                if (ans > int.MaxValue) return int.MaxValue;
            }
        }

        return (int) ans;
    
    }
}