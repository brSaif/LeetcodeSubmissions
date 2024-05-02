public class Solution {
    public bool IsPowerOfThree(int n) {
        // First Approach
        // this has a precision bug it returns 0.99999999 instead of 1 for 243 like cases 
        // var res = Math.Log(n,3) % 1;
        // return res == 0 ; 
        return 1162261467 % n == 0;
    }
}