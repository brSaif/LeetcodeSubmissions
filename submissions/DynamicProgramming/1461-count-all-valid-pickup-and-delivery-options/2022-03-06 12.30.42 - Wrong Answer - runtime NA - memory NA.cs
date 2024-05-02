public class Solution {

    int MOD = 1_000_000_007;
    public int CountOrders(int n) {
        int[,] memo = new int[n + 1, n + 1];
        return TotalWays(n, n, memo);
    }
    
    private int TotalWays(int unpicked, int undelivered, int[,] memo){
        
        if (unpicked == 0 && undelivered == 0) return 1;
        if (unpicked < 0 
            || undelivered <  0 
            || undelivered < unpicked) return 0;
        if (memo[unpicked, undelivered] != 0) return memo[unpicked, undelivered];
        
        long ans = 0;
        
        ans += unpicked * TotalWays(unpicked - 1, undelivered, memo);
        ans %= MOD;
        ans += (undelivered - unpicked) * TotalWays(unpicked, undelivered - 1, memo);
        ans %= MOD;
        return memo[unpicked, undelivered] =  (int)ans;
        
    }
}