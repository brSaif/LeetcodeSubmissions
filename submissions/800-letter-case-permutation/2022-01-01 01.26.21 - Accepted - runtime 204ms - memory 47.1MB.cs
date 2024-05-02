public class Solution {
    public IList<string> LetterCasePermutation(string S) {
        var result = new List<string>();
        var n = S.Length;
        var actual = new char[n];
        
        Dfs(0);
            
        return result;
        
        void Dfs(int i)
        {
            // add all chars that are numbers
            while (i < n && !char.IsLetter(S[i]))
                actual[i] = S[i++];
            
            if (i >= n) // no more chars to process, add actual permutation
            {
                result.Add(new string(actual));
                return;
            }
            
            actual[i] = char.ToLower(S[i]);
            Dfs(i+1);
            
            actual[i] = char.ToUpper(S[i]);
            Dfs(i+1);
        }
    }
}