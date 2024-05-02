public class Solution {
    public bool IsPowerOfThree(int n) {
        double res = Math.Log(n,3);
        return res % 1 == 0; 
    }
}