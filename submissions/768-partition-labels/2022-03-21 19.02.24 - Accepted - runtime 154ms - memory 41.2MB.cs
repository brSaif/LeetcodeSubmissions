public class Solution {
    public IList<int> PartitionLabels(string s) {
        int[] last = new int[26];
        
        for (int i = 0; i < s.Length; i++)
            last[s[i] - 'a'] = i;
        
        int j = 0, anchor = 0;
        IList<int> res = new List<int>();
        
        for (int i = 0; i < s.Length; i++){
            j = Math.Max(j, last[s[i] - 'a']);
            if (i == j){
                res.Add((i - anchor + 1));
                anchor  = i + 1;
            }
        }
        
        return res;
        
    }
}