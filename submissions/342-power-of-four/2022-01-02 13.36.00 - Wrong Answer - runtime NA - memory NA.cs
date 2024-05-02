public class Solution {
    public bool IsPowerOfFour(int n) {
        while (n > 0) {
            n /= 4;
            if (n % 4 != 0) return false;
        }
        return n == 0;
    }
}