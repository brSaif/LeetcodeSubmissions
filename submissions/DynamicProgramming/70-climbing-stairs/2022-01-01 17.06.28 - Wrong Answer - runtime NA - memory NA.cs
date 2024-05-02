public class Solution {
    public int ClimbStairs(int n) {
        // Top down approach 
        var memo = new int[n];
        return ClimbStairs(n -1, memo) + ClimbStairs(n - 2, memo) ;
    }
    
    private int ClimbStairs(int n, int[] memo){
        if (n <= 2) return n;
        if (memo[n] != 0) return memo[n];
        
        memo[n] = ClimbStairs( n - 1, memo) + ClimbStairs( n -2, memo);
        return memo[n];
    }
}