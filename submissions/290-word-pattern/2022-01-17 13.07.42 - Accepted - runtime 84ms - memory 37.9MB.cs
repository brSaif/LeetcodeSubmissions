public class Solution {
     public bool WordPattern(string pattern, string str) {
        return Pattern(pattern.Select(x => x.ToString())) == 
            Pattern(str.Split(' ', StringSplitOptions.RemoveEmptyEntries));
    }
    
    private string Pattern(IEnumerable<string> a) {
        var indexes = a
                .Select((x, i) => new { val = x, idx = i })
                .GroupBy(x => x.val)
                .ToDictionary(x => x.Key, x => x.First().idx);
        
        return string
            .Join(
                ",", 
                a.Select(x => indexes[x]));
    }
}