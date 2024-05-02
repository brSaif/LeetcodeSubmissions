public class Solution {
    public int CountOrders(int n) {
        long res = 1;
        int Mod = 1_000_000_007;
        
        for (int i = 1; i <= n; i++){
            res *= i;
            
            res *= (2 * i - 1);
            res %= Mod;
        }
        
        return (int) res;
    }
}