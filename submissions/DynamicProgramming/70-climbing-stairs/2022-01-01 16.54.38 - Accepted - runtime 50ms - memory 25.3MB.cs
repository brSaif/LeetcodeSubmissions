public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 0) return 0;
        if (n <= 2) return n;
        int pre = 1, res = 2, count = 3;
        while (count <= n) {
            int tmp = res;
            res += pre;
            pre = tmp;
            count ++;
        }
        
        return res;
    }
}