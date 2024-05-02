public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n <= 0) return false;
        double x = Math.Log(n, 4);
        return Math.Pow(4, (int)x) == n;
    }
}