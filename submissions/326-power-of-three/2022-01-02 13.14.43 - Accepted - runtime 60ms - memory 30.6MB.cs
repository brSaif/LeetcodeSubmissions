public class Solution {
    public bool IsPowerOfThree(int n) {
        int div = (int) Math.Pow(3,(int) Math.Log(Int32.MaxValue, 3));
        return n > 0 && div % n == 0;
    }
    
}