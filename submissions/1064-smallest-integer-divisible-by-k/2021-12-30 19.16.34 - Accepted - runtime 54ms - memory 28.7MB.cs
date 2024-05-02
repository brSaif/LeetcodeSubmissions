public class Solution {
    public int SmallestRepunitDivByK(int k) {
        int len = 1;
        int rem = 1;
        var seen = new HashSet<int>();
        while (rem % k != 0){
            int n = 10 * rem + 1;
            rem = n % k;
            len += 1;
            if(!seen.Add(rem)) return -1;
        }
        
        return len;
    }
}