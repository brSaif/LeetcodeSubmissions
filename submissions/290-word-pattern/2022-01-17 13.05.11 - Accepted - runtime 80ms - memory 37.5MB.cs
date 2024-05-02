public class Solution {
    public bool WordPattern(string pattern, string str) {
        var Array_Str = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var Array_Pat = pattern.ToCharArray();

            return Array_Pat.Select(x => Array.IndexOf(Array_Pat, x)).ToList()
                    .SequenceEqual(Array_Str.Select(x => Array.IndexOf(Array_Str, x)).ToList());
    }
}