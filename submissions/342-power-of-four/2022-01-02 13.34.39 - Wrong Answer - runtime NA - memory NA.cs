public class Solution {
    public bool IsPowerOfFour(int n) {
        while (n > 0) {
            n /= 4;
        }
        return n == 0;
    }
}