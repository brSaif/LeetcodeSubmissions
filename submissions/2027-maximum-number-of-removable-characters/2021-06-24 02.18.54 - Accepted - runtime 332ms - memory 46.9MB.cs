public class Solution {
   
        public int MaximumRemovals(String s, String p, int[] removable) {
        
        char[] letters = s.ToCharArray();
        //Set up my boundaries.
        int l = 0, r = removable.Length;
        while (l <= r) {
            int mid = (l+r)/2;
            for (int i = 0; i < mid; i++) letters[removable[i]] = '/';
            
            if (check(letters,p)) l = mid+1;
            
            else {
                for (int i=0;i<mid;i++) letters[removable[i]] = s[removable[i]];
                r = mid-1;
            }
        }
        return r;
    }
    
    public bool check(char[] letters, String p) {
        int i1 = 0, i2 = 0;
        while (i1 < letters.Length && i2 < p.Length) {
            char curr = letters[i1], curr2 = p[i2];
            if (curr != '/' && curr == curr2) i2++;
            i1++;
        }
        
        if (i2 == p.Length) return true;
        return false;
    }
    
}