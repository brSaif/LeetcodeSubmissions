public class Solution {
    public int Fib(int n) {
        if(n <= 2) return 1;
        return Fib(n - 1) + Fib(n - 2);
    }
}