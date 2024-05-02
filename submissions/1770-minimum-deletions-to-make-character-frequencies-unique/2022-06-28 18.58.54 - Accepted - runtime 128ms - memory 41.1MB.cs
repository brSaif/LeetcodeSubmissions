public class Solution {
    public int MinDeletions(string s) {
        
        int[] freq = new int[26];
        for (int i = 0; i < s.Length; i++)
            freq[s[i] - 'a']++;
        
        int deleteCount = 0;
        
        HashSet<int> seenFreq = new();
        for (int i = 0; i < 26; i++){
            while (freq[i] > 0 && !seenFreq.Add(freq[i]))
            {
                freq[i]--;
                deleteCount++;
            }
            
            //seenFreq.Add(freq[i]);
        }
        
        return deleteCount;
    }
            
}