public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int n = coins.Length;
        int[][] dp = new int[n][];

        for (int i = 0; i < dp.Length; i++){
            dp[i] = new int[10001];
            Array.Fill(dp[i], -1);
        }

        int solve(int idx , int remind){
            if (idx >= n || remind < 0) return Int32.MaxValue - 1;
            if (dp[idx][remind] != -1) return dp[idx][remind];
            if (remind == 0) return 0;
            int op1 = solve(idx + 1, remind);
            int op2 = solve(idx, remind - coins[idx]) + 1;
            return dp[idx][remind] = Math.Min(op1, op2);
        }

        int res = solve(0, amount);
        if (res >= Int32.MaxValue - 1)
            return -1;

        return res;
    }
}