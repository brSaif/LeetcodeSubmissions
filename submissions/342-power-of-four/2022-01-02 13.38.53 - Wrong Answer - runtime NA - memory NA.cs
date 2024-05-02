public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n < 0) return false;
        return (n  & (n - 1)) == 0;
    }
}