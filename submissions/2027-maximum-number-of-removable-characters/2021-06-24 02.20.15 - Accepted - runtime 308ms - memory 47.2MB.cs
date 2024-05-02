public class Solution {
    public int MaximumRemovals(string s, string p, int[] removable) {
        
        int li = 0, ri = removable.Length;
        
        while (li <= ri)
        {
            int mi = li + (ri - li) / 2;
            
            var removedArray = s.ToCharArray();
            
            for (int i = 0; i < mi; i++)
            {
                int idx = removable[i];
                removedArray[idx] = '/';
            }  
            
            if (IsSubsequence(removedArray, p))
                li = mi + 1;
            else
                ri = mi - 1;
        }
        
        return ri;
        
    }
    
    
    private bool IsSubsequence(char[] chars, string p)
    {
        int i = 0, j = 0;
        
        while (i < chars.Length && j < p.Length)
        {
            if (chars[i] == p[j])
                j++;
            
            i++;                
        }
        
        return j == p.Length;
    }
}