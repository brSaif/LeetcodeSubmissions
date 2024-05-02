public class Solution {
    public int CountOrders(int n) {
        long ans = 1;
        int Mod = 1_000_000_007;
        
        for (int i = 1; i <= 2 * n; ++i){
            ans = ans * i;
            if (i % 2 == 0) ans /= 2;
            ans %= Mod;
        }
        
        return (int) ans; 
    }
}