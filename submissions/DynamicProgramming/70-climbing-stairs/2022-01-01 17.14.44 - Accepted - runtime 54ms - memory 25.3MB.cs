public class Solution {
    public int ClimbStairs(int n) {
        // Top down approach plus memoization
        var memo = new int[n + 1];
        return ClimbStairs(n, memo);
    }
    
    private int ClimbStairs(int n, int[] memo){
        if (n <= 0) memo[0] = 0;
        if (n <= 2) memo[n] = n;
        if (memo[n] != 0) return memo[n];
        
        memo[n] = ClimbStairs( n - 1, memo) + ClimbStairs( n -2, memo);
        return memo[n];
    }
}