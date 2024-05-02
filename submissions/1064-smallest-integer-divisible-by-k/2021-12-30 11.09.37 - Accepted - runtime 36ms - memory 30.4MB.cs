public class Solution {
    public int SmallestRepunitDivByK(int k) {
        
        int rem = 1, len = 1;
        var seenRem = new HashSet<int>();
        while (rem %k != 0){
            int n = rem * 10 +1;
            rem = n%k;
            len += 1;
            if(!seenRem.Add(rem)) return -1;
        }
        return len;
    }
}